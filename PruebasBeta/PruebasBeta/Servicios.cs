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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        private void ListarEstado()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_TOURES", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("toure", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable listaInve = new DataTable();
            adapter.Fill(listaInve);
            cmbEstado.DataSource = listaInve;
            cmbEstado.DisplayMember = "DESCRIPCION";
            cmbEstado.ValueMember = "ID_STD_TOUR";
            ora.Close();
        }



        private void Servicios_Load(object sender, EventArgs e)
        {

        }
                               
        private void btnAgregarFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLugar.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("REGISTRO_TOUR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("c_LUGAR", OracleType.VarChar).Value = txtLugar.Text;
                comando.Parameters.Add("c_FECHA", OracleType.DateTime).Value = fecha.Text;
                comando.Parameters.Add("c_STD_TOUR", OracleType.Number).Value = cmbEstado.SelectedValue;
                comando.ExecuteNonQuery();
                MessageBox.Show("Tour Ingresado.");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al registrar un Tour");


            }
            ora.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_TOUR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = txtCli.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Tour eliminado");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al eliminar un Tour");


            }
            ora.Close();
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCli.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_TOUR", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("toure", OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            ora.Close();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            panelPrinc.Visible = false;
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = true;
            ListarEstado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLugar.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("REGISTRO_TOUR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("c_LUGAR", OracleType.VarChar).Value = txtLugar.Text;
                comando.Parameters.Add("c_FECHA", OracleType.DateTime).Value = fecha.Text;
                comando.Parameters.Add("c_STD_TOUR", OracleType.Number).Value = cmbEstado.SelectedValue;
                comando.ExecuteNonQuery();
                MessageBox.Show("Tour Ingresado.");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al registrar un Tour");


            }
            ora.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtLugar.Text = "";
            cmbEstado.SelectedIndex = 0;
        }
    }
}

