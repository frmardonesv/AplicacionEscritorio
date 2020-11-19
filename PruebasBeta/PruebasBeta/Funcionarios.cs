using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasBeta
{
    public partial class Funcionarios : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        public Funcionarios()
        {
            InitializeComponent();
        }

        private void ListarZonas()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_ZONAS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("zona", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable listaInve = new DataTable();
            adapter.Fill(listaInve);
            comboBoxzona.DataSource = listaInve;
            comboBoxzona.DisplayMember = "DESCRIPCION";
            comboBoxzona.ValueMember = "ID_ZONAS";
            ora.Close();
        }

        private void ListarTipo()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_TIPO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("tipo", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable listaInve = new DataTable();
            adapter.Fill(listaInve);
            comboBoxtipo.DataSource = listaInve;
            comboBoxtipo.DisplayMember = "DESCRIPCION";
            comboBoxtipo.ValueMember = "ID_TIPO_PRS";
            ora.Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtRut.Text = "";
            txtContra.Text = "";
            txtTelefono.Text = "";
            btnAct.Visible = false;
            panelPrinc.Visible = false;
            panelFuncion.Dock = DockStyle.Fill;
            ListarZonas();
            ListarTipo();
            panelFuncion.Visible = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_PERSONAL", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("personal", OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adapter.Fill(tabla1);
            dataGridView1.DataSource = tabla1;

            ora.Close();

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)

        {
            try {
                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_PERSONAL", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.VarChar).Value = txtPersonal.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario eliminado");
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al ingresar Funcionario");


            }
            ora.Close();
        }

        private void btnAgregarFunc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtContra.Text) || string.IsNullOrEmpty(txtRut.Text)
                || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtContra.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("REGISTRAR_PERSONAL", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("c_nombre", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("c_apellido", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("c_rut", OracleType.Number).Value = txtRut.Text;
                comando.Parameters.Add("c_telefono", OracleType.Number).Value = txtTelefono.Text;
                comando.Parameters.Add("c_correo", OracleType.VarChar).Value = txtCorreo.Text;
                comando.Parameters.Add("c_contraseña", OracleType.VarChar).Value = txtContra.Text;
                comando.Parameters.Add("c_zonas", OracleType.Number).Value = comboBoxzona.SelectedValue;
                comando.Parameters.Add("c_id_pers", OracleType.Number).Value = comboBoxtipo.SelectedValue;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario ingresado");
                                
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al ingresar Funcionario");


            }
            ora.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtRut.Text = "";
                txtContra.Text = "";
                txtTelefono.Text = "";

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonal.Text))
            {

                MessageBox.Show("Primero debe elegir un funcionario para actualizarlo");

                return;

            }
            panelPrinc.Visible = false;
            panelFuncion.Dock = DockStyle.Fill;
            ListarZonas();
            ListarTipo();
            panelFuncion.Visible = true;
            btnAgregar.Visible = false;
            btnAct.Visible = true;
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PERSONAL", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.VarChar).Value = txtPersonal.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("ape", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("rt", OracleType.Number).Value = txtRut.Text;
                comando.Parameters.Add("te", OracleType.Number).Value = txtTelefono.Text;
                comando.Parameters.Add("cor", OracleType.VarChar).Value = txtCorreo.Text;
                comando.Parameters.Add("contr", OracleType.VarChar).Value = txtContra.Text;
                comando.Parameters.Add("tip", OracleType.Number).Value = comboBoxzona.SelectedIndex + 1;
                comando.Parameters.Add("tiz", OracleType.Number).Value = comboBoxtipo.SelectedIndex + 1;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario Actualizado");

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al actualizar un funcionario");
            }
            ora.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAct.Visible = false;
            panelFuncion.Visible = false;
            panelPrinc.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonal.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRut.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtContra.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxzona.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxtipo.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void panelPrinc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAct_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtRut.Enabled = false;
                ora.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PERSONAL", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.VarChar).Value = txtPersonal.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("ape", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("rt", OracleType.Number).Value = txtRut.Text;
                comando.Parameters.Add("te", OracleType.Number).Value = txtTelefono.Text;
                comando.Parameters.Add("cor", OracleType.VarChar).Value = txtCorreo.Text;
                comando.Parameters.Add("contr", OracleType.VarChar).Value = txtContra.Text;
                comando.Parameters.Add("tip", OracleType.Number).Value = comboBoxzona.SelectedIndex + 1;
                comando.Parameters.Add("tiz", OracleType.Number).Value = comboBoxtipo.SelectedIndex + 1;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario Actualizado");

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo al actualizar un funcionario");
            }
            ora.Close();
        }
    }
}

