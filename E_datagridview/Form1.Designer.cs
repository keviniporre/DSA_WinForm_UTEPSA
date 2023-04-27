namespace E_datagridview
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
            dtgvProductos = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            InstructorColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            lblId = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            txtInstructor = new TextBox();
            lblInstructor = new Label();
            txtCategory = new TextBox();
            lblCategory = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            lblInformation = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dtgvProductos
            // 
            dtgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProductos.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, InstructorColumn, CategoryColumn, PriceColumn });
            dtgvProductos.Location = new Point(37, 200);
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowTemplate.Height = 25;
            dtgvProductos.Size = new Size(545, 226);
            dtgvProductos.TabIndex = 0;
            dtgvProductos.CellClick += dtgvProductos_CellClick;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // InstructorColumn
            // 
            InstructorColumn.HeaderText = "Instructor";
            InstructorColumn.Name = "InstructorColumn";
            // 
            // CategoryColumn
            // 
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.Name = "CategoryColumn";
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(37, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(104, 89);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(100, 23);
            txtInstructor.TabIndex = 6;
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Location = new Point(37, 92);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(61, 15);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(104, 118);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(37, 121);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(104, 147);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(37, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(246, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(246, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Location = new Point(246, 155);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(16, 15);
            lblInformation.TabIndex = 13;
            lblInformation.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 462);
            Controls.Add(lblInformation);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtInstructor);
            Controls.Add(lblInstructor);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dtgvProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvProductos;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn InstructorColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtInstructor;
        private Label lblInstructor;
        private TextBox txtCategory;
        private Label lblCategory;
        private TextBox txtPrice;
        private Label lblPrice;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblInformation;
    }
}