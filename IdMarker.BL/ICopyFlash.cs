using System;
using System.IO;
using System.Text;

namespace IdMarker.BL
{
    public interface ICopyFlash
    {
        void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs);
        void AddIdInFile(string sourceDirName, string addNumber);
        event EventHandler IdEmpty;
        event EventHandler OnlyOneTxt;
    }

    public class CopyFlash : ICopyFlash
    {
        public event EventHandler IdEmpty; // Объявление событий
        public event EventHandler OnlyOneTxt;

        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Получить подкаталоги для указанного каталога.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Исходный каталог не существует или не может быть найден: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // Если целевой каталог существует, удалите его.
            if (Directory.Exists(destDirName))
            {
                Directory.Delete(destDirName, true);
            }
            // Если целевой каталог не существует, создайте его.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            // Получить файлы в каталоге и скопировать их в новое место.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // При копировании подкаталогов, скопируйте их и их содержимое в новое место.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public void AddIdInFile(string sourceDirName, string addNumber)
        {
            //В текстовом файле, где  ID, нужно прибавить число

            //Ищем файлы с расширением .txt на исходной флешке
            var fileTxt = Directory.GetFiles(sourceDirName, "*.txt");

            //В массиве файлов с расшрением .txt, ищем файлы, содержащие подстроку 'ID'
            int indexId = 0;
            int countId = 0;
            for (int i = 0; i < fileTxt.Length; i++)
            {
                if (fileTxt[i].Contains("ID"))
                {
                    indexId = i;
                    ++countId;
                }
                if (countId > 1)
                {
                    //MessageBox.Show("В выбранной папке должен быть только один текстовый файл .txt, содержащий подстроку 'ID'");
                    OnlyOneTxt?.Invoke(this, EventArgs.Empty);
                    return;
                }
            }

            //берем оттуда содержимое
            string[] countTxt = File.ReadAllLines(fileTxt[indexId], Encoding.Default);

            if (countTxt.Length == 0)
            {
                //MessageBox.Show("Текстовый файл с ID пустой");
                IdEmpty?.Invoke(this, EventArgs.Empty);
                return;
            }

            //записываем одну строку в текстовый файл на исходной флешке
            using (var sw = new StreamWriter(fileTxt[indexId], false))
            {
                sw.WriteLine(
                    //преобразуем string из текстового поля в число
                    int.Parse(countTxt[0]) +
                    //преобразуем string из textBoxAddNumber в число
                    int.Parse(addNumber));
            }
        }
    }
}