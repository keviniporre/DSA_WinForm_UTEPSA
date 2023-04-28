namespace FinalProject_DSA_UTEPSA_v1
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
            lblTitle = new Label();
            lblId = new Label();
            lblName = new Label();
            lblInstructor = new Label();
            lblCategory = new Label();
            lblLength = new Label();
            lblPrice = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtInstructor = new TextBox();
            txtCategory = new TextBox();
            txtLength = new TextBox();
            txtPrice = new TextBox();
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
            lblDtgvAll = new Label();
            lblDtgvFiltered = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEmpty = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            lblMaxLength = new Label();
            txtRegister = new TextBox();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFiltered).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(191, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Learnify Online Courses";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 109);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(46, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Location = new Point(46, 167);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(61, 15);
            lblInstructor.TabIndex = 3;
            lblInstructor.Text = "Instructor:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(276, 112);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(276, 141);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(47, 15);
            lblLength.TabIndex = 5;
            lblLength.Text = "Length:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(276, 170);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 106);
            txtId.Name = "txtId";
            txtId.Size = new Size(113, 23);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(113, 23);
            txtName.TabIndex = 8;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(115, 164);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(113, 23);
            txtInstructor.TabIndex = 9;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(345, 109);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(113, 23);
            txtCategory.TabIndex = 10;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(345, 138);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(113, 23);
            txtLength.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(345, 167);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(113, 23);
            txtPrice.TabIndex = 12;
            // 
            // dtgvAll
            // 
            dtgvAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAll.Columns.AddRange(new DataGridViewColumn[] { IdCol, nameCol, instructorCol, categoryCol, lengthCol, priceCol });
            dtgvAll.Location = new Point(29, 275);
            dtgvAll.Name = "dtgvAll";
            dtgvAll.RowTemplate.Height = 25;
            dtgvAll.Size = new Size(440, 200);
            dtgvAll.TabIndex = 13;
            dtgvAll.CellClick += dtgvAll_CellClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.Width = 43;
            // 
            // nameCol
            // 
            nameCol.HeaderText = "Name";
            nameCol.Name = "nameCol";
            nameCol.Width = 64;
            // 
            // instructorCol
            // 
            instructorCol.HeaderText = "Instructor";
            instructorCol.Name = "instructorCol";
            instructorCol.Width = 83;
            // 
            // categoryCol
            // 
            categoryCol.HeaderText = "Category";
            categoryCol.Name = "categoryCol";
            categoryCol.Width = 80;
            // 
            // lengthCol
            // 
            lengthCol.HeaderText = "Length";
            lengthCol.Name = "lengthCol";
            lengthCol.Width = 69;
            // 
            // priceCol
            // 
            priceCol.HeaderText = "Price";
            priceCol.Name = "priceCol";
            priceCol.Width = 58;
            // 
            // dtgvFiltered
            // 
            dtgvFiltered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgvFiltered.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFiltered.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvFiltered.Location = new Point(29, 496);
            dtgvFiltered.Name = "dtgvFiltered";
            dtgvFiltered.RowTemplate.Height = 25;
            dtgvFiltered.Size = new Size(440, 109);
            dtgvFiltered.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Instructor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Category";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Length";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 58;
            // 
            // lblDtgvAll
            // 
            lblDtgvAll.AutoSize = true;
            lblDtgvAll.Location = new Point(29, 257);
            lblDtgvAll.Name = "lblDtgvAll";
            lblDtgvAll.Size = new Size(66, 15);
            lblDtgvAll.TabIndex = 15;
            lblDtgvAll.Text = "Queue List:";
            // 
            // lblDtgvFiltered
            // 
            lblDtgvFiltered.AutoSize = true;
            lblDtgvFiltered.Location = new Point(29, 478);
            lblDtgvFiltered.Name = "lblDtgvFiltered";
            lblDtgvFiltered.Size = new Size(70, 15);
            lblDtgvFiltered.TabIndex = 16;
            lblDtgvFiltered.Text = "Filtered List:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(46, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(127, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEmpty
            // 
            btnEmpty.Location = new Point(208, 217);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(75, 23);
            btnEmpty.TabIndex = 19;
            btnEmpty.Text = "Empty";
            btnEmpty.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(394, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(394, 246);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblMaxLength
            // 
            lblMaxLength.AutoSize = true;
            lblMaxLength.Location = new Point(12, 20);
            lblMaxLength.Name = "lblMaxLength";
            lblMaxLength.Size = new Size(159, 15);
            lblMaxLength.TabIndex = 22;
            lblMaxLength.Text = "Number of Items to Register:";
            // 
            // txtRegister
            // 
            txtRegister.Location = new Point(177, 17);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(51, 23);
            txtRegister.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(237, 16);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 629);
            Controls.Add(btnRegister);
            Controls.Add(txtRegister);
            Controls.Add(lblMaxLength);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnEmpty);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblDtgvFiltered);
            Controls.Add(lblDtgvAll);
            Controls.Add(dtgvFiltered);
            Controls.Add(dtgvAll);
            Controls.Add(txtPrice);
            Controls.Add(txtLength);
            Controls.Add(txtCategory);
            Controls.Add(txtInstructor);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblPrice);
            Controls.Add(lblLength);
            Controls.Add(lblCategory);
            Controls.Add(lblInstructor);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "LEARNIFY ";
            ((System.ComponentModel.ISupportInitialize)dtgvAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvFiltered).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblId;
        private Label lblName;
        private Label lblInstructor;
        private Label lblCategory;
        private Label lblLength;
        private Label lblPrice;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtInstructor;
        private TextBox txtCategory;
        private TextBox txtLength;
        private TextBox txtPrice;
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
        private Label lblDtgvAll;
        private Label lblDtgvFiltered;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEmpty;
        private Button btnClear;
        private Button btnSearch;
        private Label lblMaxLength;
        private TextBox txtRegister;
        private Button btnRegister;
    }
}