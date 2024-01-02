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
    public partial class VerLibrosForm : Form
    {
        int Id;
        Int64 colid;
        public VerLibrosForm()
        {
            InitializeComponent();
        }

        private void VerLibrosForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            string query = "SELECT * FROM tbLibros";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

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
            string query = "SELECT * FROM tbLibros where Id= " + Id + "";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            colid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            titulo_Tbx.Text = ds.Tables[0].Rows[0][1].ToString();
            nombreDelAutor_Tbx.Text = ds.Tables[0].Rows[0][2].ToString();
            editorial_Tbx.Text = ds.Tables[0].Rows[0][3].ToString();
            edicion_Tbx.Text = ds.Tables[0].Rows[0][4].ToString();
            fechaDePublicacion_Tbx.Text = ds.Tables[0].Rows[0][5].ToString();
            categoria_Tbx.Text = ds.Tables[0].Rows[0][6].ToString();
            cantidadDeCopias_Tbx.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void buscar_Tbx_TextChanged(object sender, EventArgs e)
        {
            if(buscar_Tbx.Text != "")
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string query = "SELECT * FROM tbLibros where Titulo LIKE '"+buscar_Tbx.Text+"%'";

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
                string query = "SELECT * FROM tbLibros";

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void actualizar_Btn_Click(object sender, EventArgs e)
        {
            buscar_Tbx.Clear();
            panel2.Visible = false;
        }

        private void modificar_Btn_Click(object sender, EventArgs e)
        {
            String Titulo = titulo_Tbx.Text;
            String NombreAutor = nombreDelAutor_Tbx.Text;
            String Editorial = editorial_Tbx.Text;
            String Edicion = edicion_Tbx.Text;
            String FechaPublicacion = fechaDePublicacion_Tbx.Text;
            String Categoria = categoria_Tbx.Text;
            String CantidadCopias = cantidadDeCopias_Tbx.Text;

            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            string query = "update tbLibros set Titulo = '"+Titulo+"', NombreAutor = '" +NombreAutor+ "', Editorial = '" +Editorial+ "', Edicion = '" +Edicion+ "', FechaPublicacion = '" +FechaPublicacion+ "', Categoria = '"+Categoria+"', CantidadCopias = '"+CantidadCopias+"' where Id = "+colid+"";

            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas eliminar esta informacion?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string query = "delete from tbLibros where Id = " + colid + "";

                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
