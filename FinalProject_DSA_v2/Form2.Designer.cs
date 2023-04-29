namespace FinalProject_DSA_v2
{
    partial class Form2
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
            lblId = new Label();
            lblName = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblInstructor = new Label();
            txtInstructor = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblLength = new Label();
            txtLength = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            pictureBox1 = new PictureBox();
            btnAddToLibrary = new Button();
            lblHeaderF2 = new Label();
            label1 = new Label();
            label2 = new Label();
            dtgvAll = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            nameCol = new DataGridViewTextBoxColumn();
            instructorCol = new DataGridViewTextBoxColumn();
            categoryCol = new DataGridViewTextBoxColumn();
            lengthCol = new DataGridViewTextBoxColumn();
            priceCol = new DataGridViewTextBoxColumn();
            dtgvFiltered = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            lblFiltered = new Label();
            btnDeleteFromLibrary = new Button();
            btnEmptyLibrary = new Button();
            btnSearch = new Button();
            btnClearSearch = new Button();
            lblLibrary = new Label();
            btnMinimizeF2 = new Button();
            btnClose1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFiltered).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.ForeColor = SystemColors.MenuBar;
            lblId.Location = new Point(288, 136);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = SystemColors.MenuBar;
            lblName.Location = new Point(377, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(315, 133);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 2;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // txtName
            // 
            txtName.Location = new Point(425, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 23);
            txtName.TabIndex = 3;
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.BackColor = Color.Transparent;
            lblInstructor.ForeColor = SystemColors.MenuBar;
            lblInstructor.Location = new Point(288, 165);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(61, 15);
            lblInstructor.TabIndex = 4;
            lblInstructor.Text = "Instructor:";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(355, 162);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(151, 23);
            txtInstructor.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = SystemColors.MenuBar;
            lblCategory.Location = new Point(512, 168);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(576, 165);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(101, 23);
            txtCategory.TabIndex = 7;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.BackColor = Color.Transparent;
            lblLength.ForeColor = SystemColors.MenuBar;
            lblLength.Location = new Point(288, 194);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(47, 15);
            lblLength.TabIndex = 8;
            lblLength.Text = "Length:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(341, 191);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(78, 23);
            txtLength.TabIndex = 9;
            txtLength.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(467, 191);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(77, 23);
            txtPrice.TabIndex = 11;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.ForeColor = SystemColors.MenuBar;
            lblPrice.Location = new Point(425, 194);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logolearnifyV2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(57, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 156);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnAddToLibrary
            // 
            btnAddToLibrary.BackColor = Color.DarkSlateBlue;
            btnAddToLibrary.Cursor = Cursors.Hand;
            btnAddToLibrary.FlatAppearance.BorderSize = 0;
            btnAddToLibrary.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnAddToLibrary.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnAddToLibrary.FlatStyle = FlatStyle.Flat;
            btnAddToLibrary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToLibrary.ForeColor = Color.Snow;
            btnAddToLibrary.Location = new Point(576, 191);
            btnAddToLibrary.Name = "btnAddToLibrary";
            btnAddToLibrary.Size = new Size(101, 23);
            btnAddToLibrary.TabIndex = 13;
            btnAddToLibrary.Text = "Add to Library";
            btnAddToLibrary.UseVisualStyleBackColor = false;
            btnAddToLibrary.MouseLeave += btnAddToLibrary_MouseLeave;
            btnAddToLibrary.MouseHover += btnAddToLibrary_MouseHover;
            // 
            // lblHeaderF2
            // 
            lblHeaderF2.AutoSize = true;
            lblHeaderF2.BackColor = Color.Transparent;
            lblHeaderF2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderF2.ForeColor = SystemColors.MenuBar;
            lblHeaderF2.Location = new Point(288, 40);
            lblHeaderF2.Name = "lblHeaderF2";
            lblHeaderF2.Size = new Size(318, 30);
            lblHeaderF2.TabIndex = 14;
            lblHeaderF2.Text = "Let's start Adding some courses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuBar;
            label1.Location = new Point(288, 79);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 15;
            label1.Text = "Register some new courses.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(288, 94);
            label2.Name = "label2";
            label2.Size = new Size(263, 15);
            label2.TabIndex = 16;
            label2.Text = "Adding new courses will make your library grow!";
            // 
            // dtgvAll
            // 
            dtgvAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAll.BackgroundColor = Color.Snow;
            dtgvAll.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAll.Columns.AddRange(new DataGridViewColumn[] { IdCol, nameCol, instructorCol, categoryCol, lengthCol, priceCol });
            dtgvAll.Location = new Point(57, 269);
            dtgvAll.MinimumSize = new Size(40, 20);
            dtgvAll.Name = "dtgvAll";
            dtgvAll.RowTemplate.Height = 30;
            dtgvAll.Size = new Size(620, 225);
            dtgvAll.TabIndex = 17;
            // 
            // IdCol
            // 
            IdCol.FillWeight = 40F;
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.Resizable = DataGridViewTriState.True;
            // 
            // nameCol
            // 
            nameCol.FillWeight = 89.5431442F;
            nameCol.HeaderText = "Name";
            nameCol.Name = "nameCol";
            // 
            // instructorCol
            // 
            instructorCol.FillWeight = 89.5431442F;
            instructorCol.HeaderText = "Instructor";
            instructorCol.Name = "instructorCol";
            // 
            // categoryCol
            // 
            categoryCol.FillWeight = 89.5431442F;
            categoryCol.HeaderText = "Category";
            categoryCol.Name = "categoryCol";
            // 
            // lengthCol
            // 
            lengthCol.FillWeight = 50F;
            lengthCol.HeaderText = "Length";
            lengthCol.Name = "lengthCol";
            // 
            // priceCol
            // 
            priceCol.FillWeight = 50F;
            priceCol.HeaderText = "Price";
            priceCol.Name = "priceCol";
            // 
            // dtgvFiltered
            // 
            dtgvFiltered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFiltered.BackgroundColor = Color.Snow;
            dtgvFiltered.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvFiltered.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFiltered.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvFiltered.Location = new Point(57, 515);
            dtgvFiltered.MinimumSize = new Size(40, 20);
            dtgvFiltered.Name = "dtgvFiltered";
            dtgvFiltered.RowTemplate.Height = 30;
            dtgvFiltered.Size = new Size(620, 53);
            dtgvFiltered.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 40F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 89.5431442F;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 89.5431442F;
            dataGridViewTextBoxColumn3.HeaderText = "Instructor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 89.5431442F;
            dataGridViewTextBoxColumn4.HeaderText = "Category";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 50F;
            dataGridViewTextBoxColumn5.HeaderText = "Length";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 50F;
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lblFiltered
            // 
            lblFiltered.AutoSize = true;
            lblFiltered.BackColor = Color.Transparent;
            lblFiltered.ForeColor = SystemColors.MenuBar;
            lblFiltered.Location = new Point(57, 497);
            lblFiltered.Name = "lblFiltered";
            lblFiltered.Size = new Size(80, 15);
            lblFiltered.TabIndex = 19;
            lblFiltered.Text = "Search Result:";
            // 
            // btnDeleteFromLibrary
            // 
            btnDeleteFromLibrary.BackColor = Color.DarkSlateBlue;
            btnDeleteFromLibrary.Cursor = Cursors.Hand;
            btnDeleteFromLibrary.FlatAppearance.BorderSize = 0;
            btnDeleteFromLibrary.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnDeleteFromLibrary.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnDeleteFromLibrary.FlatStyle = FlatStyle.Flat;
            btnDeleteFromLibrary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFromLibrary.ForeColor = Color.Snow;
            btnDeleteFromLibrary.Location = new Point(551, 220);
            btnDeleteFromLibrary.Name = "btnDeleteFromLibrary";
            btnDeleteFromLibrary.Size = new Size(126, 23);
            btnDeleteFromLibrary.TabIndex = 20;
            btnDeleteFromLibrary.Text = "Delete from Library";
            btnDeleteFromLibrary.UseVisualStyleBackColor = false;
            btnDeleteFromLibrary.Click += btnDeleteFromLibrary_Click;
            btnDeleteFromLibrary.MouseLeave += btnDeleteFromLibrary_MouseLeave;
            btnDeleteFromLibrary.MouseHover += btnDeleteFromLibrary_MouseHover;
            // 
            // btnEmptyLibrary
            // 
            btnEmptyLibrary.BackColor = Color.DarkSlateBlue;
            btnEmptyLibrary.Cursor = Cursors.Hand;
            btnEmptyLibrary.FlatAppearance.BorderSize = 0;
            btnEmptyLibrary.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnEmptyLibrary.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnEmptyLibrary.FlatStyle = FlatStyle.Flat;
            btnEmptyLibrary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmptyLibrary.ForeColor = Color.Snow;
            btnEmptyLibrary.Location = new Point(443, 220);
            btnEmptyLibrary.Name = "btnEmptyLibrary";
            btnEmptyLibrary.Size = new Size(101, 23);
            btnEmptyLibrary.TabIndex = 21;
            btnEmptyLibrary.Text = "Empty Library";
            btnEmptyLibrary.UseVisualStyleBackColor = false;
            btnEmptyLibrary.MouseLeave += btnEmptyLibrary_MouseLeave;
            btnEmptyLibrary.MouseHover += btnEmptyLibrary_MouseHover;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Snow;
            btnSearch.Location = new Point(53, 220);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 23);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search Course";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.MouseLeave += btnSearch_MouseLeave;
            btnSearch.MouseHover += btnSearch_MouseHover;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.DarkSlateBlue;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearSearch.ForeColor = Color.Snow;
            btnClearSearch.Location = new Point(160, 220);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(90, 23);
            btnClearSearch.TabIndex = 23;
            btnClearSearch.Text = "Clear Search";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.MouseLeave += btnClearSearch_MouseLeave;
            btnClearSearch.MouseHover += btnClearSearch_MouseHover;
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.BackColor = Color.Transparent;
            lblLibrary.ForeColor = SystemColors.MenuBar;
            lblLibrary.Location = new Point(57, 251);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(46, 15);
            lblLibrary.TabIndex = 24;
            lblLibrary.Text = "Library:";
            // 
            // btnMinimizeF2
            // 
            btnMinimizeF2.BackColor = Color.Transparent;
            btnMinimizeF2.Cursor = Cursors.Hand;
            btnMinimizeF2.FlatAppearance.BorderSize = 0;
            btnMinimizeF2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimizeF2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimizeF2.FlatStyle = FlatStyle.Flat;
            btnMinimizeF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimizeF2.ForeColor = Color.Snow;
            btnMinimizeF2.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimizeF2.Location = new Point(661, 10);
            btnMinimizeF2.Name = "btnMinimizeF2";
            btnMinimizeF2.Size = new Size(28, 23);
            btnMinimizeF2.TabIndex = 25;
            btnMinimizeF2.Text = "__";
            btnMinimizeF2.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMinimizeF2.UseVisualStyleBackColor = false;
            btnMinimizeF2.Click += btnMinimizeF2_Click;
            btnMinimizeF2.MouseLeave += btnMinimizeF2_MouseLeave;
            btnMinimizeF2.MouseHover += btnMinimizeF2_MouseHover;
            // 
            // btnClose1
            // 
            btnClose1.BackColor = Color.Transparent;
            btnClose1.Cursor = Cursors.Hand;
            btnClose1.FlatAppearance.BorderSize = 0;
            btnClose1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose1.FlatStyle = FlatStyle.Flat;
            btnClose1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose1.ForeColor = Color.Snow;
            btnClose1.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose1.Location = new Point(692, 7);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(24, 27);
            btnClose1.TabIndex = 26;
            btnClose1.Text = "x";
            btnClose1.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose1.UseVisualStyleBackColor = false;
            btnClose1.Click += btnClose1_Click;
            btnClose1.MouseLeave += btnClose1_MouseLeave;
            btnClose1.MouseHover += btnClose1_MouseHover;
            // 
            // Form2
            // 
            AcceptButton = btnAddToLibrary;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            BackgroundImage = Properties.Resources.DSA_portrait_back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 607);
            Controls.Add(btnClose1);
            Controls.Add(btnMinimizeF2);
            Controls.Add(lblLibrary);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnEmptyLibrary);
            Controls.Add(btnDeleteFromLibrary);
            Controls.Add(lblFiltered);
            Controls.Add(dtgvFiltered);
            Controls.Add(dtgvAll);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHeaderF2);
            Controls.Add(btnAddToLibrary);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtLength);
            Controls.Add(lblLength);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtInstructor);
            Controls.Add(lblInstructor);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(lblId);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learnify";
            TransparencyKey = Color.FromArgb(10, 10, 10);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFiltered).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblInstructor;
        private TextBox txtInstructor;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblLength;
        private TextBox txtLength;
        private TextBox txtPrice;
        private Label lblPrice;
        private PictureBox pictureBox1;
        private Button btnAddToLibrary;
        private Label lblHeaderF2;
        private Label label1;
        private Label label2;
        private DataGridView dtgvAll;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn instructorCol;
        private DataGridViewTextBoxColumn categoryCol;
        private DataGridViewTextBoxColumn lengthCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridView dtgvFiltered;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblFiltered;
        private Button btnDeleteFromLibrary;
        private Button btnEmptyLibrary;
        private Button btnSearch;
        private Button btnClearSearch;
        private Label lblLibrary;
        private Button btnMinimizeF2;
        private Button btnClose1;
    }
}