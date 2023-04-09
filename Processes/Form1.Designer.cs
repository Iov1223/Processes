namespace Processes
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
            this.buttonCMD = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPowerPnt = new System.Windows.Forms.Button();
            this.buttonEdgeBrowser = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCMD
            // 
            this.buttonCMD.BackgroundImage = global::Processes.Properties.Resources.cmd;
            this.buttonCMD.Location = new System.Drawing.Point(660, 36);
            this.buttonCMD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCMD.Name = "buttonCMD";
            this.buttonCMD.Size = new System.Drawing.Size(67, 62);
            this.buttonCMD.TabIndex = 5;
            this.buttonCMD.UseVisualStyleBackColor = true;
            this.buttonCMD.Click += new System.EventHandler(this.buttonCMD_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackgroundImage = global::Processes.Properties.Resources.Excel;
            this.buttonExcel.Location = new System.Drawing.Point(269, 36);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(67, 62);
            this.buttonExcel.TabIndex = 4;
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonPowerPnt
            // 
            this.buttonPowerPnt.BackgroundImage = global::Processes.Properties.Resources.PowerPoint;
            this.buttonPowerPnt.Location = new System.Drawing.Point(408, 37);
            this.buttonPowerPnt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPowerPnt.Name = "buttonPowerPnt";
            this.buttonPowerPnt.Size = new System.Drawing.Size(67, 62);
            this.buttonPowerPnt.TabIndex = 3;
            this.buttonPowerPnt.UseVisualStyleBackColor = true;
            this.buttonPowerPnt.Click += new System.EventHandler(this.buttonPowerPnt_Click);
            // 
            // buttonEdgeBrowser
            // 
            this.buttonEdgeBrowser.BackgroundImage = global::Processes.Properties.Resources.edge;
            this.buttonEdgeBrowser.Location = new System.Drawing.Point(535, 36);
            this.buttonEdgeBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdgeBrowser.Name = "buttonEdgeBrowser";
            this.buttonEdgeBrowser.Size = new System.Drawing.Size(67, 62);
            this.buttonEdgeBrowser.TabIndex = 2;
            this.buttonEdgeBrowser.UseVisualStyleBackColor = true;
            this.buttonEdgeBrowser.Click += new System.EventHandler(this.buttonEdgeBrowser_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.BackgroundImage = global::Processes.Properties.Resources.word;
            this.buttonWord.Location = new System.Drawing.Point(133, 37);
            this.buttonWord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(67, 62);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackgroundImage = global::Processes.Properties.Resources.calculator_icon_icons_com_72046;
            this.buttonCalc.Location = new System.Drawing.Point(17, 36);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(67, 63);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(17, 128);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(710, 29);
            this.buttonLog.TabIndex = 6;
            this.buttonLog.Text = "Залогировать текущие процессы";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 187);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonCMD);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonPowerPnt);
            this.Controls.Add(this.buttonEdgeBrowser);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonCalc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonEdgeBrowser;
        private System.Windows.Forms.Button buttonPowerPnt;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonCMD;
        private System.Windows.Forms.Button buttonLog;
    }
}

