namespace PruebasBeta
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.TablaDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaDatos
            // 
            this.TablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDatos.Location = new System.Drawing.Point(21, 111);
            this.TablaDatos.Name = "TablaDatos";
            this.TablaDatos.Size = new System.Drawing.Size(758, 240);
            this.TablaDatos.TabIndex = 16;
            this.TablaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDatos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "Buscar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(285, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(179, 48);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Buscar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtRut
            // 
            this.txtRut.Enabled = false;
            this.txtRut.Location = new System.Drawing.Point(21, 62);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(134, 20);
            this.txtRut.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnAct);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TablaDatos);
            this.panel1.Controls.Add(this.txtRut);
            this.panel1.Location = new System.Drawing.Point(57, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 414);
            this.panel1.TabIndex = 19;
            // 
            // btnListar
            // 
            this.btnListar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListar.BorderRadius = 0;
            this.btnListar.ButtonText = "    Listar";
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.DisabledColor = System.Drawing.Color.Gray;
            this.btnListar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnListar.Iconimage")));
            this.btnListar.Iconimage_right = null;
            this.btnListar.Iconimage_right_Selected = null;
            this.btnListar.Iconimage_Selected = null;
            this.btnListar.IconMarginLeft = 0;
            this.btnListar.IconMarginRight = 0;
            this.btnListar.IconRightVisible = true;
            this.btnListar.IconRightZoom = 0D;
            this.btnListar.IconVisible = true;
            this.btnListar.IconZoom = 90D;
            this.btnListar.IsTab = false;
            this.btnListar.Location = new System.Drawing.Point(600, 34);
            this.btnListar.Name = "btnListar";
            this.btnListar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListar.selected = false;
            this.btnListar.Size = new System.Drawing.Size(179, 48);
            this.btnListar.TabIndex = 62;
            this.btnListar.Text = "    Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Textcolor = System.Drawing.Color.White;
            this.btnListar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Rut Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Check In";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(194, 62);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(178, 20);
            this.txtDesc.TabIndex = 63;
            // 
            // btnAct
            // 
            this.btnAct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAct.BorderRadius = 0;
            this.btnAct.ButtonText = "    Actualizar";
            this.btnAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAct.Iconimage")));
            this.btnAct.Iconimage_right = null;
            this.btnAct.Iconimage_right_Selected = null;
            this.btnAct.Iconimage_Selected = null;
            this.btnAct.IconMarginLeft = 0;
            this.btnAct.IconMarginRight = 0;
            this.btnAct.IconRightVisible = true;
            this.btnAct.IconRightZoom = 0D;
            this.btnAct.IconVisible = true;
            this.btnAct.IconZoom = 90D;
            this.btnAct.IsTab = false;
            this.btnAct.Location = new System.Drawing.Point(405, 34);
            this.btnAct.Name = "btnAct";
            this.btnAct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAct.selected = false;
            this.btnAct.Size = new System.Drawing.Size(179, 48);
            this.btnAct.TabIndex = 64;
            this.btnAct.Text = "    Actualizar";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAct.Textcolor = System.Drawing.Color.White;
            this.btnAct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(645, 366);
            this.txtID.MaxLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(134, 20);
            this.txtID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(618, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1057, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaDatos;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnListar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAct;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}