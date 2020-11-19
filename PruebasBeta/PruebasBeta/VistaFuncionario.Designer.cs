namespace PruebasBeta
{
    partial class VistaFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaFuncionario));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnCheckIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoverDash = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1386, 72);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1297, 22);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1261, 22);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1297, 22);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1333, 22);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.SidebarWrapper.Controls.Add(this.btnLogOut);
            this.SidebarWrapper.Controls.Add(this.panel1);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 72);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 716);
            this.SidebarWrapper.TabIndex = 1;
            this.SidebarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarWrapper_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLogOut.ButtonText = "      Log Out";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 90D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(26, 650);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(242, 49);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "      Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.btnCheckList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.LineaSidebar);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 340);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckList
            // 
            this.btnCheckList.Activecolor = System.Drawing.Color.Transparent;
            this.btnCheckList.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckList.BorderRadius = 0;
            this.btnCheckList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCheckList.ButtonText = "      Check Out";
            this.btnCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckList.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheckList.Iconimage")));
            this.btnCheckList.Iconimage_right = null;
            this.btnCheckList.Iconimage_right_Selected = null;
            this.btnCheckList.Iconimage_Selected = null;
            this.btnCheckList.IconMarginLeft = 0;
            this.btnCheckList.IconMarginRight = 0;
            this.btnCheckList.IconRightVisible = true;
            this.btnCheckList.IconRightZoom = 0D;
            this.btnCheckList.IconVisible = true;
            this.btnCheckList.IconZoom = 90D;
            this.btnCheckList.IsTab = false;
            this.btnCheckList.Location = new System.Drawing.Point(14, 260);
            this.btnCheckList.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckList.Name = "btnCheckList";
            this.btnCheckList.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCheckList.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCheckList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckList.selected = false;
            this.btnCheckList.Size = new System.Drawing.Size(242, 49);
            this.btnCheckList.TabIndex = 13;
            this.btnCheckList.Text = "      Check Out";
            this.btnCheckList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckList.Textcolor = System.Drawing.Color.White;
            this.btnCheckList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckList.Click += new System.EventHandler(this.btnCheckList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnInicio.ButtonText = "      Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(14, 89);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(242, 49);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "      Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnClientes.ButtonText = "      Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(14, 146);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(242, 49);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "      Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(3, 57);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(264, 10);
            this.LineaSidebar.TabIndex = 3;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            this.LineaSidebar.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Activecolor = System.Drawing.Color.Transparent;
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckIn.BorderRadius = 0;
            this.btnCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCheckIn.ButtonText = "      Check In";
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Iconimage")));
            this.btnCheckIn.Iconimage_right = null;
            this.btnCheckIn.Iconimage_right_Selected = null;
            this.btnCheckIn.Iconimage_Selected = null;
            this.btnCheckIn.IconMarginLeft = 0;
            this.btnCheckIn.IconMarginRight = 0;
            this.btnCheckIn.IconRightVisible = true;
            this.btnCheckIn.IconRightZoom = 0D;
            this.btnCheckIn.IconVisible = true;
            this.btnCheckIn.IconZoom = 90D;
            this.btnCheckIn.IsTab = false;
            this.btnCheckIn.Location = new System.Drawing.Point(14, 203);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCheckIn.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCheckIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCheckIn.selected = false;
            this.btnCheckIn.Size = new System.Drawing.Size(242, 49);
            this.btnCheckIn.TabIndex = 11;
            this.btnCheckIn.Text = "      Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.Textcolor = System.Drawing.Color.White;
            this.btnCheckIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(300, 72);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1086, 716);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 304);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MoverDash
            // 
            this.MoverDash.Fixed = true;
            this.MoverDash.Horizontal = true;
            this.MoverDash.TargetControl = this.MenuTop;
            this.MoverDash.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(300, 771);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 17);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(997, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(961, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(997, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1033, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1369, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 699);
            this.panel3.TabIndex = 9;
            // 
            // VistaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Panel panelChildForm;
        private Bunifu.Framework.UI.BunifuDragControl MoverDash;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckList;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}