namespace Double_Sybtitle
{
    partial class MainForm
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
            this.labelFirstFile = new System.Windows.Forms.Label();
            this.labelSecondSubtitle = new System.Windows.Forms.Label();
            this.labelDoubleSubtitles = new System.Windows.Forms.Label();
            this.buttonOpenFirsFile = new System.Windows.Forms.Button();
            this.buttonOpenSecondFile = new System.Windows.Forms.Button();
            this.buttonSeveFile = new System.Windows.Forms.Button();
            this.colorDiolog = new System.Windows.Forms.ColorDialog();
            this.ColorFirstSubtitle = new System.Windows.Forms.Button();
            this.ColorSecondSybtitle = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstFile
            // 
            this.labelFirstFile.AutoSize = true;
            this.labelFirstFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstFile.Location = new System.Drawing.Point(37, 40);
            this.labelFirstFile.Name = "labelFirstFile";
            this.labelFirstFile.Size = new System.Drawing.Size(95, 20);
            this.labelFirstFile.TabIndex = 0;
            this.labelFirstFile.Text = "Firts subtitle";
            // 
            // labelSecondSubtitle
            // 
            this.labelSecondSubtitle.AutoSize = true;
            this.labelSecondSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondSubtitle.Location = new System.Drawing.Point(37, 120);
            this.labelSecondSubtitle.Name = "labelSecondSubtitle";
            this.labelSecondSubtitle.Size = new System.Drawing.Size(119, 20);
            this.labelSecondSubtitle.TabIndex = 1;
            this.labelSecondSubtitle.Text = "Second subtitle";
            // 
            // labelDoubleSubtitles
            // 
            this.labelDoubleSubtitles.AutoSize = true;
            this.labelDoubleSubtitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoubleSubtitles.Location = new System.Drawing.Point(37, 207);
            this.labelDoubleSubtitles.Name = "labelDoubleSubtitles";
            this.labelDoubleSubtitles.Size = new System.Drawing.Size(115, 20);
            this.labelDoubleSubtitles.TabIndex = 2;
            this.labelDoubleSubtitles.Text = "Double subtitle";
            // 
            // buttonOpenFirsFile
            // 
            this.buttonOpenFirsFile.Location = new System.Drawing.Point(174, 37);
            this.buttonOpenFirsFile.Name = "buttonOpenFirsFile";
            this.buttonOpenFirsFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFirsFile.TabIndex = 3;
            this.buttonOpenFirsFile.Text = "Open";
            this.buttonOpenFirsFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenSecondFile
            // 
            this.buttonOpenSecondFile.Location = new System.Drawing.Point(174, 117);
            this.buttonOpenSecondFile.Name = "buttonOpenSecondFile";
            this.buttonOpenSecondFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenSecondFile.TabIndex = 4;
            this.buttonOpenSecondFile.Text = "Open";
            this.buttonOpenSecondFile.UseVisualStyleBackColor = true;
            // 
            // buttonSeveFile
            // 
            this.buttonSeveFile.Enabled = false;
            this.buttonSeveFile.Location = new System.Drawing.Point(174, 204);
            this.buttonSeveFile.Name = "buttonSeveFile";
            this.buttonSeveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSeveFile.TabIndex = 5;
            this.buttonSeveFile.Text = "Save";
            this.buttonSeveFile.UseVisualStyleBackColor = true;
            // 
            // colorDiolog
            // 
            this.colorDiolog.Color = System.Drawing.Color.White;
            // 
            // ColorFirstSubtitle
            // 
            this.ColorFirstSubtitle.BackColor = System.Drawing.Color.LightGray;
            this.ColorFirstSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorFirstSubtitle.ForeColor = System.Drawing.Color.White;
            this.ColorFirstSubtitle.Location = new System.Drawing.Point(288, 37);
            this.ColorFirstSubtitle.Name = "ColorFirstSubtitle";
            this.ColorFirstSubtitle.Size = new System.Drawing.Size(82, 61);
            this.ColorFirstSubtitle.TabIndex = 6;
            this.ColorFirstSubtitle.Text = "Color";
            this.ColorFirstSubtitle.UseVisualStyleBackColor = false;
            this.ColorFirstSubtitle.Click += new System.EventHandler(this.ColorFirstSubtitle_Click);
            // 
            // ColorSecondSybtitle
            // 
            this.ColorSecondSybtitle.BackColor = System.Drawing.Color.LightGray;
            this.ColorSecondSybtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorSecondSybtitle.ForeColor = System.Drawing.Color.White;
            this.ColorSecondSybtitle.Location = new System.Drawing.Point(288, 120);
            this.ColorSecondSybtitle.Name = "ColorSecondSybtitle";
            this.ColorSecondSybtitle.Size = new System.Drawing.Size(82, 61);
            this.ColorSecondSybtitle.TabIndex = 7;
            this.ColorSecondSybtitle.Text = "Color";
            this.ColorSecondSybtitle.UseVisualStyleBackColor = false;
            this.ColorSecondSybtitle.Click += new System.EventHandler(this.ColorSecondSybtitle_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(398, 61);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(398, 144);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Text size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Text size";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ColorSecondSybtitle);
            this.Controls.Add(this.ColorFirstSubtitle);
            this.Controls.Add(this.buttonSeveFile);
            this.Controls.Add(this.buttonOpenSecondFile);
            this.Controls.Add(this.buttonOpenFirsFile);
            this.Controls.Add(this.labelDoubleSubtitles);
            this.Controls.Add(this.labelSecondSubtitle);
            this.Controls.Add(this.labelFirstFile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "double subtitle creation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstFile;
        private System.Windows.Forms.Label labelSecondSubtitle;
        private System.Windows.Forms.Label labelDoubleSubtitles;
        private System.Windows.Forms.Button buttonOpenFirsFile;
        private System.Windows.Forms.Button buttonOpenSecondFile;
        private System.Windows.Forms.Button buttonSeveFile;
        private System.Windows.Forms.ColorDialog colorDiolog;
        private System.Windows.Forms.Button ColorFirstSubtitle;
        private System.Windows.Forms.Button ColorSecondSybtitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

