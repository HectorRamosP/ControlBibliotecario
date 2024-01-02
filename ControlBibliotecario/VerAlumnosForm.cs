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
    public partial class VerAlumnosForm : Form
    {
        int Id;
        Int64 colid;
        public VerAlumnosForm()
        {
            InitializeComponent();
        }

        private void actualizar_Btn_Click(object sender, EventArgs e)
        {
            buscar_Tbx.Clear();
            panel2.Visible = false;
        }

        private void modificar_Btn_Click(object sender, EventArgs e)
        {
            String Nombre = nombre_Tbx.Text;
            String ApellidoPaterno = apellidoPaterno_Tbx.Text;
            String ApellidoMaterno = apellidoMaterno_Tbx.Text;
            String FechaNacimiento =fechaDeNacimiento_Tbx.Text;
            String Sexo = masculino_Rb.Checked ? "Masculino" : "Femenino";
            String Direccion = direccion_Tbx.Text;
            String CorreoElectronico = correoElectronico_Tbx.Text;
            String NumeroTelefono = numeroDeTelefono_Tbx.Text;

            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            string query = "update tbUsuario set Nombre = '" + Nombre + "', ApellidoPaterno = '" + ApellidoPaterno + "', ApellidoMaterno = '" + ApellidoMaterno + "', FechaNacimiento = '" + FechaNacimiento + "', Sexo = '" + Sexo + "', Direccion = '" + Direccion + "', CorreoElectronico = '" + CorreoElectronico + "', NumeroTelefono = '"+ NumeroTelefono +"'  where Id = " + colid + "";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            string query = "SELECT * FROM tbUsuario where Id= " + Id + "";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            colid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            nombre_Tbx.Text = ds.Tables[0].Rows[0][1].ToString();
            apellidoPaterno_Tbx.Text = ds.Tables[0].Rows[0][2].ToString();
            apellidoMaterno_Tbx.Text = ds.Tables[0].Rows[0][3].ToString();
            fechaDeNacimiento_Tbx.Text = ds.Tables[0].Rows[0][4].ToString();
            
            direccion_Tbx.Text = ds.Tables[0].Rows[0][6].ToString();
            correoElectronico_Tbx.Text = ds.Tables[0].Rows[0][7].ToString();
            numeroDeTelefono_Tbx.Text = ds.Tables[0].Rows[0][8].ToString();

            string Sexo = ds.Tables[0].Rows[0][5].ToString();
            if (Sexo == "Masculino")
            {
                masculino_Rb.Checked = true;
                femenino_Rb.Checked = false;
            }
            else if (Sexo == "Femenino")
            {
                masculino_Rb.Checked = false;
                femenino_Rb.Checked = true;
            }
        }

        private void VerAlumnosForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            string query = "SELECT * FROM tbUsuario";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas eliminar esta informacion?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string query = "delete from tbUsuario where Id = " + colid + "";

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void buscar_Tbx_TextChanged(object sender, EventArgs e)
        {
            if (buscar_Tbx.Text != "")
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string query = "SELECT * FROM tbUsuario where Nombre LIKE '" + buscar_Tbx.Text + "%'";

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string query = "SELECT * FROM tbUsuario";

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}
