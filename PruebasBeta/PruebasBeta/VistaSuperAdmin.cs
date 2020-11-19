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
    public partial class VistaSuperAdmin : Form
    {
        public VistaSuperAdmin()
        {
            InitializeComponent();
        }

        Form1 formularioLogin = new Form1();

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Funcionarios());
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

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Departamento());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Estadisticas());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Servicios());
        }
    }
}
