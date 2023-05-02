namespace FinalProject_DSA_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptbLogo = new PictureBox();
            lblHeaderF1 = new Label();
            txtNumberOfCourses = new TextBox();
            label2 = new Label();
            btnGetStarted = new Button();
            lblSubheaderF1 = new Label();
            lblHowMany = new Label();
            lblToAdd = new Label();
            lblRegisterCourse = new Label();
            ptbBook = new PictureBox();
            btnClose1 = new Button();
            btnMinimize = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBook).BeginInit();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = Color.Transparent;
            ptbLogo.BackgroundImage = Properties.Resources.logolearnifyV2;
            ptbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            ptbLogo.Location = new Point(233, 50);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(156, 112);
            ptbLogo.TabIndex = 1;
            ptbLogo.TabStop = false;
            // 
            // lblHeaderF1
            // 
            lblHeaderF1.AutoSize = true;
            lblHeaderF1.BackColor = Color.Transparent;
            lblHeaderF1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderF1.ForeColor = SystemColors.ControlLight;
            lblHeaderF1.Location = new Point(124, 204);
            lblHeaderF1.Name = "lblHeaderF1";
            lblHeaderF1.Size = new Size(402, 30);
            lblHeaderF1.TabIndex = 2;
            lblHeaderF1.Text = "Comencemos agregando algunos cursos";
            // 
            // txtNumberOfCourses
            // 
            txtNumberOfCourses.BackColor = Color.Snow;
            txtNumberOfCourses.Cursor = Cursors.IBeam;
            txtNumberOfCourses.Location = new Point(308, 344);
            txtNumberOfCourses.Name = "txtNumberOfCourses";
            txtNumberOfCourses.Size = new Size(63, 23);
            txtNumberOfCourses.TabIndex = 3;
            txtNumberOfCourses.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(437, 189);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
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
            btnGetStarted.Location = new Point(377, 344);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(90, 23);
            btnGetStarted.TabIndex = 5;
            btnGetStarted.Text = "Comencemos";
            btnGetStarted.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            btnGetStarted.MouseLeave += btnGetStarted_MouseLeave;
            btnGetStarted.MouseHover += btnGetStarted_MouseHover;
            // 
            // lblSubheaderF1
            // 
            lblSubheaderF1.AutoSize = true;
            lblSubheaderF1.BackColor = Color.Transparent;
            lblSubheaderF1.ForeColor = SystemColors.MenuBar;
            lblSubheaderF1.Location = new Point(250, 234);
            lblSubheaderF1.Name = "lblSubheaderF1";
            lblSubheaderF1.Size = new Size(134, 15);
            lblSubheaderF1.TabIndex = 7;
            lblSubheaderF1.Text = "Un poco cada dia suma.";
            // 
            // lblHowMany
            // 
            lblHowMany.AutoSize = true;
            lblHowMany.BackColor = Color.Transparent;
            lblHowMany.ForeColor = SystemColors.MenuBar;
            lblHowMany.Location = new Point(308, 311);
            lblHowMany.Name = "lblHowMany";
            lblHowMany.Size = new Size(146, 15);
            lblHowMany.TabIndex = 8;
            lblHowMany.Text = "Cuantos cursos te gustaria";
            // 
            // lblToAdd
            // 
            lblToAdd.AutoSize = true;
            lblToAdd.BackColor = Color.Transparent;
            lblToAdd.ForeColor = SystemColors.MenuBar;
            lblToAdd.Location = new Point(308, 326);
            lblToAdd.Name = "lblToAdd";
            lblToAdd.Size = new Size(94, 15);
            lblToAdd.TabIndex = 9;
            lblToAdd.Text = "agregar hoy dia?";
            // 
            // lblRegisterCourse
            // 
            lblRegisterCourse.AutoSize = true;
            lblRegisterCourse.BackColor = Color.Transparent;
            lblRegisterCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterCourse.ForeColor = SystemColors.MenuBar;
            lblRegisterCourse.Location = new Point(308, 296);
            lblRegisterCourse.Name = "lblRegisterCourse";
            lblRegisterCourse.Size = new Size(179, 15);
            lblRegisterCourse.TabIndex = 10;
            lblRegisterCourse.Text = "Registra algunos cursos nuevos";
            // 
            // ptbBook
            // 
            ptbBook.BackColor = Color.Transparent;
            ptbBook.BackgroundImage = Properties.Resources.bookLogo;
            ptbBook.BackgroundImageLayout = ImageLayout.Zoom;
            ptbBook.Location = new Point(149, 290);
            ptbBook.Name = "ptbBook";
            ptbBook.Size = new Size(120, 94);
            ptbBook.TabIndex = 11;
            ptbBook.TabStop = false;
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
            btnClose1.Location = new Point(590, 12);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(24, 23);
            btnClose1.TabIndex = 12;
            btnClose1.Text = "x";
            btnClose1.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose1.UseVisualStyleBackColor = false;
            btnClose1.Click += btnClose1_Click;
            btnClose1.MouseLeave += btnClose1_MouseLeave;
            btnClose1.MouseHover += btnClose1_MouseHover;
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
            btnMinimize.Location = new Point(565, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 23);
            btnMinimize.TabIndex = 13;
            btnMinimize.Text = "_";
            btnMinimize.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMini_Click;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            btnMinimize.MouseHover += btnMinimize_MouseHover;
            // 
            // Form1
            // 
            AcceptButton = btnGetStarted;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.DSA_portrait_back;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnClose1;
            ClientSize = new Size(638, 450);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose1);
            Controls.Add(ptbBook);
            Controls.Add(lblRegisterCourse);
            Controls.Add(lblToAdd);
            Controls.Add(lblHowMany);
            Controls.Add(lblSubheaderF1);
            Controls.Add(btnGetStarted);
            Controls.Add(label2);
            Controls.Add(txtNumberOfCourses);
            Controls.Add(lblHeaderF1);
            Controls.Add(ptbLogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learnify";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbLogo;
        private Label lblHeaderF1;
        private TextBox txtNumberOfCourses;
        private Label label2;
        private Button btnGetStarted;
        private Label lblSubheaderF1;
        private Label lblHowMany;
        private Label lblToAdd;
        private Label lblRegisterCourse;
        private PictureBox ptbBook;
        private Button btnClose1;
        private Button btnMinimize;
    }
}