namespace AdminSAP.Views.BitacorasVw
{
    partial class frmProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbRegistros = new MetroFramework.Controls.MetroComboBox();
            this.grvConsulta = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnMenos = new MetroFramework.Controls.MetroButton();
            this.btnMas = new MetroFramework.Controls.MetroButton();
            this.lblRegistroActual = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCriterioBusqueda = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFeInicioSinc = new MetroFramework.Controls.MetroCheckBox();
            this.chkFeFinSinc = new MetroFramework.Controls.MetroCheckBox();
            this.dtFeInicioSinc = new MetroFramework.Controls.MetroDateTime();
            this.dtFeFinSinc = new MetroFramework.Controls.MetroDateTime();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvConsulta)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1325, 736);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cmbRegistros, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.grvConsulta, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMenos, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMas, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRegistroActual, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1315, 687);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbRegistros
            // 
            this.cmbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRegistros.FormattingEnabled = true;
            this.cmbRegistros.ItemHeight = 24;
            this.cmbRegistros.Location = new System.Drawing.Point(65, 637);
            this.cmbRegistros.Name = "cmbRegistros";
            this.cmbRegistros.Size = new System.Drawing.Size(80, 30);
            this.cmbRegistros.TabIndex = 3;
            this.cmbRegistros.UseSelectable = true;
            this.cmbRegistros.SelectedIndexChanged += new System.EventHandler(this.cmbRegistros_SelectedIndexChanged);
            // 
            // grvConsulta
            // 
            this.grvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.grvConsulta, 7);
            this.grvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvConsulta.Location = new System.Drawing.Point(3, 68);
            this.grvConsulta.Name = "grvConsulta";
            this.grvConsulta.RowTemplate.Height = 24;
            this.grvConsulta.Size = new System.Drawing.Size(1309, 561);
            this.grvConsulta.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 642);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Mostrar";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(151, 642);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Registros";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenos.Location = new System.Drawing.Point(1180, 637);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(60, 30);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Text = "<";
            this.btnMenos.UseSelectable = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMas.Location = new System.Drawing.Point(1252, 637);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(60, 30);
            this.btnMas.TabIndex = 4;
            this.btnMas.Text = ">";
            this.btnMas.UseSelectable = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // lblRegistroActual
            // 
            this.lblRegistroActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistroActual.AutoSize = true;
            this.lblRegistroActual.Location = new System.Drawing.Point(1246, 652);
            this.lblRegistroActual.Name = "lblRegistroActual";
            this.lblRegistroActual.Size = new System.Drawing.Size(1, 0);
            this.lblRegistroActual.TabIndex = 3;
            this.lblRegistroActual.UseCustomBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 7);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtCriterioBusqueda, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.button2, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkFeInicioSinc, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkFeFinSinc, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtFeInicioSinc, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtFeFinSinc, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1309, 59);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCriterioBusqueda.CustomButton.Image = null;
            this.txtCriterioBusqueda.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtCriterioBusqueda.CustomButton.Name = "";
            this.txtCriterioBusqueda.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCriterioBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCriterioBusqueda.CustomButton.TabIndex = 1;
            this.txtCriterioBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCriterioBusqueda.CustomButton.UseSelectable = true;
            this.txtCriterioBusqueda.CustomButton.Visible = false;
            this.txtCriterioBusqueda.Lines = new string[0];
            this.txtCriterioBusqueda.Location = new System.Drawing.Point(3, 26);
            this.txtCriterioBusqueda.MaxLength = 32767;
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.PasswordChar = '\0';
            this.txtCriterioBusqueda.PromptText = "Ingrese el código o descripción del producto";
            this.tableLayoutPanel3.SetRowSpan(this.txtCriterioBusqueda, 2);
            this.txtCriterioBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCriterioBusqueda.SelectedText = "";
            this.txtCriterioBusqueda.SelectionLength = 0;
            this.txtCriterioBusqueda.SelectionStart = 0;
            this.txtCriterioBusqueda.ShortcutsEnabled = true;
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(402, 30);
            this.txtCriterioBusqueda.TabIndex = 0;
            this.txtCriterioBusqueda.UseSelectable = true;
            this.txtCriterioBusqueda.WaterMark = "Ingrese el código o descripción del producto";
            this.txtCriterioBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCriterioBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AdminSAP.Properties.Resources.icons8_filtrar_24;
            this.button1.Location = new System.Drawing.Point(1231, 26);
            this.button1.Name = "button1";
            this.tableLayoutPanel3.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AdminSAP.Properties.Resources.icons8_eliminar_filtros_24;
            this.button2.Location = new System.Drawing.Point(1271, 26);
            this.button2.Name = "button2";
            this.tableLayoutPanel3.SetRowSpan(this.button2, 2);
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCerrar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1315, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(1281, 5);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(31, 29);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1272, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitácoras";
            // 
            // chkFeInicioSinc
            // 
            this.chkFeInicioSinc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFeInicioSinc.AutoSize = true;
            this.chkFeInicioSinc.Location = new System.Drawing.Point(411, 3);
            this.chkFeInicioSinc.Name = "chkFeInicioSinc";
            this.chkFeInicioSinc.Size = new System.Drawing.Size(200, 17);
            this.chkFeInicioSinc.TabIndex = 2;
            this.chkFeInicioSinc.Text = "Fecha inicio sincronización";
            this.chkFeInicioSinc.UseCustomBackColor = true;
            this.chkFeInicioSinc.UseSelectable = true;
            this.chkFeInicioSinc.CheckedChanged += new System.EventHandler(this.chkFeInicioSinc_CheckedChanged);
            // 
            // chkFeFinSinc
            // 
            this.chkFeFinSinc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFeFinSinc.AutoSize = true;
            this.chkFeFinSinc.Enabled = false;
            this.chkFeFinSinc.Location = new System.Drawing.Point(617, 3);
            this.chkFeFinSinc.Name = "chkFeFinSinc";
            this.chkFeFinSinc.Size = new System.Drawing.Size(200, 17);
            this.chkFeFinSinc.TabIndex = 2;
            this.chkFeFinSinc.Text = "Fecha fin sincronización";
            this.chkFeFinSinc.UseCustomBackColor = true;
            this.chkFeFinSinc.UseSelectable = true;
            this.chkFeFinSinc.CheckedChanged += new System.EventHandler(this.chkFeFinSinc_CheckedChanged);
            // 
            // dtFeInicioSinc
            // 
            this.dtFeInicioSinc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtFeInicioSinc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFeInicioSinc.Location = new System.Drawing.Point(411, 26);
            this.dtFeInicioSinc.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtFeInicioSinc.Name = "dtFeInicioSinc";
            this.tableLayoutPanel3.SetRowSpan(this.dtFeInicioSinc, 2);
            this.dtFeInicioSinc.Size = new System.Drawing.Size(200, 30);
            this.dtFeInicioSinc.TabIndex = 3;
            // 
            // dtFeFinSinc
            // 
            this.dtFeFinSinc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtFeFinSinc.Enabled = false;
            this.dtFeFinSinc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFeFinSinc.Location = new System.Drawing.Point(617, 26);
            this.dtFeFinSinc.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtFeFinSinc.Name = "dtFeFinSinc";
            this.tableLayoutPanel3.SetRowSpan(this.dtFeFinSinc, 2);
            this.dtFeFinSinc.Size = new System.Drawing.Size(200, 30);
            this.dtFeFinSinc.TabIndex = 3;
            // 
            // frmBitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBitacoras";
            this.Text = "frmBitacoras";
            this.Load += new System.EventHandler(this.frmBitacoras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvConsulta)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grvConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cmbRegistros;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnMenos;
        private MetroFramework.Controls.MetroButton btnMas;
        private MetroFramework.Controls.MetroLabel lblRegistroActual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox txtCriterioBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroCheckBox chkFeInicioSinc;
        private MetroFramework.Controls.MetroCheckBox chkFeFinSinc;
        private MetroFramework.Controls.MetroDateTime dtFeInicioSinc;
        private MetroFramework.Controls.MetroDateTime dtFeFinSinc;
    }
}