namespace PruebasBeta
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnListar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.BorderRadius = 0;
            this.btnReporte.ButtonText = "Generar reporte";
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReporte.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReporte.Iconimage")));
            this.btnReporte.Iconimage_right = null;
            this.btnReporte.Iconimage_right_Selected = null;
            this.btnReporte.Iconimage_Selected = null;
            this.btnReporte.IconMarginLeft = 0;
            this.btnReporte.IconMarginRight = 0;
            this.btnReporte.IconRightVisible = true;
            this.btnReporte.IconRightZoom = 0D;
            this.btnReporte.IconVisible = true;
            this.btnReporte.IconZoom = 90D;
            this.btnReporte.IsTab = false;
            this.btnReporte.Location = new System.Drawing.Point(66, 119);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReporte.selected = false;
            this.btnReporte.Size = new System.Drawing.Size(204, 48);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Textcolor = System.Drawing.Color.White;
            this.btnReporte.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Visible = false;
            this.btnReporte.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnListar
            // 
            this.btnListar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListar.BorderRadius = 0;
            this.btnListar.ButtonText = "Listar";
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
            this.btnListar.Location = new System.Drawing.Point(66, 119);
            this.btnListar.Name = "btnListar";
            this.btnListar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnListar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListar.selected = false;
            this.btnListar.Size = new System.Drawing.Size(204, 48);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Textcolor = System.Drawing.Color.White;
            this.btnListar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 30);
            this.label9.TabIndex = 39;
            this.label9.Text = "Estadisticas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(66, 218);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(788, 249);
            this.dataGridView1.TabIndex = 40;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(910, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnReporte);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnReporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnListar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}