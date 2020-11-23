using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace PruebasBeta
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                txtHabi.Text = "";
                txtCamas.Text = "";
                txtInclu.Text = "";
                txtNoInclu.Text = "";            
            }
        }

        private void txtHabi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            panelInventario.Visible = false;
            panelPrinc.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                txtInv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtHabi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCamas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtInclu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtNoInclu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_INVENTARIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = txtInv.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Inventario eliminado");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al elimar un inventario");


            }
            ora.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            panelPrinc.Visible = false;
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = true;
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            {
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("LISTAR_INVENTARIO", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("inventario", OracleType.Cursor).Direction = ParameterDirection.Output;


                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = comando;
                    DataTable tabla1 = new DataTable();
                    adapter.Fill(tabla1);
                    dataGridView1.DataSource = tabla1;

                    ora.Close();

                }

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInv.Text))
            {

                MessageBox.Show("Primero debe elegir un inventario para actualizarlo.");

                return;

            }
            panelPrinc.Visible = false;
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = true;
            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            panelInventario.Visible = false;
            panelPrinc.Visible = true;
            btnAtras.Visible = false;
            panel7.Visible = false;
            label9.Text = "Modulo Clientes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHabi.Text) || string.IsNullOrEmpty(txtCamas.Text) || string.IsNullOrEmpty(txtInclu.Text) || string.IsNullOrEmpty(txtNoInclu.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("REGISTRAR_INVENTARIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("c_habitacion", OracleType.VarChar).Value = txtHabi.Text;
                comando.Parameters.Add("c_camas", OracleType.VarChar).Value = txtCamas.Text;
                comando.Parameters.Add("c_incluido", OracleType.VarChar).Value = txtInclu.Text;
                comando.Parameters.Add("c_baños", OracleType.Number).Value = txtNoInclu.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Inventario Agregado.");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al registrar un inventario");


            }
            ora.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_INVENTARIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = txtInv.Text;
                comando.Parameters.Add("hab", OracleType.Number).Value = txtHabi.Text;
                comando.Parameters.Add("cam", OracleType.VarChar).Value = txtCamas.Text;
                comando.Parameters.Add("inc", OracleType.VarChar).Value = txtInclu.Text;
                comando.Parameters.Add("bañ", OracleType.Number).Value = txtNoInclu.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Inventario Actualizado");

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al actualizar un inventario");
            }
            ora.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHabi.Text = "";
            txtCamas.Text = "";
            txtInclu.Text = "";
            txtNoInclu.Text = "";
        }
    }
}
