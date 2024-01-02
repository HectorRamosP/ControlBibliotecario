using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ControlBibliotecario
{
    public partial class AgregarLibroForm : Form
    {
        public AgregarLibroForm()
        {
            InitializeComponent();
        }

        private void guardarAgregarLibro_Btn_Click(object sender, EventArgs e)
        {
            if (titulo_Tbx.Text != "" && nombreDelAutor_Tbx.Text != "" && editorial_Tbx.Text != "" && edicion_Tbx.Text != "" && categoria_Tbx.Text != "" && cantidadDeCopias_Tbx.Text != "")
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                String Titulo = titulo_Tbx.Text;
                String NombreAutor = nombreDelAutor_Tbx.Text;
                String Editorial = editorial_Tbx.Text;
                String Edicion = edicion_Tbx.Text;
                DateTime FechaPublicacion = fechaDePublicacion_dateTimePicker1.Value;
                String Categoria = categoria_Tbx.Text;
                String CantidadCopias = cantidadDeCopias_Tbx.Text;

                String query = $"INSERT INTO tbLibros (Titulo, NombreAutor, Editorial, Edicion, FechaPublicacion, Categoria, CantidadCopias) VALUES('{Titulo}', '{NombreAutor}', '{Editorial}', '{Edicion}', '{FechaPublicacion}', '{Categoria}', '{CantidadCopias}')";
               
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
               
                titulo_Tbx.Clear();
                nombreDelAutor_Tbx.Clear();
                editorial_Tbx.Clear();
                edicion_Tbx.Clear();
                categoria_Tbx.Clear();
                cantidadDeCopias_Tbx.Clear();
            }
            else
            {
                MessageBox.Show("Es necesario rellenar todos los campos para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
