using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PostresPro.Modelos;
using PostresPro.Servicios;

namespace PostresPro.Escritorio
{
    public partial class FormClientes : Form
    {
        private ClienteServicio servicio = new ClienteServicio();

        public FormClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = servicio.Listar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            string? resultado = servicio.Agregar(cliente);

            if (resultado != null)
            {
                MessageBox.Show(resultado);
                return;
            }

            MessageBox.Show("Cliente registrado correctamente.");

            CargarClientes();

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            Cliente? cliente = servicio.Buscar(id);

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            Cliente cliente = new Cliente
            {
                Id = id,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            string? resultado = servicio.Actualizar(cliente);

            if (resultado != null)
            {
                MessageBox.Show(resultado);
                return;
            }

            MessageBox.Show("Cliente modificado correctamente.");

            CargarClientes();

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }
    }
}