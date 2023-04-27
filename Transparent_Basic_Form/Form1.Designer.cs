namespace Transparent_Basic_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.White;
            button1.Location = new Point(185, 199);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 0;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 21);
            label1.TabIndex = 1;
            label1.Text = "x";
            label1.Click += label1_Click;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(81, 181);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of courses to register:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(99, 75);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 4;
            label3.Text = "UTEPSA - Online Courses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(81, 39);
            label4.Name = "label4";
            label4.Size = new Size(180, 36);
            label4.TabIndex = 5;
            label4.Text = "LEARNIFY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(302, 260);
            label5.Name = "label5";
            label5.Size = new Size(27, 12);
            label5.TabIndex = 6;
            label5.Text = "GP-4";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Online_teacher;
            pictureBox1.Location = new Point(130, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.login_winForm_DSA_utepsa;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(341, 281);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}