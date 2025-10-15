using ClubDeportivo.Forms;

namespace ClubDeportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los labels
            string correo = tbCorreo.Text;
            string pass = tbPass.Text;

            // Por ahora no hacemos nada con ellos
            // Solo mostramos el nuevo formulario de inicio

            Inicio inicio = new Inicio();
            inicio.Show();

            // Opcional: ocultar el formulario de login
            this.Hide();
        }
    }
}
