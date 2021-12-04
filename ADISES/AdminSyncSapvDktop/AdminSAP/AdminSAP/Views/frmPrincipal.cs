using AdminSAP.Utils;
using AdminSAP.Views.BitacorasVw;
using AdminSAP.Views.Credentials;
using SAP_LIB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSAP.Views
{
    public partial class frmPrincipal : Form
    {
        #region Variables
        #region Variables form
        int widthLayout = 0;
        int heightLayout = 0;
        bool maximize = true;

        public static string secConfiguracion = "Configuración", secBitacoras = "Bitácoras";
        public const string Inventarios = "Inventarios", Productos = "Productos", Parametros = "Parámetros", Credenciales = "Credenciales";
        Rectangle screenRect = new Rectangle();
        #endregion
        List<Secciones> lsSecciones = new List<Secciones>();
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
            widthLayout = Width;
            heightLayout = Height;
            screenRect = Screen.GetBounds(this.Bounds);
            screenRect = Screen.FromControl(this).Bounds;
            this.ClientSize = new System.Drawing.Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
            this.Location = new Point(Screen.FromControl(this).WorkingArea.Left, Screen.FromControl(this).WorkingArea.Top);
        }

        #region Configuracion form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //Controles.ConfigurarDisenio(new Control[] { this });
                this.ConfigureDesign();
                lsSecciones.Add(new Secciones
                {
                    nbSeccion = secConfiguracion,
                    lsModulos = new List<Modulos>()
                    {
                        new Modulos {nbModulo = Parametros },
                        new Modulos {nbModulo = Credenciales }
                    }
                
                });

                #region Obsoleto

                //lsSecciones.Add(new Secciones
                //{
                //    nbSeccion = secBitacoras,
                //    lsModulos = new List<Modulos>()
                //    {
                //        new Modulos {nbModulo = Inventarios },
                //        new Modulos {nbModulo = Productos }
                //    }
                //});
                #endregion

                CargarSecciones();
            }
            catch(Exception ex) { }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (maximize)
            {
                ClientSize = new Size(widthLayout, heightLayout); // set the size of the form
                ReallyCenterToScreen();
                //btn.Image = Properties.Resources.Maximize;
                maximize = false;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
                this.Location = new Point(Screen.FromControl(this).WorkingArea.Left, Screen.FromControl(this).WorkingArea.Top);
                //imgMaximize.Image = Properties.Resources.restore1;
                maximize = true;
            }
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        private void CargarSecciones()
        {
            if (this.lsSecciones != null && this.lsSecciones.Count() > 0)
            {
                foreach (var seccion in lsSecciones)
                {
                    Panel pnlSeccion = new Panel();
                    pnlSeccion.Name = $"pnl{seccion.nbSeccion}";
                    pnlSeccion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    pnlSeccion.Dock = DockStyle.Top;
                    pnlSeccion.Height = 1;
                    pnlSeccion.Visible = false;

                    if (seccion.lsModulos != null && seccion.lsModulos.Count() > 0)
                    {
                        foreach(var modulo in seccion.lsModulos)
                        {
                            Button btnModulo = new Button();
                            btnModulo.Name = $"btn{modulo.nbModulo}";
                            btnModulo.Width = pnlMenuVertical.Width;
                            btnModulo.Text = "  -   " + modulo.nbModulo;
                            //btnModulo.Font = new Font("Arial", 8);
                            btnModulo.FlatStyle = FlatStyle.Flat;
                            btnModulo.FlatAppearance.BorderSize = 0;
                            btnModulo.Padding = new Padding(10, 0, 0, 0);
                            btnModulo.Font = new Font("Century Gothic", 11.25F);
                            btnModulo.Dock = DockStyle.Top;
                            btnModulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                            btnModulo.BackColor = Utils.Utils.getInstance().BackColorToolBar;
                            btnModulo.ForeColor = Color.White;
                            btnModulo.MouseHover += BtnSection_MouseHover;
                            btnModulo.MouseLeave += BtnSection_MouseLeave;
                            btnModulo.Height = 55;
                            btnModulo.TextAlign = ContentAlignment.MiddleLeft;
                            btnModulo.TextImageRelation = TextImageRelation.ImageBeforeText;
                            btnModulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);

                            btnModulo.Click += BtnModulo_Click;

                            pnlSeccion.Controls.Add(btnModulo);
                        }
                    }
                    pnlSeccion.Height = pnlSeccion.Controls.OfType<Control>().ToList().Sum(x => x.Height);
                    pnlMenuVertical.Controls.Add(pnlSeccion);


                    Button btnSection = new Button();
                    btnSection.Name = $"btn{seccion.nbSeccion}";
                    btnSection.Width = pnlMenuVertical.Width;
                    btnSection.Text = seccion.nbSeccion;
                    btnSection.FlatStyle = FlatStyle.Flat;
                    btnSection.FlatAppearance.BorderSize = 0;
                    btnSection.Padding = new Padding(10, 0, 0, 0);
                    btnSection.Font = new Font("Century Gothic", 11.25F);
                    btnSection.Dock = DockStyle.Top;
                    btnSection.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    btnSection.BackColor = Utils.Utils.getInstance().BackColorToolBar;
                    btnSection.ForeColor = Color.White;
                    btnSection.MouseHover += BtnSection_MouseHover;
                    btnSection.MouseLeave += BtnSection_MouseLeave;
                    btnSection.Click += BtnSection_Click;
                    btnSection.Height = 55;
                    btnSection.TextAlign = ContentAlignment.MiddleLeft;
                    btnSection.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnSection.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
                    pnlMenuVertical.Controls.Add(btnSection);
                }



                //foreach(var seccion in lsSecciones)
                //{
                //    Button btnSection = new Button();
                //    btnSection.Name = $"btn{seccion.nbSeccion}";
                //    btnSection.Width = pnlMenuVertical.Width;
                //    btnSection.Text = seccion.nbSeccion;
                //    btnSection.FlatStyle = FlatStyle.Flat;
                //    btnSection.FlatAppearance.BorderSize = 0;
                //    btnSection.Padding = new Padding(10, 0, 0, 0);
                //    btnSection.Font = new Font("Century Gothic", 11.25F);
                //    btnSection.Dock = DockStyle.Top;
                //    btnSection.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                //    btnSection.BackColor = Utils.Utils.getInstance().BackColorToolBar;
                //    btnSection.ForeColor = Color.White;
                //    btnSection.MouseHover += BtnSection_MouseHover;
                //    btnSection.MouseLeave += BtnSection_MouseLeave;
                //    btnSection.Click += BtnSection_Click;
                //    btnSection.Height = 55;
                //    btnSection.TextAlign = ContentAlignment.MiddleLeft;
                //    btnSection.TextImageRelation = TextImageRelation.ImageBeforeText;
                //    btnSection.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
                //    pnlMenuVertical.Controls.Add(btnSection);
                //}
            }
        }

        private void BtnModulo_Click(object sender, EventArgs e)
        {
            try
            {
                switch (((Button)sender).Text.Trim(new char[] { ' ', '-', ' '}))
                {
                    case Parametros:
                        frmConfiguracion frmConfiguracion = new frmConfiguracion();
                        frmConfiguracion.MdiParent = this;
                        frmConfiguracion.Dock = DockStyle.Fill;
                        frmConfiguracion.Show();
                        break;
                    case Productos:
                        frmProductos frmBitacora = new frmProductos();
                        frmBitacora.MdiParent = this;
                        frmBitacora.Dock = DockStyle.Fill;
                        frmBitacora.Show();
                        break;
                    case Inventarios:
                        frmInventarios frmBitacoraInv = new frmInventarios();
                        frmBitacoraInv.MdiParent = this;
                        frmBitacoraInv.Dock = DockStyle.Fill;
                        frmBitacoraInv.Show();
                        break;
                    case Credenciales:
                        frmCredenciales credencialesFrm = new frmCredenciales();
                        credencialesFrm.MdiParent = this;
                        credencialesFrm.Dock = DockStyle.Fill;
                        credencialesFrm.Show();
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void BtnSection_MouseLeave(object sender, EventArgs e)
        {
            //((Button)sender).ForeColor = Utils.Utils.getInstance().fo;
        }

        private void BtnSection_MouseHover(object sender, EventArgs e)
        {
            //((Button)sender).ForeColor = Controles.foreColorLight;
        }

        private void BtnSection_Click(object sender, EventArgs e)
        {
            try
            {
                //switch (((Button)sender).Text.Trim())
                //{
                //    case "Configuración":
                //        frmConfiguracion frmConfiguracion = new frmConfiguracion();
                //        frmConfiguracion.MdiParent = this;
                //        frmConfiguracion.Dock = DockStyle.Fill;
                //        frmConfiguracion.Show();
                //        break;
                //    case "Bitácoras":
                //        frmBitacoras frmBitacora = new frmBitacoras();
                //        frmBitacora.MdiParent = this;
                //        frmBitacora.Dock = DockStyle.Fill;
                //        frmBitacora.Show();
                //        break;
                //}

                AbrisSubMenu(pnlMenuVertical.Controls.OfType<Panel>().FirstOrDefault(x => x.Name == $"pnl{((Button)sender).Name.ToString().Replace("btn", "")}"));

            }
            catch (Exception ex) { }
        }

        #region Configuracion Sub Menu

        private void AbrisSubMenu(Panel panel)
        {

            if (!panel.Visible)
            {
                ocultarSubMenu();

                panel.Visible = true;

            }
            else
                panel.Visible = false;
        }

        private void ocultarSubMenu()
        {
            var lsPaneles = pnlMenuVertical.Controls.OfType<Panel>().ToList();
            if (lsPaneles != null && lsPaneles.Count() > 0)
            {
                foreach (var panel in lsPaneles)
                {
                    if (panel.Visible)
                        panel.Visible = false;
                    if (panel.Visible)
                        panel.Visible = false;
                }
            }

        }

        #endregion

        #endregion

    }
}
