namespace ProjeArayuz
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(progressBar4);
            groupBox1.Controls.Add(progressBar3);
            groupBox1.Controls.Add(progressBar2);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Location = new Point(51, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sonuç Grafikleri";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(51, 246);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Seçenek 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(51, 295);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 24);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Seçenek 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(51, 340);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 24);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Seçenek 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(51, 387);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(96, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Seçenek 4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(51, 450);
            button1.Name = "button1";
            button1.Size = new Size(136, 57);
            button1.TabIndex = 5;
            button1.Text = "ONAYLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(336, 450);
            button2.Name = "button2";
            button2.Size = new Size(136, 57);
            button2.TabIndex = 6;
            button2.Text = "Çubuk Grafiğinde Gör";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(621, 450);
            button3.Name = "button3";
            button3.Size = new Size(136, 57);
            button3.TabIndex = 7;
            button3.Text = "Pasta Grafiğinde Gör";
            button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(82, 55);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(26, 94);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(238, 55);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(26, 94);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(410, 55);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(26, 94);
            progressBar3.TabIndex = 2;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(587, 55);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(26, 94);
            progressBar4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 190);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 8;
            label1.Text = "Seçenek 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 9;
            label2.Text = "Seçenek 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 190);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 10;
            label3.Text = "Seçenek 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 190);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 11;
            label4.Text = "Seçenek 4";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 519);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}