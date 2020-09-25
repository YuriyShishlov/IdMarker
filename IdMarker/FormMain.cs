using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IdMarker.BL;

namespace IdMarker
{
    public partial class FormMain : Form
    {
        ICopyFlash copyFlash;//здесь сокрыт класс, реализующий всю логику

        public FormMain(ICopyFlash copyFlash)
        {
            InitializeComponent();

            //Конкретная реализация ICopyFlash поставляется Autofac
            this.copyFlash = copyFlash;
            //подписываемся на событие пустого файла c ID
            copyFlash.IdEmpty += MessageBoxIdEmpty;
            //подписываемся на событие: В выбранной папке должен быть только один текстовый файл .txt
            copyFlash.OnlyOneTxt += MessageBoxOnlyOneTx;
        }
        private void MessageBoxIdEmpty(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый файл с ID пустой");
        }
        private void MessageBoxOnlyOneTx(object sender, EventArgs e)
        {
            MessageBox.Show("В выбранной папке должен быть только один текстовый файл .txt, содержащий подстроку 'ID'");
        }
        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //Отобразить выбранную папку в TextBox
                textBoxSourceDirName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //Если textBox пустой и не выбран источник, откуда копировать, то:
            if (textBoxSourceDirName.Text == "")
            {
                MessageBox.Show("Выберите папку на флешке, откуда брать:");
                return;
            }

            //Directory.GetCurrentDirectory()[0] - берем первую букву текущей директории
            //textBoxSelectFolder.Substring(1) - вырезаем первую букву из выбранного пути
            string destDirName = Directory.GetCurrentDirectory()[0] + textBoxSourceDirName.Text.Substring(1); ;//путь, куда копировать

            copyFlash.DirectoryCopy(textBoxSourceDirName.Text, destDirName, true);//true - поддиректории копировать тоже

            //В текстовом файле, где  ID, нужно прибавить число
            copyFlash.AddIdInFile(textBoxSourceDirName.Text, textBoxAddNumber.Text);
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {

            openFileDialogInputFile.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialogInputFile.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectFile.Text = openFileDialogInputFile.FileName;
                //Создание файла zero.txt
                File.Copy(textBoxSelectFile.Text, Directory.GetCurrentDirectory() + "\\" + "zero.txt", true);
            }
        }

        private void buttonZeroNumberOfFirmware_Click(object sender, EventArgs e)
        {
            //Если textBox пустой и не выбран источник, откуда копировать, то:
            if (textBoxSelectFile.Text == "")
            {
                MessageBox.Show("Выберите файл с ID на флешке, откуда считать:");
                return;
            }

            if (Path.GetExtension(textBoxSelectFile.Text) != ".txt")
            {
                MessageBox.Show("Выберите файл с расширением .txt:");
                return;
            }

            //берем оттуда содержимое
            string[] numberCurrentOfFirmware = File.ReadAllLines(textBoxSelectFile.Text, Encoding.Default);

            if (numberCurrentOfFirmware.Length == 0)
            {
                MessageBox.Show("Текстовый файл с ID пустой");
                return;
            }

            string str = null;
            foreach (var item in numberCurrentOfFirmware)
            {
                str += item;
            }
            bool IsDigit = str.Length == str.Where(c => char.IsDigit(c)).Count();
            if (IsDigit == false)
            {
                MessageBox.Show("Текстовый файл с ID содержит не цифровые символы");
                return;
            }

            //берем оттуда содержимое
            string[] numberZerotOfFirmware = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\" + "zero.txt", Encoding.Default);
            //результат вычитания помещаем в TexBox
            textBoxNumberOfFirmware.Text = (int.Parse(numberCurrentOfFirmware[0]) - int.Parse(numberZerotOfFirmware[0])).ToString();
        }

        
    }
}
