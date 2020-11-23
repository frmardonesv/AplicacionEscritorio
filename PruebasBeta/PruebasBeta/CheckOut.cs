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
    public partial class CheckList : Form
    {
        public CheckList()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");


        private void CheckList_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_ESTADO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtDepto.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Estado departamento actualizado");
            ora.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_MULTAS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("multas", OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adapter.Fill(tabla1);
            dtgMultas.DataSource = tabla1;

            ora.Close();
        }

        private void dtgMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepto.Text = dtgMultas.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
