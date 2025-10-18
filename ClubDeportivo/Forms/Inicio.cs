using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario Clientes
            Clientes Clientes = new Clientes();

            // Mostrar el formulario de Clientes
            Clientes.Show();

            // Esconder el formulario actual (Inicio)
            this.Close();
        }
    }
}
