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
    public partial class AgregarUsuarioForm : Form
    {
        public AgregarUsuarioForm()
        {
            InitializeComponent();
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            if (nombre_Tbx.Text != "" && apellidoPaterno_Tbx.Text != "" && apellidoMaterno_Tbx.Text != "" && (masculino_Rb.Checked || femenino_Rb.Checked) && direccion_Tbx.Text != "" && correoElectronico_Tbx.Text != "" && numeroTelefono_Tbx.Text != "")
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                String Nombre = nombre_Tbx.Text;
                String ApellidoPaterno = apellidoPaterno_Tbx.Text;
                String ApellidoMaterno = apellidoMaterno_Tbx.Text;
                DateTime FechaNacimiento = fechaDeNacimiento_dateTimePicker1.Value;
                String Sexo = masculino_Rb.Checked ? "Masculino" : "Femenino";
                String Direccion = direccion_Tbx.Text;
                String CorreoElectronico = correoElectronico_Tbx.Text;
                String NumeroTelefono = numeroTelefono_Tbx.Text;

                String query = $"INSERT INTO tbUsuario (Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Sexo, Direccion, CorreoElectronico, NumeroTelefono) VALUES('{Nombre}', '{ApellidoPaterno}', '{ApellidoMaterno}', '{FechaNacimiento}', '{Sexo}', '{Direccion}', '{CorreoElectronico}', '{NumeroTelefono}')";

                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                nombre_Tbx.Clear();
                apellidoPaterno_Tbx.Clear();
                apellidoMaterno_Tbx.Clear();
                masculino_Rb.Checked = false;
                femenino_Rb.Checked = false;
                direccion_Tbx.Clear();
                correoElectronico_Tbx.Clear();
                numeroTelefono_Tbx.Clear();
            }
            else
            {
                MessageBox.Show("Es necesario rellenar todos los campos para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

