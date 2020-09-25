namespace IdMarker
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxAddNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBoxSourceDirName = new System.Windows.Forms.TextBox();
            this.labelSelectFolder = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonZeroNumberOfFirmware = new System.Windows.Forms.Button();
            this.labelNumberOfFirmware = new System.Windows.Forms.Label();
            this.textBoxNumberOfFirmware = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogInputFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCopy);
            this.groupBox1.Controls.Add(this.textBoxAddNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSelectFolder);
            this.groupBox1.Controls.Add(this.textBoxSourceDirName);
            this.groupBox1.Controls.Add(this.labelSelectFolder);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Копирование флешки";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 128);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(269, 23);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxAddNumber
            // 
            this.textBoxAddNumber.Location = new System.Drawing.Point(200, 91);
            this.textBoxAddNumber.Name = "textBoxAddNumber";
            this.textBoxAddNumber.Size = new System.Drawing.Size(84, 20);
            this.textBoxAddNumber.TabIndex = 10;
            this.textBoxAddNumber.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "2. Выберите количество прошивок:";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(200, 50);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(84, 23);
            this.buttonSelectFolder.TabIndex = 8;
            this.buttonSelectFolder.Text = "Выбор папки";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // textBoxSourceDirName
            // 
            this.textBoxSourceDirName.Location = new System.Drawing.Point(15, 51);
            this.textBoxSourceDirName.Name = "textBoxSourceDirName";
            this.textBoxSourceDirName.Size = new System.Drawing.Size(179, 20);
            this.textBoxSourceDirName.TabIndex = 7;
            // 
            // labelSelectFolder
            // 
            this.labelSelectFolder.AutoSize = true;
            this.labelSelectFolder.Location = new System.Drawing.Point(12, 23);
            this.labelSelectFolder.Name = "labelSelectFolder";
            this.labelSelectFolder.Size = new System.Drawing.Size(234, 13);
            this.labelSelectFolder.TabIndex = 6;
            this.labelSelectFolder.Text = "1. Выберите папку на флешке, откуда брать:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonZeroNumberOfFirmware);
            this.groupBox2.Controls.Add(this.labelNumberOfFirmware);
            this.groupBox2.Controls.Add(this.textBoxNumberOfFirmware);
            this.groupBox2.Controls.Add(this.buttonSelectFile);
            this.groupBox2.Controls.Add(this.textBoxSelectFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Узнать количество прошивок";
            // 
            // buttonZeroNumberOfFirmware
            // 
            this.buttonZeroNumberOfFirmware.Location = new System.Drawing.Point(200, 98);
            this.buttonZeroNumberOfFirmware.Name = "buttonZeroNumberOfFirmware";
            this.buttonZeroNumberOfFirmware.Size = new System.Drawing.Size(84, 23);
            this.buttonZeroNumberOfFirmware.TabIndex = 17;
            this.buttonZeroNumberOfFirmware.Text = "Сколько";
            this.buttonZeroNumberOfFirmware.UseVisualStyleBackColor = true;
            this.buttonZeroNumberOfFirmware.Click += new System.EventHandler(this.buttonZeroNumberOfFirmware_Click);
            // 
            // labelNumberOfFirmware
            // 
            this.labelNumberOfFirmware.AutoSize = true;
            this.labelNumberOfFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfFirmware.Location = new System.Drawing.Point(12, 104);
            this.labelNumberOfFirmware.Name = "labelNumberOfFirmware";
            this.labelNumberOfFirmware.Size = new System.Drawing.Size(122, 13);
            this.labelNumberOfFirmware.TabIndex = 16;
            this.labelNumberOfFirmware.Text = "Количество прошивок:";
            // 
            // textBoxNumberOfFirmware
            // 
            this.textBoxNumberOfFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfFirmware.Location = new System.Drawing.Point(140, 100);
            this.textBoxNumberOfFirmware.Name = "textBoxNumberOfFirmware";
            this.textBoxNumberOfFirmware.Size = new System.Drawing.Size(54, 20);
            this.textBoxNumberOfFirmware.TabIndex = 15;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(200, 59);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(84, 23);
            this.buttonSelectFile.TabIndex = 14;
            this.buttonSelectFile.Text = "Выбор файла";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.Location = new System.Drawing.Point(15, 61);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.Size = new System.Drawing.Size(179, 20);
            this.textBoxSelectFile.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите файл с ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IdMarker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonZeroNumberOfFirmware;
        private System.Windows.Forms.Label labelNumberOfFirmware;
        private System.Windows.Forms.TextBox textBoxNumberOfFirmware;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxAddNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxSourceDirName;
        private System.Windows.Forms.Label labelSelectFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialogInputFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

