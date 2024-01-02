using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ControlBibliotecario
{
    public partial class SolicitarLibroForm : Form
    {
        public SolicitarLibroForm()
        {
            InitializeComponent();
        }

        private void SolicitarLibroForm_Load(object sender, EventArgs e)
        {
            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();

            OleDbCommand cmd = new OleDbCommand("select Titulo FROM tbLibros", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for(int i = 0; i<reader.FieldCount; i++)
                {
                    solicitarLibro_Cbo.Items.Add(reader.GetString(i));
                }
            }
            reader.Close();
            con.Close();
        }
        Int32 count;
        private bool ExisteLibroPrestado(int userId, string nombreLibro)
        {
            bool existe = false;

            try
            {
                string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();

                    string query = $"SELECT COUNT(*) FROM tbUsuariosSolicitar WHERE Id = {userId} AND NombreLibro = '{nombreLibro}' AND FechaDevolucion IS NULL";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();

                    existe = (count > 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el libro está prestado: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }
        private int ContarLibrosSolicitados(int userId)
        {
            int count = 0;

            try
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();

                    string query = $"SELECT COUNT(*) FROM tbUsuariosSolicitar WHERE Id = {userId} AND FechaDevolucion IS NULL";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar los libros solicitados: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }
        private void buscarUsuario_Btn_Click(object sender, EventArgs e)
        {
            if (buscarId_Tbx.Text != "")
            {
                Int32 Id = Int32.Parse(buscarId_Tbx.Text);
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();

                string query = "select Nombre, ApellidoPaterno, ApellidoMaterno, CorreoElectronico, NumeroTelefono FROM tbUsuario where Id = " + Id;

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    nombre_Tbx.Text = ds.Tables[0].Rows[0][0].ToString();
                    apellidoPaterno_Tbx.Text = ds.Tables[0].Rows[0][1].ToString();
                    apellidoMaterno_Tbx.Text = ds.Tables[0].Rows[0][2].ToString();
                    correoElectronico_Tbx.Text = ds.Tables[0].Rows[0][3].ToString();
                    numeroDeTelefono_Tbx.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    nombre_Tbx.Clear();
                    apellidoPaterno_Tbx.Clear();
                    apellidoMaterno_Tbx.Clear();
                    correoElectronico_Tbx.Clear();
                    numeroDeTelefono_Tbx.Clear();
                    MessageBox.Show("ID no válida, asegúrate de escribir un número válido en el campo ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string query1 = "select count(Id) from tbUsuariosSolicitar where Id = " + Id + " and FechaDevolucion is null";
                OleDbDataAdapter da1 = new OleDbDataAdapter(query1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
            }
            else
            {
                nombre_Tbx.Clear();
                apellidoPaterno_Tbx.Clear();
                apellidoMaterno_Tbx.Clear();
                correoElectronico_Tbx.Clear();
                numeroDeTelefono_Tbx.Clear();
                MessageBox.Show("ID no válida, asegúrate de escribir un número válido en el campo ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void solicitarLibro_Btn_Click(object sender, EventArgs e)
        {
            if (nombre_Tbx.Text != "")
            {
                if (solicitarLibro_Cbo.SelectedIndex != -1)
                {
                    Int32 userId;

                    if (Int32.TryParse(buscarId_Tbx.Text, out userId))
                    {
                        string nombreLibro = solicitarLibro_Cbo.Text;

                        if (!ExisteLibroPrestado(userId, nombreLibro) && ContarLibrosSolicitados(userId) < 3)
                        {
                            
                            try
                            {
                                string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                                using (OleDbConnection con = new OleDbConnection(connection))
                                {
                                    con.Open();

                                    
                                    Int32 Ide = Int32.Parse(buscarId_Tbx.Text);
                                    string nombre = nombre_Tbx.Text;
                                    string apellidoPaterno = apellidoPaterno_Tbx.Text;
                                    string apellidoMaterno = apellidoMaterno_Tbx.Text;
                                    string correoElectronico = correoElectronico_Tbx.Text;
                                    string numeroTelefono = numeroDeTelefono_Tbx.Text;
                                    DateTime fechaSolicitud = fechaDeSolicitud_dateTimePicker1.Value;

                                   
                                    string query = $"INSERT INTO tbUsuariosSolicitar (Id, Nombre, ApellidoPaterno, ApellidoMaterno, CorreoElectronico, NumeroTelefono, NombreLibro, FechaSolicitud) VALUES ('{Ide}', '{nombre}', '{apellidoPaterno}', '{apellidoMaterno}', '{correoElectronico}', '{numeroTelefono}', '{nombreLibro}', '{fechaSolicitud}')";

                                    OleDbCommand cmd = new OleDbCommand(query, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    MessageBox.Show("Éxito, libro solicitado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al solicitar el libro: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (ExisteLibroPrestado(userId, nombreLibro))
                        {
                            MessageBox.Show("El usuario ya ha solicitado este libro.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya ha alcanzado el límite de 3 libros.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID no válido, intente de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un libro.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("ID no válido, intente de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buscarId_Tbx_TextChanged(object sender, EventArgs e)
        {
            if(buscarId_Tbx.Text == "")
            {
                nombre_Tbx.Clear();
                apellidoPaterno_Tbx.Clear();
                apellidoMaterno_Tbx.Clear();
                correoElectronico_Tbx.Clear();
                numeroDeTelefono_Tbx.Clear();
            }
        }
    }
}
