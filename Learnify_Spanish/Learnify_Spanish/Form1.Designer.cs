namespace Learnify_Spanish
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
            btnMinimize = new Button();
            btnClose1 = new Button();
            ptbBook = new PictureBox();
            lblRegisterCourse = new Label();
            lblToAdd = new Label();
            lblHowMany = new Label();
            lblSubheaderF1 = new Label();
            btnGetStarted = new Button();
            label2 = new Label();
            txtNumeroDeCursos = new TextBox();
            lblHeaderF1 = new Label();
            ptbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.Snow;
            btnMinimize.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimize.Location = new Point(508, 8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 23);
            btnMinimize.TabIndex = 25;
            btnMinimize.Text = "_";
            btnMinimize.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose1
            // 
            btnClose1.BackColor = Color.Transparent;
            btnClose1.Cursor = Cursors.Hand;
            btnClose1.FlatAppearance.BorderSize = 0;
            btnClose1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose1.FlatStyle = FlatStyle.Flat;
            btnClose1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose1.ForeColor = Color.Snow;
            btnClose1.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose1.Location = new Point(533, 10);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(24, 23);
            btnClose1.TabIndex = 24;
            btnClose1.Text = "x";
            btnClose1.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose1.UseVisualStyleBackColor = false;
            // 
            // ptbBook
            // 
            ptbBook.BackColor = Color.Transparent;
            ptbBook.BackgroundImage = Properties.Resources.bookLogo;
            ptbBook.BackgroundImageLayout = ImageLayout.Zoom;
            ptbBook.Location = new Point(92, 288);
            ptbBook.Name = "ptbBook";
            ptbBook.Size = new Size(120, 94);
            ptbBook.TabIndex = 23;
            ptbBook.TabStop = false;
            // 
            // lblRegisterCourse
            // 
            lblRegisterCourse.AutoSize = true;
            lblRegisterCourse.BackColor = Color.Transparent;
            lblRegisterCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterCourse.ForeColor = SystemColors.MenuBar;
            lblRegisterCourse.Location = new Point(251, 294);
            lblRegisterCourse.Name = "lblRegisterCourse";
            lblRegisterCourse.Size = new Size(179, 15);
            lblRegisterCourse.TabIndex = 22;
            lblRegisterCourse.Text = "Registra algunos cursos nuevos";
            // 
            // lblToAdd
            // 
            lblToAdd.AutoSize = true;
            lblToAdd.BackColor = Color.Transparent;
            lblToAdd.ForeColor = SystemColors.MenuBar;
            lblToAdd.Location = new Point(251, 324);
            lblToAdd.Name = "lblToAdd";
            lblToAdd.Size = new Size(94, 15);
            lblToAdd.TabIndex = 21;
            lblToAdd.Text = "agregar hoy dia?";
            // 
            // lblHowMany
            // 
            lblHowMany.AutoSize = true;
            lblHowMany.BackColor = Color.Transparent;
            lblHowMany.ForeColor = SystemColors.MenuBar;
            lblHowMany.Location = new Point(251, 309);
            lblHowMany.Name = "lblHowMany";
            lblHowMany.Size = new Size(146, 15);
            lblHowMany.TabIndex = 20;
            lblHowMany.Text = "Cuantos cursos te gustaria";
            // 
            // lblSubheaderF1
            // 
            lblSubheaderF1.AutoSize = true;
            lblSubheaderF1.BackColor = Color.Transparent;
            lblSubheaderF1.ForeColor = SystemColors.MenuBar;
            lblSubheaderF1.Location = new Point(193, 232);
            lblSubheaderF1.Name = "lblSubheaderF1";
            lblSubheaderF1.Size = new Size(134, 15);
            lblSubheaderF1.TabIndex = 19;
            lblSubheaderF1.Text = "Un poco cada dia suma.";
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.Transparent;
            btnGetStarted.Cursor = Cursors.Hand;
            btnGetStarted.FlatAppearance.BorderSize = 0;
            btnGetStarted.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGetStarted.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetStarted.ForeColor = Color.Snow;
            btnGetStarted.ImageAlign = ContentAlignment.MiddleLeft;
            btnGetStarted.Location = new Point(320, 342);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(90, 23);
            btnGetStarted.TabIndex = 18;
            btnGetStarted.Text = "Comencemos";
            btnGetStarted.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(380, 187);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 17;
            // 
            // txtNumeroDeCursos
            // 
            txtNumeroDeCursos.BackColor = Color.Snow;
            txtNumeroDeCursos.Cursor = Cursors.IBeam;
            txtNumeroDeCursos.Location = new Point(251, 342);
            txtNumeroDeCursos.Name = "txtNumeroDeCursos";
            txtNumeroDeCursos.Size = new Size(63, 23);
            txtNumeroDeCursos.TabIndex = 16;
            txtNumeroDeCursos.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHeaderF1
            // 
            lblHeaderF1.AutoSize = true;
            lblHeaderF1.BackColor = Color.Transparent;
            lblHeaderF1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderF1.ForeColor = SystemColors.ControlLight;
            lblHeaderF1.Location = new Point(67, 202);
            lblHeaderF1.Name = "lblHeaderF1";
            lblHeaderF1.Size = new Size(402, 30);
            lblHeaderF1.TabIndex = 15;
            lblHeaderF1.Text = "Comencemos agregando algunos cursos";
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = Color.Transparent;
            ptbLogo.BackgroundImage = Properties.Resources.logolearnifyV2;
            ptbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            ptbLogo.Location = new Point(193, 62);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(156, 112);
            ptbLogo.TabIndex = 14;
            ptbLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_winForm_DSA_utepsa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 433);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose1);
            Controls.Add(ptbBook);
            Controls.Add(lblRegisterCourse);
            Controls.Add(lblToAdd);
            Controls.Add(lblHowMany);
            Controls.Add(lblSubheaderF1);
            Controls.Add(btnGetStarted);
            Controls.Add(label2);
            Controls.Add(txtNumeroDeCursos);
            Controls.Add(lblHeaderF1);
            Controls.Add(ptbLogo);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptbBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimize;
        private Button btnClose1;
        private PictureBox ptbBook;
        private Label lblRegisterCourse;
        private Label lblToAdd;
        private Label lblHowMany;
        private Label lblSubheaderF1;
        private Button btnGetStarted;
        private Label label2;
        private TextBox txtNumeroDeCursos;
        private Label lblHeaderF1;
        private PictureBox ptbLogo;
    }
}