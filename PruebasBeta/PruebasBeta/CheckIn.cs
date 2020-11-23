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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }                       

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_CHECKIN", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("checki", OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            TablaDatos.DataSource = tabla;

            ora.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_CHECKIN", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtID.Text);
            comando.Parameters.Add("des", OracleType.VarChar).Value = txtDesc.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Check In Actualizado");
            ora.Close();
        }

        private void TablaDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtRut.Text = TablaDatos.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = TablaDatos.CurrentRow.Cells[2].Value.ToString();
            txtID.Text = TablaDatos.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
