using System;
using System.Linq;
using System.Windows.Forms;
using PostresPro.Modelos;
using PostresPro.Servicios;

namespace PostresPro.Escritorio
{
    public partial class FormPedidos : Form
    {
        private ClienteServicio servicioClientes = new ClienteServicio();
        private PedidoServicio servicioPedidos = new PedidoServicio();

        private int pedidoSeleccionado = 0;

        public FormPedidos()
        {
            InitializeComponent();

            CargarClientes();
            CargarEstados();
            ConfigurarTabla();
            CargarPedidos();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click += btnGuardar_Click;

            btnActualizar.Click -= btnActualizar_Click;
            btnActualizar.Click += btnActualizar_Click;

            btnEliminar.Click -= btnEliminar_Click;
            btnEliminar.Click += btnEliminar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            dgvPedidos.CellClick -= dgvPedidos_CellClick;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
        }

        private void CargarClientes()
        {
            var clientes = servicioClientes.Listar()
                .Where(c => c.Activo)
                .ToList();

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En preparación");
            cmbEstado.Items.Add("Entregado");

            cmbEstado.SelectedIndex = 0;
        }

        private void ConfigurarTabla()
        {
            dgvPedidos.ReadOnly = true;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarPedidos()
        {
            var pedidos = servicioPedidos.Listar();
            var clientes = servicioClientes.Listar();

            var datos = pedidos.Select(p => new
            {
                p.Id,
                Cliente = clientes
                    .FirstOrDefault(c => c.Id == p.ClienteId)?.Nombre
                    ?? "Cliente no disponible",
                p.NombrePostre,
                p.Cantidad,
                p.PrecioUnitario,
                p.Fecha,
                p.Estado,
                p.Total
            }).ToList();

            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = datos;

            dgvPedidos.Columns["Id"].HeaderText = "Código";
            dgvPedidos.Columns["Cliente"].HeaderText = "Cliente";
            dgvPedidos.Columns["NombrePostre"].HeaderText = "Postre";
            dgvPedidos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvPedidos.Columns["PrecioUnitario"].HeaderText =
                "Precio unitario";
            dgvPedidos.Columns["Fecha"].HeaderText = "Fecha";
            dgvPedidos.Columns["Estado"].HeaderText = "Estado";
            dgvPedidos.Columns["Total"].HeaderText = "Total";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            Pedido pedido = new Pedido
            {
                ClienteId = Convert.ToInt32(cmbCliente.SelectedValue),
                NombrePostre = txtNombrePostre.Text.Trim(),
                Cantidad = (int)nudCantidad.Value,
                PrecioUnitario = nudPrecio.Value,
                Fecha = dtpFecha.Value,
                Estado = cmbEstado.Text
            };

            string? error = servicioPedidos.Agregar(pedido);

            if (error != null)
            {
                MessageBox.Show(error, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Pedido guardado correctamente.");

            CargarPedidos();
            LimpiarCampos();
        }

        private void dgvPedidos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            pedidoSeleccionado = Convert.ToInt32(
                dgvPedidos.Rows[e.RowIndex].Cells["Id"].Value);

            Pedido? pedido = servicioPedidos.Buscar(pedidoSeleccionado);

            if (pedido == null)
                return;

            cmbCliente.SelectedValue = pedido.ClienteId;
            txtNombrePostre.Text = pedido.NombrePostre;
            nudCantidad.Value = pedido.Cantidad;
            nudPrecio.Value = pedido.PrecioUnitario;
            dtpFecha.Value = pedido.Fecha;

            cmbEstado.SelectedItem = pedido.Estado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un pedido de la tabla.");
                return;
            }

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            Pedido? pedido = servicioPedidos.Buscar(pedidoSeleccionado);

            if (pedido == null)
            {
                MessageBox.Show("No se encontró el pedido.");
                return;
            }

            pedido.ClienteId = Convert.ToInt32(cmbCliente.SelectedValue);
            pedido.NombrePostre = txtNombrePostre.Text.Trim();
            pedido.Cantidad = (int)nudCantidad.Value;
            pedido.PrecioUnitario = nudPrecio.Value;
            pedido.Fecha = dtpFecha.Value;
            pedido.Estado = cmbEstado.Text;

            string? error = servicioPedidos.Actualizar(pedido);

            if (error != null)
            {
                MessageBox.Show(error, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Pedido actualizado correctamente.");

            CargarPedidos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pedidoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un pedido de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este pedido?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                servicioPedidos.Eliminar(pedidoSeleccionado);

                MessageBox.Show("Pedido eliminado correctamente.");

                CargarPedidos();
                LimpiarCampos();
            }
        }

        // Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            pedidoSeleccionado = 0;

            cmbCliente.SelectedIndex = -1;
            txtNombrePostre.Clear();

            nudCantidad.Value = 1;
            nudPrecio.Value = 0;

            dtpFecha.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;

            dgvPedidos.ClearSelection();
        }
    }
}
