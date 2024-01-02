using System;
using System.Windows.Forms;

namespace ControlBibliotecario
{
    public partial class interfazBibliotecaForm : Form
    {
        public interfazBibliotecaForm(bool esAdmin)
        {
            InitializeComponent();

            if (!esAdmin)
            {
                anadirUnNuevoToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                anadirUnNuevoToolStripMenuItem.Visible = false;
            }
        }

        public interfazBibliotecaForm()
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres salir de la aplicacion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void anadirUnNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarLibroForm agregarLibro = new AgregarLibroForm();
            agregarLibro.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerLibrosForm verLibros = new VerLibrosForm();
            verLibros.Show();
        }

        private void agregarUnNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForm agregarUsuario = new AgregarUsuarioForm();
            agregarUsuario.Show();
        }

        private void verInformacionDelUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAlumnosForm verAlumnos = new VerAlumnosForm();
            verAlumnos.Show();
        }

        private void solicitarUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitarLibroForm solicitarLibro = new SolicitarLibroForm();
            solicitarLibro.Show();
        }

        private void devolverUnLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolverLibroForm devolverLibro = new DevolverLibroForm();
            devolverLibro.Show();
        }
    }
}
