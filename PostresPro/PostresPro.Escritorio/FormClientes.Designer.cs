namespace PostresPro.Escritorio
{
    partial class FormClientes
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(431, 31);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono: ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(525, 28);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 31);
            txtTelefono.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(22, 82);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(115, 82);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(267, 31);
            txtCorreo.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrar.Location = new Point(38, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(224, 224, 224);
            btnBuscar.Location = new Point(222, 162);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(224, 224, 224);
            btnModificar.Location = new Point(407, 162);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(616, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(38, 277);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(772, 225);
            dgvClientes.TabIndex = 10;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
    }
}