namespace Learnify_Spanish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnCerrarF2 = new Button();
            btnMinimizarF2 = new Button();
            lblLibrary = new Label();
            btnLimpiarBusqueda = new Button();
            btnBuscar = new Button();
            btnVaciarLibreria = new Button();
            btnEliminarDeLibreria = new Button();
            lblFiltered = new Label();
            dtgvBusqueda = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dtgvLibreria = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            nameCol = new DataGridViewTextBoxColumn();
            instructorCol = new DataGridViewTextBoxColumn();
            categoryCol = new DataGridViewTextBoxColumn();
            lengthCol = new DataGridViewTextBoxColumn();
            priceCol = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegisterCourses = new Label();
            lblHeaderF2 = new Label();
            btnAgregarEnLibreria = new Button();
            pictureBox1 = new PictureBox();
            txtPrecio = new TextBox();
            lblPrice = new Label();
            txtDuracion = new TextBox();
            lblLength = new Label();
            txtCategoria = new TextBox();
            lblCategory = new Label();
            txtInstructor = new TextBox();
            lblInstructor = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblName = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLibreria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarF2
            // 
            btnCerrarF2.BackColor = Color.Transparent;
            btnCerrarF2.Cursor = Cursors.Hand;
            btnCerrarF2.FlatAppearance.BorderSize = 0;
            btnCerrarF2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrarF2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCerrarF2.FlatStyle = FlatStyle.Flat;
            btnCerrarF2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarF2.ForeColor = Color.Snow;
            btnCerrarF2.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarF2.Location = new Point(696, 6);
            btnCerrarF2.Name = "btnCerrarF2";
            btnCerrarF2.Size = new Size(24, 27);
            btnCerrarF2.TabIndex = 53;
            btnCerrarF2.Text = "x";
            btnCerrarF2.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCerrarF2.UseVisualStyleBackColor = false;
            btnCerrarF2.Click += btnCerrarF2_Click;
            // 
            // btnMinimizarF2
            // 
            btnMinimizarF2.BackColor = Color.Transparent;
            btnMinimizarF2.Cursor = Cursors.Hand;
            btnMinimizarF2.FlatAppearance.BorderSize = 0;
            btnMinimizarF2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimizarF2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimizarF2.FlatStyle = FlatStyle.Flat;
            btnMinimizarF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimizarF2.ForeColor = Color.Snow;
            btnMinimizarF2.ImageAlign = ContentAlignment.MiddleLeft;
            btnMinimizarF2.Location = new Point(665, 9);
            btnMinimizarF2.Name = "btnMinimizarF2";
            btnMinimizarF2.Size = new Size(28, 23);
            btnMinimizarF2.TabIndex = 52;
            btnMinimizarF2.Text = "__";
            btnMinimizarF2.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMinimizarF2.UseVisualStyleBackColor = false;
            btnMinimizarF2.Click += btnMinimizarF2_Click;
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.BackColor = Color.Transparent;
            lblLibrary.ForeColor = SystemColors.MenuBar;
            lblLibrary.Location = new Point(61, 250);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(104, 15);
            lblLibrary.TabIndex = 51;
            lblLibrary.Text = "Libreria de Cursos:";
            // 
            // btnLimpiarBusqueda
            // 
            btnLimpiarBusqueda.BackColor = Color.DarkSlateBlue;
            btnLimpiarBusqueda.Cursor = Cursors.Hand;
            btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            btnLimpiarBusqueda.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnLimpiarBusqueda.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnLimpiarBusqueda.FlatStyle = FlatStyle.Flat;
            btnLimpiarBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarBusqueda.ForeColor = Color.Snow;
            btnLimpiarBusqueda.Location = new Point(197, 219);
            btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            btnLimpiarBusqueda.Size = new Size(116, 23);
            btnLimpiarBusqueda.TabIndex = 50;
            btnLimpiarBusqueda.Text = "Limpiar busqueda";
            btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            btnLimpiarBusqueda.Click += btnLimpiarBusqueda_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(57, 219);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 23);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "Buscar curso";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVaciarLibreria
            // 
            btnVaciarLibreria.BackColor = Color.DarkSlateBlue;
            btnVaciarLibreria.Cursor = Cursors.Hand;
            btnVaciarLibreria.FlatAppearance.BorderSize = 0;
            btnVaciarLibreria.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnVaciarLibreria.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnVaciarLibreria.FlatStyle = FlatStyle.Flat;
            btnVaciarLibreria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVaciarLibreria.ForeColor = Color.Snow;
            btnVaciarLibreria.Location = new Point(429, 219);
            btnVaciarLibreria.Name = "btnVaciarLibreria";
            btnVaciarLibreria.Size = new Size(119, 23);
            btnVaciarLibreria.TabIndex = 48;
            btnVaciarLibreria.Text = "Vaciar libreria";
            btnVaciarLibreria.UseVisualStyleBackColor = false;
            btnVaciarLibreria.Click += btnVaciarLibreria_Click;
            // 
            // btnEliminarDeLibreria
            // 
            btnEliminarDeLibreria.BackColor = Color.DarkSlateBlue;
            btnEliminarDeLibreria.Cursor = Cursors.Hand;
            btnEliminarDeLibreria.FlatAppearance.BorderSize = 0;
            btnEliminarDeLibreria.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnEliminarDeLibreria.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnEliminarDeLibreria.FlatStyle = FlatStyle.Flat;
            btnEliminarDeLibreria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarDeLibreria.ForeColor = Color.Snow;
            btnEliminarDeLibreria.Location = new Point(555, 219);
            btnEliminarDeLibreria.Name = "btnEliminarDeLibreria";
            btnEliminarDeLibreria.Size = new Size(126, 23);
            btnEliminarDeLibreria.TabIndex = 47;
            btnEliminarDeLibreria.Text = "Eliminar de libreria";
            btnEliminarDeLibreria.UseVisualStyleBackColor = false;
            btnEliminarDeLibreria.Click += btnEliminarDeLibreria_Click;
            // 
            // lblFiltered
            // 
            lblFiltered.AutoSize = true;
            lblFiltered.BackColor = Color.Transparent;
            lblFiltered.ForeColor = SystemColors.MenuBar;
            lblFiltered.Location = new Point(61, 531);
            lblFiltered.Name = "lblFiltered";
            lblFiltered.Size = new Size(133, 15);
            lblFiltered.TabIndex = 46;
            lblFiltered.Text = "Resultado de busqueda:";
            // 
            // dtgvBusqueda
            // 
            dtgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBusqueda.BackgroundColor = Color.Snow;
            dtgvBusqueda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBusqueda.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvBusqueda.Location = new Point(61, 549);
            dtgvBusqueda.MinimumSize = new Size(40, 20);
            dtgvBusqueda.Name = "dtgvBusqueda";
            dtgvBusqueda.RowTemplate.Height = 30;
            dtgvBusqueda.Size = new Size(620, 53);
            dtgvBusqueda.TabIndex = 45;
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
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
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
            dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 50F;
            dataGridViewTextBoxColumn5.HeaderText = "Duracion";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 50F;
            dataGridViewTextBoxColumn6.HeaderText = "Precio";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dtgvLibreria
            // 
            dtgvLibreria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLibreria.BackgroundColor = Color.Snow;
            dtgvLibreria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvLibreria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLibreria.Columns.AddRange(new DataGridViewColumn[] { IdCol, nameCol, instructorCol, categoryCol, lengthCol, priceCol });
            dtgvLibreria.Location = new Point(61, 268);
            dtgvLibreria.MinimumSize = new Size(40, 20);
            dtgvLibreria.Name = "dtgvLibreria";
            dtgvLibreria.RowTemplate.Height = 30;
            dtgvLibreria.Size = new Size(620, 260);
            dtgvLibreria.TabIndex = 44;
            dtgvLibreria.CellClick += dtgvLibreria_CellClick;
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
            nameCol.HeaderText = "Nombre";
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
            categoryCol.HeaderText = "Categoria";
            categoryCol.Name = "categoryCol";
            // 
            // lengthCol
            // 
            lengthCol.FillWeight = 50F;
            lengthCol.HeaderText = "Duracion";
            lengthCol.Name = "lengthCol";
            // 
            // priceCol
            // 
            priceCol.FillWeight = 50F;
            priceCol.HeaderText = "Precio";
            priceCol.Name = "priceCol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(292, 93);
            label2.Name = "label2";
            label2.Size = new Size(244, 15);
            label2.TabIndex = 43;
            label2.Text = "Agregar cursos nuevos hace crecer la libreria.";
            // 
            // lblRegisterCourses
            // 
            lblRegisterCourses.AutoSize = true;
            lblRegisterCourses.BackColor = Color.Transparent;
            lblRegisterCourses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterCourses.ForeColor = SystemColors.MenuBar;
            lblRegisterCourses.Location = new Point(292, 78);
            lblRegisterCourses.Name = "lblRegisterCourses";
            lblRegisterCourses.Size = new Size(195, 15);
            lblRegisterCourses.TabIndex = 42;
            lblRegisterCourses.Text = "Listo para registrar nuevos cursos.";
            // 
            // lblHeaderF2
            // 
            lblHeaderF2.AutoSize = true;
            lblHeaderF2.BackColor = Color.Transparent;
            lblHeaderF2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderF2.ForeColor = SystemColors.MenuBar;
            lblHeaderF2.Location = new Point(292, 39);
            lblHeaderF2.Name = "lblHeaderF2";
            lblHeaderF2.Size = new Size(402, 30);
            lblHeaderF2.TabIndex = 41;
            lblHeaderF2.Text = "Comencemos agregando algunos cursos";
            // 
            // btnAgregarEnLibreria
            // 
            btnAgregarEnLibreria.BackColor = Color.DarkSlateBlue;
            btnAgregarEnLibreria.Cursor = Cursors.Hand;
            btnAgregarEnLibreria.FlatAppearance.BorderSize = 0;
            btnAgregarEnLibreria.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnAgregarEnLibreria.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnAgregarEnLibreria.FlatStyle = FlatStyle.Flat;
            btnAgregarEnLibreria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEnLibreria.ForeColor = Color.Snow;
            btnAgregarEnLibreria.Location = new Point(555, 190);
            btnAgregarEnLibreria.Name = "btnAgregarEnLibreria";
            btnAgregarEnLibreria.Size = new Size(126, 23);
            btnAgregarEnLibreria.TabIndex = 40;
            btnAgregarEnLibreria.Text = "Agregar a libreria";
            btnAgregarEnLibreria.UseVisualStyleBackColor = false;
            btnAgregarEnLibreria.Click += btnAgregarEnLibreria_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logolearnifyV2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(61, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 156);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(471, 190);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(77, 23);
            txtPrecio.TabIndex = 38;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.ForeColor = SystemColors.MenuBar;
            lblPrice.Location = new Point(429, 193);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 15);
            lblPrice.TabIndex = 37;
            lblPrice.Text = "Precio:";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(349, 190);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(78, 23);
            txtDuracion.TabIndex = 36;
            txtDuracion.TextAlign = HorizontalAlignment.Right;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.BackColor = Color.Transparent;
            lblLength.ForeColor = SystemColors.MenuBar;
            lblLength.Location = new Point(292, 193);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(58, 15);
            lblLength.TabIndex = 35;
            lblLength.Text = "Duracion:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(580, 161);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(101, 23);
            txtCategoria.TabIndex = 34;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.ForeColor = SystemColors.MenuBar;
            lblCategory.Location = new Point(516, 164);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 15);
            lblCategory.TabIndex = 33;
            lblCategory.Text = "Categoria:";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(359, 161);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(151, 23);
            txtInstructor.TabIndex = 32;
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.BackColor = Color.Transparent;
            lblInstructor.ForeColor = SystemColors.MenuBar;
            lblInstructor.Location = new Point(292, 164);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(61, 15);
            lblInstructor.TabIndex = 31;
            lblInstructor.Text = "Instructor:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(429, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Location = new Point(319, 132);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 29;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = SystemColors.MenuBar;
            lblName.Location = new Point(376, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 28;
            lblName.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.ForeColor = SystemColors.MenuBar;
            lblId.Location = new Point(292, 135);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 27;
            lblId.Text = "ID:";
            // 
            // Form2
            // 
            AcceptButton = btnAgregarEnLibreria;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.login_winForm_DSA_utepsa;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCerrarF2;
            ClientSize = new Size(750, 641);
            Controls.Add(btnCerrarF2);
            Controls.Add(btnMinimizarF2);
            Controls.Add(lblLibrary);
            Controls.Add(btnLimpiarBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnVaciarLibreria);
            Controls.Add(btnEliminarDeLibreria);
            Controls.Add(lblFiltered);
            Controls.Add(dtgvBusqueda);
            Controls.Add(dtgvLibreria);
            Controls.Add(label2);
            Controls.Add(lblRegisterCourses);
            Controls.Add(lblHeaderF2);
            Controls.Add(btnAgregarEnLibreria);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrice);
            Controls.Add(txtDuracion);
            Controls.Add(lblLength);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategory);
            Controls.Add(txtInstructor);
            Controls.Add(lblInstructor);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(lblId);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learnify";
            TransparencyKey = Color.Black;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLibreria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarF2;
        private Button btnMinimizarF2;
        private Label lblLibrary;
        private Button btnLimpiarBusqueda;
        private Button btnBuscar;
        private Button btnVaciarLibreria;
        private Button btnEliminarDeLibreria;
        private Label lblFiltered;
        private DataGridView dtgvBusqueda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridView dtgvLibreria;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn instructorCol;
        private DataGridViewTextBoxColumn categoryCol;
        private DataGridViewTextBoxColumn lengthCol;
        private DataGridViewTextBoxColumn priceCol;
        private Label label2;
        private Label lblRegisterCourses;
        private Label lblHeaderF2;
        private Button btnAgregarEnLibreria;
        private PictureBox pictureBox1;
        private TextBox txtPrecio;
        private Label lblPrice;
        private TextBox txtDuracion;
        private Label lblLength;
        private TextBox txtCategoria;
        private Label lblCategory;
        private TextBox txtInstructor;
        private Label lblInstructor;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblName;
        private Label lblId;
    }
}