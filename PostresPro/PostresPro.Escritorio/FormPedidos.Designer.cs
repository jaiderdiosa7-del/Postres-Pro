namespace PostresPro.Escritorio
{
    partial class FormPedidos
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
            label1 = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            txtNombrePostre = new TextBox();
            label3 = new Label();
            nudCantidad = new NumericUpDown();
            label4 = new Label();
            nudPrecio = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvPedidos = new DataGridView();
            label5 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 52);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(179, 49);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(161, 33);
            cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre del postre: ";
            // 
            // txtNombrePostre
            // 
            txtNombrePostre.Location = new Point(190, 137);
            txtNombrePostre.Name = "txtNombrePostre";
            txtNombrePostre.Size = new Size(150, 31);
            txtNombrePostre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 52);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Cantidad: ";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(518, 52);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(114, 31);
            nudCantidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 140);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 6;
            label4.Text = "Precio: ";
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(518, 138);
            nudPrecio.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(114, 31);
            nudPrecio.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(844, 140);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(122, 31);
            dtpFecha.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(669, 138);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(122, 33);
            cmbEstado.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Location = new Point(740, 523);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 42);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(320, 524);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 43);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(138, 523);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 43);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(546, 525);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 42);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(30, 191);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.Size = new Size(916, 290);
            dgvPedidos.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(669, 52);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 15;
            label5.Text = "Total del pedido: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(844, 54);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 25);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "$ 0";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(978, 594);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(dgvPedidos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(dtpFecha);
            Controls.Add(nudPrecio);
            Controls.Add(label4);
            Controls.Add(nudCantidad);
            Controls.Add(label3);
            Controls.Add(txtNombrePostre);
            Controls.Add(label2);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            Name = "FormPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postres Pro - Gestión de pedidos";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCliente;
        private Label label2;
        private TextBox txtNombrePostre;
        private Label label3;
        private NumericUpDown nudCantidad;
        private Label label4;
        private NumericUpDown nudPrecio;
        private DateTimePicker dtpFecha;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvPedidos;
        private Label label5;
        private Label lblTotal;
    }
}