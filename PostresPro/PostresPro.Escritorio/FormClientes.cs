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

        private int? clienteSeleccionadoId = null;

        public FormClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;

            dgvClientes.DataSource = servicio.Listar()
                .Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Telefono,
                    c.Correo,
                    Estado = c.Activo ? "Activo" : "Inactivo"
                })
                .ToList();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);

            Cliente? cliente = servicio.Buscar(id);

            if (cliente == null)
                return;

            clienteSeleccionadoId = cliente.Id;

            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            cmbEstado.Text = cliente.Activo ? "Activo" : "Inactivo";
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
            cmbEstado.SelectedIndex = -1;
            clienteSeleccionadoId = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Escriba algún dato para buscar un cliente.");
                return;
            }

            var clientes = servicio.Listar();

            var resultados = clientes.Where(c =>
                (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                 c.Nombre.Contains(txtNombre.Text.Trim(), StringComparison.OrdinalIgnoreCase)) &&

                (string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                 c.Telefono.Contains(txtTelefono.Text.Trim())) &&

                (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                 c.Correo.Contains(txtCorreo.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            ).ToList();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = resultados;

            clienteSeleccionadoId = null;

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes con esos datos.");
                return;
            }

            if (resultados.Count > 1)
            {
                MessageBox.Show("Se encontraron varios clientes. Seleccione uno de la tabla.");
                return;
            }

            Cliente cliente = resultados[0];

            clienteSeleccionadoId = cliente.Id;

            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            cmbEstado.Text = cliente.Activo ? "Activo" : "Inactivo";

            MessageBox.Show("Cliente encontrado correctamente.");
        }




        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == null)
            {
                MessageBox.Show("Primero busque y seleccione un cliente para modificar.");
                return;
            }

            Cliente cliente = new Cliente
            {
                Id = clienteSeleccionadoId.Value,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Activo = cmbEstado.SelectedItem?.ToString() == "Activo"
            };

            string? resultado = servicio.Actualizar(cliente);

            if (resultado != null)
            {
                MessageBox.Show(resultado);
                return;
            }

            MessageBox.Show("Cliente modificado correctamente.");

            clienteSeleccionadoId = null;

            CargarClientes();

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == null)
            {
                MessageBox.Show("Primero busque y seleccione un cliente para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
                return;

            string? resultado = servicio.Eliminar(clienteSeleccionadoId.Value);

            if (resultado != null)
            {
                MessageBox.Show(resultado);
                return;
            }

            MessageBox.Show("Cliente eliminado correctamente.");

            clienteSeleccionadoId = null;

            CargarClientes();

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbEstado.SelectedIndex = -1;
        }
    }
}