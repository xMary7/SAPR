namespace WindowsFormsApp1
{
    partial class MainWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.refPageTB = new System.Windows.Forms.TextBox();
            this.testedPageTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataTypeCB = new System.Windows.Forms.ComboBox();
            this.accuracyLb = new System.Windows.Forms.Label();
            this.timeProfit = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Users\\User\\Documents\\data1.txt";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "20";
            // 
            // refPageTB
            // 
            this.refPageTB.Location = new System.Drawing.Point(659, 42);
            this.refPageTB.Name = "refPageTB";
            this.refPageTB.Size = new System.Drawing.Size(100, 26);
            this.refPageTB.TabIndex = 2;
            // 
            // testedPageTB
            // 
            this.testedPageTB.Location = new System.Drawing.Point(659, 99);
            this.testedPageTB.Name = "testedPageTB";
            this.testedPageTB.Size = new System.Drawing.Size(100, 26);
            this.testedPageTB.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lance-Wiliams",
            "FastLance-Wiliams"});
            this.comboBox1.Location = new System.Drawing.Point(94, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Lance-Wiliams";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "nearest neightbor",
            "furthest neightbor",
            "average",
            "centroid",
            "Wards"});
            this.comboBox2.Location = new System.Drawing.Point(94, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 28);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "nearest neighbor";
            // 
            // dataTypeCB
            // 
            this.dataTypeCB.FormattingEnabled = true;
            this.dataTypeCB.Items.AddRange(new object[] {
            "dichotomic",
            "numeric"});
            this.dataTypeCB.Location = new System.Drawing.Point(94, 214);
            this.dataTypeCB.Name = "dataTypeCB";
            this.dataTypeCB.Size = new System.Drawing.Size(172, 28);
            this.dataTypeCB.TabIndex = 6;
            this.dataTypeCB.Text = "numeric";
            // 
            // accuracyLb
            // 
            this.accuracyLb.AutoSize = true;
            this.accuracyLb.Location = new System.Drawing.Point(655, 268);
            this.accuracyLb.Name = "accuracyLb";
            this.accuracyLb.Size = new System.Drawing.Size(90, 20);
            this.accuracyLb.TabIndex = 8;
            this.accuracyLb.Text = "accuracyLb";
            // 
            // timeProfit
            // 
            this.timeProfit.AutoSize = true;
            this.timeProfit.Location = new System.Drawing.Point(668, 337);
            this.timeProfit.Name = "timeProfit";
            this.timeProfit.Size = new System.Drawing.Size(51, 20);
            this.timeProfit.TabIndex = 9;
            this.timeProfit.Text = "label3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Choose";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Execute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.timeProfit);
            this.Controls.Add(this.accuracyLb);
            this.Controls.Add(this.dataTypeCB);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.testedPageTB);
            this.Controls.Add(this.refPageTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox refPageTB;
        private System.Windows.Forms.TextBox testedPageTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox dataTypeCB;
        private System.Windows.Forms.Label accuracyLb;
        private System.Windows.Forms.Label timeProfit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

