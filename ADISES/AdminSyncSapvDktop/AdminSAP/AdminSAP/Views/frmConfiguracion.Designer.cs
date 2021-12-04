namespace AdminSAP.Views
{
    partial class frmConfiguracion
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
            this.lblCerrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new MetroFramework.Controls.MetroTextBox();
            this.chkProductos = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chkReglasPrecio = new System.Windows.Forms.CheckBox();
            this.chkLeads = new System.Windows.Forms.CheckBox();
            this.chkClientes = new System.Windows.Forms.CheckBox();
            this.chkPedidos = new System.Windows.Forms.CheckBox();
            this.chkTipoCambio = new System.Windows.Forms.CheckBox();
            this.chkSincronizar = new System.Windows.Forms.CheckBox();
            this.txtReglaPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtLeads = new MetroFramework.Controls.MetroTextBox();
            this.txtClientes = new MetroFramework.Controls.MetroTextBox();
            this.txtPedidos = new MetroFramework.Controls.MetroTextBox();
            this.txtTipoCambio = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTiempo = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rdtSeconds = new System.Windows.Forms.RadioButton();
            this.rdtMinutos = new System.Windows.Forms.RadioButton();
            this.grvConsulta = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvConsulta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(1027, 4);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(27, 25);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(1064, 638);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtQuery, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 37);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1056, 597);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(880, 570);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 25);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Aceptar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(968, 570);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 25);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtQuery, 2);
            this.txtQuery.Location = new System.Drawing.Point(2, 572);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(874, 20);
            this.txtQuery.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.grvConsulta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 564);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1052, 271);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración de módulos";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtProducto, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.chkProductos, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label14, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.label15, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.chkReglasPrecio, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.chkLeads, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.chkClientes, 2, 7);
            this.tableLayoutPanel5.Controls.Add(this.chkPedidos, 2, 9);
            this.tableLayoutPanel5.Controls.Add(this.chkTipoCambio, 2, 11);
            this.tableLayoutPanel5.Controls.Add(this.chkSincronizar, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtReglaPrecio, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtLeads, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtClientes, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.txtPedidos, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.txtTipoCambio, 1, 11);
            this.tableLayoutPanel5.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 11);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 12;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1048, 254);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rango de registros";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtProducto.CustomButton.Image = null;
            this.txtProducto.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtProducto.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProducto.CustomButton.Name = "";
            this.txtProducto.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProducto.CustomButton.TabIndex = 1;
            this.txtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProducto.CustomButton.UseSelectable = true;
            this.txtProducto.CustomButton.Visible = false;
            this.txtProducto.Lines = new string[0];
            this.txtProducto.Location = new System.Drawing.Point(96, 23);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.ShortcutsEnabled = true;
            this.txtProducto.Size = new System.Drawing.Size(221, 24);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.UseSelectable = true;
            this.txtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkProductos
            // 
            this.chkProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkProductos.AutoSize = true;
            this.chkProductos.Location = new System.Drawing.Point(321, 28);
            this.chkProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkProductos.Name = "chkProductos";
            this.chkProductos.Size = new System.Drawing.Size(15, 14);
            this.chkProductos.TabIndex = 4;
            this.chkProductos.UseVisualStyleBackColor = true;
            this.chkProductos.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Rango de registros";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Rango de registros";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 172);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Rango de registros";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 213);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Rango de registros";
            // 
            // chkReglasPrecio
            // 
            this.chkReglasPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkReglasPrecio.AutoSize = true;
            this.chkReglasPrecio.Location = new System.Drawing.Point(321, 69);
            this.chkReglasPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkReglasPrecio.Name = "chkReglasPrecio";
            this.chkReglasPrecio.Size = new System.Drawing.Size(15, 14);
            this.chkReglasPrecio.TabIndex = 4;
            this.chkReglasPrecio.UseVisualStyleBackColor = true;
            this.chkReglasPrecio.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkLeads
            // 
            this.chkLeads.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLeads.AutoSize = true;
            this.chkLeads.Location = new System.Drawing.Point(321, 110);
            this.chkLeads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLeads.Name = "chkLeads";
            this.chkLeads.Size = new System.Drawing.Size(15, 14);
            this.chkLeads.TabIndex = 4;
            this.chkLeads.UseVisualStyleBackColor = true;
            this.chkLeads.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkClientes
            // 
            this.chkClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkClientes.AutoSize = true;
            this.chkClientes.Location = new System.Drawing.Point(321, 151);
            this.chkClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkClientes.Name = "chkClientes";
            this.chkClientes.Size = new System.Drawing.Size(15, 14);
            this.chkClientes.TabIndex = 4;
            this.chkClientes.UseVisualStyleBackColor = true;
            this.chkClientes.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkPedidos
            // 
            this.chkPedidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPedidos.AutoSize = true;
            this.chkPedidos.Location = new System.Drawing.Point(321, 192);
            this.chkPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPedidos.Name = "chkPedidos";
            this.chkPedidos.Size = new System.Drawing.Size(15, 14);
            this.chkPedidos.TabIndex = 4;
            this.chkPedidos.UseVisualStyleBackColor = true;
            this.chkPedidos.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkTipoCambio
            // 
            this.chkTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTipoCambio.AutoSize = true;
            this.chkTipoCambio.Location = new System.Drawing.Point(321, 233);
            this.chkTipoCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTipoCambio.Name = "chkTipoCambio";
            this.chkTipoCambio.Size = new System.Drawing.Size(15, 14);
            this.chkTipoCambio.TabIndex = 4;
            this.chkTipoCambio.UseVisualStyleBackColor = true;
            this.chkTipoCambio.Click += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkSincronizar
            // 
            this.chkSincronizar.AutoSize = true;
            this.chkSincronizar.Location = new System.Drawing.Point(321, 2);
            this.chkSincronizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSincronizar.Name = "chkSincronizar";
            this.chkSincronizar.Size = new System.Drawing.Size(102, 17);
            this.chkSincronizar.TabIndex = 4;
            this.chkSincronizar.Text = "Sincronizar todo";
            this.chkSincronizar.UseVisualStyleBackColor = true;
            this.chkSincronizar.Click += new System.EventHandler(this.chkSincronizar_Click);
            // 
            // txtReglaPrecio
            // 
            this.txtReglaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtReglaPrecio.CustomButton.Image = null;
            this.txtReglaPrecio.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtReglaPrecio.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReglaPrecio.CustomButton.Name = "";
            this.txtReglaPrecio.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtReglaPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReglaPrecio.CustomButton.TabIndex = 1;
            this.txtReglaPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReglaPrecio.CustomButton.UseSelectable = true;
            this.txtReglaPrecio.CustomButton.Visible = false;
            this.txtReglaPrecio.Lines = new string[0];
            this.txtReglaPrecio.Location = new System.Drawing.Point(96, 64);
            this.txtReglaPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReglaPrecio.MaxLength = 32767;
            this.txtReglaPrecio.Name = "txtReglaPrecio";
            this.txtReglaPrecio.PasswordChar = '\0';
            this.txtReglaPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReglaPrecio.SelectedText = "";
            this.txtReglaPrecio.SelectionLength = 0;
            this.txtReglaPrecio.SelectionStart = 0;
            this.txtReglaPrecio.ShortcutsEnabled = true;
            this.txtReglaPrecio.Size = new System.Drawing.Size(221, 24);
            this.txtReglaPrecio.TabIndex = 3;
            this.txtReglaPrecio.UseSelectable = true;
            this.txtReglaPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReglaPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLeads
            // 
            this.txtLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLeads.CustomButton.Image = null;
            this.txtLeads.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtLeads.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLeads.CustomButton.Name = "";
            this.txtLeads.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtLeads.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLeads.CustomButton.TabIndex = 1;
            this.txtLeads.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLeads.CustomButton.UseSelectable = true;
            this.txtLeads.CustomButton.Visible = false;
            this.txtLeads.Lines = new string[0];
            this.txtLeads.Location = new System.Drawing.Point(96, 105);
            this.txtLeads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLeads.MaxLength = 32767;
            this.txtLeads.Name = "txtLeads";
            this.txtLeads.PasswordChar = '\0';
            this.txtLeads.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLeads.SelectedText = "";
            this.txtLeads.SelectionLength = 0;
            this.txtLeads.SelectionStart = 0;
            this.txtLeads.ShortcutsEnabled = true;
            this.txtLeads.Size = new System.Drawing.Size(221, 24);
            this.txtLeads.TabIndex = 3;
            this.txtLeads.UseSelectable = true;
            this.txtLeads.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLeads.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientes
            // 
            this.txtClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtClientes.CustomButton.Image = null;
            this.txtClientes.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtClientes.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientes.CustomButton.Name = "";
            this.txtClientes.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtClientes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientes.CustomButton.TabIndex = 1;
            this.txtClientes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientes.CustomButton.UseSelectable = true;
            this.txtClientes.CustomButton.Visible = false;
            this.txtClientes.Lines = new string[0];
            this.txtClientes.Location = new System.Drawing.Point(96, 146);
            this.txtClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientes.MaxLength = 32767;
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.PasswordChar = '\0';
            this.txtClientes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientes.SelectedText = "";
            this.txtClientes.SelectionLength = 0;
            this.txtClientes.SelectionStart = 0;
            this.txtClientes.ShortcutsEnabled = true;
            this.txtClientes.Size = new System.Drawing.Size(221, 24);
            this.txtClientes.TabIndex = 3;
            this.txtClientes.UseSelectable = true;
            this.txtClientes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPedidos
            // 
            this.txtPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPedidos.CustomButton.Image = null;
            this.txtPedidos.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtPedidos.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPedidos.CustomButton.Name = "";
            this.txtPedidos.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPedidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPedidos.CustomButton.TabIndex = 1;
            this.txtPedidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPedidos.CustomButton.UseSelectable = true;
            this.txtPedidos.CustomButton.Visible = false;
            this.txtPedidos.Lines = new string[0];
            this.txtPedidos.Location = new System.Drawing.Point(96, 187);
            this.txtPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPedidos.MaxLength = 32767;
            this.txtPedidos.Name = "txtPedidos";
            this.txtPedidos.PasswordChar = '\0';
            this.txtPedidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPedidos.SelectedText = "";
            this.txtPedidos.SelectionLength = 0;
            this.txtPedidos.SelectionStart = 0;
            this.txtPedidos.ShortcutsEnabled = true;
            this.txtPedidos.Size = new System.Drawing.Size(221, 24);
            this.txtPedidos.TabIndex = 3;
            this.txtPedidos.UseSelectable = true;
            this.txtPedidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPedidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTipoCambio.CustomButton.Image = null;
            this.txtTipoCambio.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtTipoCambio.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoCambio.CustomButton.Name = "";
            this.txtTipoCambio.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtTipoCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipoCambio.CustomButton.TabIndex = 1;
            this.txtTipoCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipoCambio.CustomButton.UseSelectable = true;
            this.txtTipoCambio.CustomButton.Visible = false;
            this.txtTipoCambio.Lines = new string[0];
            this.txtTipoCambio.Location = new System.Drawing.Point(96, 228);
            this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoCambio.MaxLength = 32767;
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.PasswordChar = '\0';
            this.txtTipoCambio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoCambio.SelectedText = "";
            this.txtTipoCambio.SelectionLength = 0;
            this.txtTipoCambio.SelectionStart = 0;
            this.txtTipoCambio.ShortcutsEnabled = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(221, 24);
            this.txtTipoCambio.TabIndex = 3;
            this.txtTipoCambio.UseSelectable = true;
            this.txtTipoCambio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipoCambio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rango de registros";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Productos:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reglas de precio:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Leads:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Clientes:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pedidos:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tipo de cambio:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1052, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuraciones generales";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.txtTiempo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1048, 41);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTiempo.CustomButton.Image = null;
            this.txtTiempo.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.txtTiempo.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTiempo.CustomButton.Name = "";
            this.txtTiempo.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtTiempo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTiempo.CustomButton.TabIndex = 1;
            this.txtTiempo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTiempo.CustomButton.UseSelectable = true;
            this.txtTiempo.CustomButton.Visible = false;
            this.txtTiempo.Lines = new string[0];
            this.txtTiempo.Location = new System.Drawing.Point(2, 15);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTiempo.MaxLength = 32767;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.PasswordChar = '\0';
            this.txtTiempo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTiempo.SelectedText = "";
            this.txtTiempo.SelectionLength = 0;
            this.txtTiempo.SelectionStart = 0;
            this.txtTiempo.ShortcutsEnabled = true;
            this.txtTiempo.Size = new System.Drawing.Size(345, 24);
            this.txtTiempo.TabIndex = 3;
            this.txtTiempo.UseSelectable = true;
            this.txtTiempo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTiempo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo de descanso";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intérvalo en";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rdtSeconds, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdtMinutos, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(351, 15);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 21);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // rdtSeconds
            // 
            this.rdtSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdtSeconds.AutoSize = true;
            this.rdtSeconds.Location = new System.Drawing.Point(2, 2);
            this.rdtSeconds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdtSeconds.Name = "rdtSeconds";
            this.rdtSeconds.Size = new System.Drawing.Size(168, 17);
            this.rdtSeconds.TabIndex = 4;
            this.rdtSeconds.TabStop = true;
            this.rdtSeconds.Text = "Segundos";
            this.rdtSeconds.UseVisualStyleBackColor = true;
            // 
            // rdtMinutos
            // 
            this.rdtMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdtMinutos.AutoSize = true;
            this.rdtMinutos.Location = new System.Drawing.Point(174, 2);
            this.rdtMinutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdtMinutos.Name = "rdtMinutos";
            this.rdtMinutos.Size = new System.Drawing.Size(169, 17);
            this.rdtMinutos.TabIndex = 4;
            this.rdtMinutos.TabStop = true;
            this.rdtMinutos.Text = "Minutos";
            this.rdtMinutos.UseVisualStyleBackColor = true;
            // 
            // grvConsulta
            // 
            this.grvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvConsulta.Location = new System.Drawing.Point(1016, 552);
            this.grvConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvConsulta.Name = "grvConsulta";
            this.grvConsulta.RowTemplate.Height = 24;
            this.grvConsulta.Size = new System.Drawing.Size(31, 10);
            this.grvConsulta.TabIndex = 1;
            this.grvConsulta.Visible = false;
            this.grvConsulta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvConsulta_CellPainting);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 33);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1021, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "     Configuración de parámetros";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvConsulta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grvConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rdtSeconds;
        private System.Windows.Forms.RadioButton rdtMinutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtProducto;
        private System.Windows.Forms.CheckBox chkProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkReglasPrecio;
        private System.Windows.Forms.CheckBox chkLeads;
        private System.Windows.Forms.CheckBox chkClientes;
        private System.Windows.Forms.CheckBox chkPedidos;
        private System.Windows.Forms.CheckBox chkTipoCambio;
        private System.Windows.Forms.CheckBox chkSincronizar;
        private MetroFramework.Controls.MetroTextBox txtReglaPrecio;
        private MetroFramework.Controls.MetroTextBox txtLeads;
        private MetroFramework.Controls.MetroTextBox txtClientes;
        private MetroFramework.Controls.MetroTextBox txtPedidos;
        private MetroFramework.Controls.MetroTextBox txtTipoCambio;
        private System.Windows.Forms.Label label6;
    }
}