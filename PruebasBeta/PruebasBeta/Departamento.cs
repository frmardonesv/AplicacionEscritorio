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
using System.IO;
using System.Drawing.Imaging;

namespace PruebasBeta
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");


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
            cmbZona.DataSource = listaInve;
            cmbZona.DisplayMember = "DESCRIPCION";
            cmbZona.ValueMember = "ID_ZONAS";
            ora.Close();
        }


        private void ListarInventario()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_INVENTARIO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("inventario", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable listaInve = new DataTable();
            adapter.Fill(listaInve);
            cmbInventario.DataSource = listaInve;
            cmbInventario.DisplayMember = "INCLUIDO";
            cmbInventario.ValueMember = "ID_INVENTARIO";
            ora.Close();
        }

        private void ListarEstados()
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("LISTAR_ESTADOS", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("estado", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            DataTable listaZona = new DataTable();
            adapter.Fill(listaZona);
            cmbEstado.DataSource = listaZona;
            cmbEstado.DisplayMember = "DESCRIPCION";
            cmbEstado.ValueMember = "ID_STDO_DEPTO";
            ora.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void accionesTabla()
        {
            dataGridView1.Columns[5].Visible = false;
        }


        private bool sumarBtnFuePresionado = false;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario formulario = new Inventario();
            formulario.Show();
        }

     
        private void Departamento_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarDepto_Click_1(object sender, EventArgs e)
        {

        }
        private string imagename;
        private string connstr;

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            sumarBtnFuePresionado = true;
            try

            {

                FileDialog fldlg = new OpenFileDialog();

                fldlg.InitialDirectory = @":D\";

                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";

                if (fldlg.ShowDialog() == DialogResult.OK)

                {

                    imagename = fldlg.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    PicImage.Image = (Image)newimg;

                }

                fldlg = null;

            }

            catch (System.ArgumentException ae)

            {

                imagename = " ";

                MessageBox.Show(ae.Message.ToString());

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());
            }



        }
        private void CrearDepartamento()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtMetros.Text))
            {
                MessageBox.Show("Debe completar la informacion");

                return;

            }

            try

            {
                if (imagename != "")
                {

                    FileStream fls;
                    fls = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
                    byte[] blob = new byte[fls.Length];
                    fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
                    fls.Close();
                    ora.Open();
                    OracleCommand cmnd;
                    string query;

                    query = "insert into DEPARTAMENTO(ID_DEPTO, METROS_CUA, DIRECCION, DESCRIPCION, PRECIO, IMG, ZONAS_ID_ZONAS, INVENTARIO_ID_INVENTARIO, STD_DEPTO_ID_STDO_DEPTO) " +
                        "values(SEQ_DEPTO.nextval," + "'" + txtMetros.Text + "'," + "'" + txtDireccion.Text + "'," + "'" + txtDescripcion.Text + "'," + "'" + txtPrecio.Text + "'," +
                        " :BlobParameter," + "'" + cmbZona.SelectedValue + "', " + "'" + cmbInventario.SelectedValue + "', " + "'" + cmbInventario.SelectedValue + "')";

                    OracleParameter blobParameter = new OracleParameter();
                    blobParameter.OracleType = OracleType.Blob;
                    blobParameter.ParameterName = "BlobParameter";
                    blobParameter.Value = blob;
                    cmnd = new OracleCommand(query, ora);
                    cmnd.Parameters.Add(blobParameter);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Departamento agregado.");
                    ora.Close();
                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                ora.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            panelDepartamento.Visible = false;
            panelPrinc.Visible = true;
        }
                
        private void panelPrinc_Paint(object sender, PaintEventArgs e)
        {

        }

 
  

        private void btnAgregarDepto_Click(object sender, EventArgs e)
        {
            this.CrearDepartamento();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            txtInvenCama.Text = "";
            txtInvenBaño.Text = "";
            txtInvenHab.Text = "";
            txtInvenIncl.Text = "";
            ora.Open();
            String query = "select HABITACION, CAMAS, INCLUIDO, BAÑOS from inventario where id_inventario =: idIn";
            OracleCommand comando = new OracleCommand(query, ora);
            comando.Parameters.AddWithValue("idIn", cmbInventario.SelectedIndex + 1);
            OracleDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txtInvenHab.Text += reader["HABITACION"].ToString();
                txtInvenCama.Text += reader["CAMAS"].ToString();
                txtInvenIncl.Text += reader["INCLUIDO"].ToString();
                txtInvenBaño.Text += reader["BAÑOS"].ToString();
            }
            reader.Close();
            ora.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            panelPrinc.Visible = false;
            panelDepartamento.Dock = DockStyle.Fill;
            panelDepartamento.Visible = true;
            ListarZonas();
            ListarInventario();
            ListarEstados();
            label16.Text = "Formulario departamentos";
            btnBack.Visible = true;
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("LISTAR_DEPARTAMENTO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("depto", OracleType.Cursor).Direction = ParameterDirection.Output;


                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla1 = new DataTable();
                adapter.Fill(tabla1);
                dataGridView1.DataSource = tabla1;

                ora.Close();
                accionesTabla();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDept.Text))
            {

                MessageBox.Show("Primero debe elegir un departamento para actualizarlo.");

                return;

            }
            panelPrinc.Visible = false;
            panelDepartamento.Dock = DockStyle.Fill;
            panelDepartamento.Visible = true;
            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
            ListarZonas();
            ListarInventario();
            ListarEstados();
        }

        private void btnElimi_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("ELIMINAR_DEPARTAMENTO", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDept.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Departamento Eliminado");
            ora.Close();
            txtIDept.Text = "";

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIDept.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMetros.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbZona.ValueMember = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbInventario.ValueMember = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbEstado.ValueMember = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            var data = (Byte[])(dataGridView1.CurrentRow.Cells[5].Value);
            var stream = new MemoryStream(data);
            PicImage.Image = Image.FromStream(stream);
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInvenCama.Text = "";
            txtInvenBaño.Text = "";
            txtInvenHab.Text = "";
            txtInvenIncl.Text = "";
            ora.Open();
            String query = "select HABITACION, CAMAS, INCLUIDO, BAÑOS from inventario where id_inventario =: idIn";
            OracleCommand comando = new OracleCommand(query, ora);
            comando.Parameters.AddWithValue("idIn", cmbInventario.SelectedIndex + 1);
            OracleDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txtInvenHab.Text += reader["HABITACION"].ToString();
                txtInvenCama.Text += reader["CAMAS"].ToString();
                txtInvenIncl.Text += reader["INCLUIDO"].ToString();
                txtInvenBaño.Text += reader["BAÑOS"].ToString();
            }
            reader.Close();
            ora.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CrearDepartamento();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try

            {
                if (imagename != "")
                {
                    if (sumarBtnFuePresionado == true)

                    {
                        var data = (Byte[])(dataGridView1.CurrentRow.Cells[5].Value);
                        var stream = new MemoryStream(data);
                        PicImage.Image = Image.FromStream(stream);

                        FileStream fls;
                        fls = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
                        byte[] blob = new byte[fls.Length];
                        fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
                        fls.Close();
                        ora.Open();
                        OracleCommand cmd = ora.CreateCommand();
                        cmd.CommandType = CommandType.Text;


                        cmd.CommandText = "UPDATE departamento SET metros_cua = :metr, direccion = :Direccion, descripcion =:descp, precio =: prec, img = :BlobParameter, zonas_id_zonas =: zon, inventario_id_inventario =: inv, std_depto_id_stdo_depto =: std WHERE id_depto = :idDe";
                        cmd.Parameters.AddWithValue("idDe", txtIDept.Text);
                        cmd.Parameters.AddWithValue("metr", txtMetros.Text);
                        cmd.Parameters.AddWithValue("Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("descp", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("prec", txtPrecio.Text);
                        OracleParameter blobParameter = new OracleParameter();
                        blobParameter.OracleType = OracleType.Blob;
                        blobParameter.ParameterName = "BlobParameter";
                        blobParameter.Value = blob;
                        cmd.Parameters.Add(blobParameter);
                        cmd.Parameters.AddWithValue("zon", cmbZona.SelectedValue);
                        cmd.Parameters.AddWithValue("inv", cmbInventario.SelectedValue);
                        cmd.Parameters.AddWithValue("std", cmbEstado.SelectedValue);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Departamento Actualizado.");
                        ora.Close();
                    }
                    else if (sumarBtnFuePresionado == false)
                    {
                        ora.Open();
                        OracleCommand comando = new OracleCommand("actualizar_departamento", ora);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("c_id", OracleType.Number).Value = txtIDept.Text;
                        comando.Parameters.Add("c_metros", OracleType.Number).Value = txtMetros.Text;
                        comando.Parameters.Add("c_direccion", OracleType.VarChar).Value = txtDireccion.Text;
                        comando.Parameters.Add("c_descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                        comando.Parameters.Add("c_precio", OracleType.Number).Value = txtPrecio.Text;
                        comando.Parameters.Add("c_zonas", OracleType.Number).Value = cmbZona.SelectedValue;
                        comando.Parameters.Add("c_inventario", OracleType.Number).Value = cmbInventario.SelectedValue;
                        comando.Parameters.Add("c_std_depto", OracleType.Number).Value = cmbEstado.SelectedValue;
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Departamento Actualizado");
                        ora.Close();
                    }
                }
            }

            catch (OracleException ex)
            {
                string errorMessage = "Code: " + ex.Code + "\n" +
                                      "Message: " + ex.Message;

                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                log.Source = "My Application";
                log.WriteEntry(errorMessage);
                Console.WriteLine("An exception occurred. Please contact your system administrator.");
            }
            finally
            {
                ora.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnActualizar.Visible = false;
            panelDepartamento.Visible = false;
            panelPrinc.Visible = true;
            btnAtras.Visible = false;
            panel7.Visible = false;
            btnBack.Visible = false;
            label16.Text = "Modulo Departamentos";
        }
    }
}
