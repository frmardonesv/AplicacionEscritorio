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
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }
        Form1 formularioLogin = new Form1();

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
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

        private void btnMantenciones_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Funcionarios formulario = new Funcionarios();
            formulario.Show();
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Estadisticas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Clientes());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Inventario());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Servicios());
        }
    }
}
