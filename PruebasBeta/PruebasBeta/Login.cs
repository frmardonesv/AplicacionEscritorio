using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebasBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = hola123 ; USER ID = EmiliaTan");

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
             if(string.IsNullOrEmpty(txtUsuario.Text)|| string.IsNullOrEmpty(txtContra.Text)){

                 MessageBox.Show("Debe completar la informacion");  

                return;

            }
            {
                {
                    ora.Open();
                    OracleCommand comando = new OracleCommand("Select rut, contraseña, ZONAS_ID_ZONAS, TIPO_PERSONAL_ID_TIPO_PRS from personal WHERE rut =  :usuario AND contraseña = :contra", ora);

                    comando.Parameters.AddWithValue(":usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue(":contra", txtContra.Text);

                    OracleDataReader lector = comando.ExecuteReader();

                    Form1 formularioLogin = new Form1();
                    if (lector.Read())
                    {

                        if (lector["TIPO_PERSONAL_ID_TIPO_PRS"].ToString() == "1")
                        {
                            MessageBox.Show("Bienvenido funcioanario");
                            VistaFuncionario formulario = new VistaFuncionario();
                            ora.Close();
                            formulario.Show();
                            this.Hide();
                        }
                        else if (lector["TIPO_PERSONAL_ID_TIPO_PRS"].ToString() == "2")
                        {
                            MessageBox.Show("Bienvenido Administrador");
                            VistaAdmin formulario = new VistaAdmin();
                            ora.Close();
                            formulario.Show();
                            this.Hide();
                        }
                        else if (lector["TIPO_PERSONAL_ID_TIPO_PRS"].ToString() == "3")
                        {
                            MessageBox.Show("Bienvenido SuperAdministrador");
                            VistaSuperAdmin formulario = new VistaSuperAdmin();
                            ora.Close();
                            formulario.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto");
                    }
                    ora.Close();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}


