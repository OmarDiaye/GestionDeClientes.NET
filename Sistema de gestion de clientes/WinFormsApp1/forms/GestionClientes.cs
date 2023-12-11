using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.dao;
using WinFormsApp1.modelos;


namespace WinFormsApp1
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }
        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerListadoDeClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;

            if (lblId.Text != " ")
            {
                cliente.Id = lblId.Text;
            }


            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarListado();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTarjetaDeCredito_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtApellido.Text = cliente.Apellido;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaDeCredito.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarListado(); 

        }


        private void limpiarListado() {
            lblId.Text = " ";
            txtApellido.Text = " ";
            txtNombre.Text = " ";
            txtTelefono.Text = " ";
            txtTarjetaDeCredito.Text = "  ";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 