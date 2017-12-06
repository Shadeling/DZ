namespace lab4.csh
{
    partial class Form1
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
            this.buttonExact = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.buttonApprox = new System.Windows.Forms.Button();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(440, 38);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(100, 23);
            this.buttonExact.TabIndex = 0;
            this.buttonExact.Text = "Поиск";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(485, 12);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(138, 20);
            this.textBoxFind.TabIndex = 1;
            this.textBoxFind.Text = "искомое слово";
            this.textBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(13, 12);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(421, 199);
            this.listBoxResult.TabIndex = 2;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 227);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(109, 60);
            this.buttonLoadFile.TabIndex = 3;
            this.buttonLoadFile.Text = "Загрузить файйл";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(127, 227);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileReadTime.TabIndex = 4;
            this.textBoxFileReadTime.Text = "время загрузки";
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(127, 267);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileReadCount.TabIndex = 5;
            this.textBoxFileReadCount.Text = "кол-во слов";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(581, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(453, 267);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveReport.TabIndex = 7;
            this.buttonSaveReport.Text = "Сохранить";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(440, 67);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxExactTime.TabIndex = 8;
            this.textBoxExactTime.Text = "время поиска";
            // 
            // buttonApprox
            // 
            this.buttonApprox.Location = new System.Drawing.Point(566, 38);
            this.buttonApprox.Name = "buttonApprox";
            this.buttonApprox.Size = new System.Drawing.Size(100, 23);
            this.buttonApprox.TabIndex = 9;
            this.buttonApprox.Text = "Нечеткий поиск";
            this.buttonApprox.UseVisualStyleBackColor = true;
            this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(566, 67);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxApproxTime.TabIndex = 10;
            this.textBoxApproxTime.Text = "время поиска";
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(566, 93);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxDist.TabIndex = 11;
            this.textBoxMaxDist.Text = "допустимые ош.";
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Location = new System.Drawing.Point(566, 120);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreads.TabIndex = 12;
            this.textBoxThreads.Text = "кол-во потоков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 299);
            this.Controls.Add(this.textBoxThreads);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.buttonApprox);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonExact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.Button buttonApprox;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.TextBox textBoxThreads;
    }
}

