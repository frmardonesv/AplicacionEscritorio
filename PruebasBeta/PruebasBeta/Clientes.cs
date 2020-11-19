using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OracleClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasBeta
{
    public partial class Clientes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        public Clientes()

        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelPrinc.Visible = false;
            panelFormCliente.Dock = DockStyle.Fill;
            panelFormCliente.Visible = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_CLIENTE", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("cliente",OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            ora.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRut.Enabled = false;
            txtCli.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtRut.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtContra.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelFormCliente.Visible = false;
        }

        private void panelFormCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("REGISTRAR_CLIENTE", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("c_rut", OracleType.Number).Value = txtRut.Text;
                    comando.Parameters.Add("c_nombre", OracleType.VarChar).Value = txtNombre.Text;
                    comando.Parameters.Add("c_apellido", OracleType.VarChar).Value = txtApellido.Text;
                    comando.Parameters.Add("c_correo", OracleType.VarChar).Value = txtCorreo.Text;
                    comando.Parameters.Add("c_contraseña", OracleType.VarChar).Value = txtContra.Text;
                    comando.Parameters.Add("c_telefono", OracleType.Number).Value = txtTelefono.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente ingresado");



                }
                catch (Exception)
                {

                    MessageBox.Show("Fallo al ingresar Cliente");


                }
                ora.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
                txtRut.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtContra.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = ""; 
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            panelPrinc.Visible = false;
            panelFormCliente.Dock = DockStyle.Fill;
            panelFormCliente.Visible = true;
            btnAgregar.Visible = false;
            btnAct.Visible = true;
        }

        private void btnAct_Click(object sender, EventArgs e)
            {
                try
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("ACTUALIZAR_CLIENTE", ora);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("idp", OracleType.VarChar).Value = txtRut.Text;
                    comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                    comando.Parameters.Add("ape", OracleType.VarChar).Value = txtApellido.Text;
                    comando.Parameters.Add("te", OracleType.Number).Value = txtTelefono.Text;
                    comando.Parameters.Add("cor", OracleType.VarChar).Value = txtCorreo.Text;
                    comando.Parameters.Add("contr", OracleType.VarChar).Value = txtContra.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente Actualizado");

                }
                catch (Exception)
                {

                    MessageBox.Show("Fallo al actualizar un cliente");
                }
                ora.Close();
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_CLIENTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = txtCli.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al elimar un cliente");


            }
            ora.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private void panelPrinc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}   
