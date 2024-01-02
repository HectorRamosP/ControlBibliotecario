using System;
using System.Windows.Forms;

namespace ControlBibliotecario
{
    public partial class iniciarSesionForm : Form
    {
        public iniciarSesionForm()
        {
            InitializeComponent();
        }

        private void admin_Btn_Click(object sender, EventArgs e)
        {
            AbrirInterfazComoAdmin();
        }

        private void AbrirInterfazComoAdmin()
        {
            interfazBibliotecaForm interfazB = new interfazBibliotecaForm(esAdmin: true);
            interfazB.Show();
            this.Hide();
        }

        private void invitado_Btn_Click(object sender, EventArgs e)
        {
            AbrirInterfazComoUsuario();
        }

        private void AbrirInterfazComoUsuario()
        {
            interfazBibliotecaForm interfazB = new interfazBibliotecaForm(esAdmin: false);
            interfazB.Show();
            this.Hide();
        }
    }
}
