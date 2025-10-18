using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;

namespace ClubDeportivo.Forms
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(tbId.Text, out long id))
            {
                // El texto no es un número válido
                MessageBox.Show("Por favor, ingrese un número válido en el campo ID.");
            }
            else
            {
                long idCliente = long.Parse(tbId.Text);
                string nombreCliente = tbNombre.Text;
                string apellidoCliente = tbApellido.Text;
                string dniCliente = tbDni.Text;
                string direccionCliente = tbDireccion.Text;
                string telefonoCliente = tbTelefono.Text;
                string emailCliente = tbEmail.Text;
                DateTime fechaRegistroCliente = DateTime.Parse(dtpFechaRegistro.Text);
                bool aptoCliente = chbApto.Checked;

                ClienteDao clienteDao = new ClienteDao();
                if (clienteDao.BuscarPorDni(dniCliente))
                {
                    MessageBox.Show("Ya existe un cliente con dni numero: " + dniCliente);
                }
                else
                {
                    Cliente cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, dniCliente, direccionCliente,
                        telefonoCliente, emailCliente, fechaRegistroCliente, aptoCliente);
                    if (clienteDao.Crear(cliente))
                    {
                        MessageBox.Show("Cliente creado con exito");
                    }
                    Clientes formClientes = new Clientes();
                    formClientes.Show();
                    this.Close();
                }
            }
        }
    }
}
