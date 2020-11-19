using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasBeta
{
    public partial class VistaFuncionario : Form
    {
        public VistaFuncionario()
        {
            InitializeComponent();
        }

        Form1 formularioLogin = new Form1();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {

        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        public Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)

        {

        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Departamento());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Clientes());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Estadisticas());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Funcionarios());
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CheckIn());
        }


        private void btnCheckList_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CheckList());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar su sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                formularioLogin.Show();
            }
            else
            {
                this.Activate();
            }
        }
    }
}
