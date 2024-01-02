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
    public partial class DevolverLibroForm : Form
    {

        public DevolverLibroForm()
        {
            InitializeComponent();
        }

        private void buscarUsuario_Btn_Click(object sender, EventArgs e)
        {
            Int32 Id = Int32.Parse(buscarId_Tbx.Text);
            String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();

            string query = "select * from tbUsuariosSolicitar where Id = " +buscarId_Tbx.Text + "and FechaDevolucion is NULL";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("ID No valida o libro no ha solicitado ningun libro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevolverLibroForm_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            buscarId_Tbx.Clear();
        }

        string nombreLibro;
        string fechaSolicitud;
        Int64 colid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                colid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                nombreLibro = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                fechaSolicitud = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


            }
            nombreLibro_Tbx.Text = nombreLibro;
            fechaSolicitud_Tbx.Text = fechaSolicitud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int buscarId;
                if (int.TryParse(buscarId_Tbx.Text, out buscarId))
                {
                    string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HECTOR\Desktop\DB ControlBibliotecario\ControlBibliotecarioDB.mdb";
                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        con.Open();

                        string query = "UPDATE tbUsuariosSolicitar SET FechaDevolucion = ? WHERE Id = ? AND Id = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@fechaDevolucion", fechaDeDevolucion_dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@buscarId", buscarId);
                            cmd.Parameters.AddWithValue("@colid", colid);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Devolucion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DevolverLibroForm_Load(this, null);
                    }
                }
                else
                {
                    MessageBox.Show("El ID que busca no es valido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
