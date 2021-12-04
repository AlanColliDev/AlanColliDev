using AdminSAP.Utils;
using MySql.Data.MySqlClient;
using Sap.Data.Hana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AdminSAP.Modules;

namespace AdminSAP.Views.Credentials
{
    public partial class frmCredenciales : Form
    {
        string ruta = @"C:\Program Files (x86)\Adises\";
        string rutacompleta = @"C:\Program Files (x86)\Adises\credenciales.xml";
        private MySqlConnection conexion;
        private HanaConnection hanaConnection;
        public frmCredenciales()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCredenciales_Load(object sender, EventArgs e)
        {
            this.ConfigureDesign();
            txtDirectorio.Text = rutacompleta;
            Controles.EnableControls(new Control[] { txtDirectorio }, false);

            ReadXML();
            txtBaseDatos.Focus();
        }


        private bool validateField()
        {
            string requeridos = string.Empty;
            string requeridosMysql = string.Empty;
            string requeridosAPI = string.Empty;
            string requeridosDIAPI = string.Empty;

            //if (string.IsNullOrEmpty(txtDirectorio.Text.Trim())) { }
            //    requeridos += "Directorio";

            if (string.IsNullOrEmpty(txtServidor.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Servidor";

            if (string.IsNullOrEmpty(txtBaseDatos.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Base de datos primaria";

            if (string.IsNullOrEmpty(txtBdBit.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Base de datos de bitácoras";

            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Usuario";

            if (string.IsNullOrEmpty(txtContrasenia.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Contraseña";


            if (string.IsNullOrEmpty(txtServidorMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Servidor";

            if (string.IsNullOrEmpty(txtBaseDatosMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Base de datos";

            if (string.IsNullOrEmpty(txtUsuarioMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Usuario";

            if (string.IsNullOrEmpty(txtContraseniaMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Contraseña";

            if (string.IsNullOrEmpty(txtUrl.Text))
                requeridosAPI += $"{(string.IsNullOrEmpty(requeridosAPI) ? "" : ", ")}Dirección Url";

            if (string.IsNullOrEmpty(txtCvCliente.Text))
                requeridosAPI += $"{(string.IsNullOrEmpty(requeridosAPI) ? "" : ", ")}Clave de usuario";

            if (string.IsNullOrEmpty(txtCvSecreta.Text))
                requeridosAPI += $"{(string.IsNullOrEmpty(requeridosAPI) ? "" : ", ")}Clave secreta";

            //CREDENCIALES DISERVER
            if (string.IsNullOrEmpty(txtUrlDiserver.Text))
                requeridosDIAPI += $"{(string.IsNullOrEmpty(requeridosAPI) ? "" : ", ")}Dirección Url DISERVER";

            if (string.IsNullOrEmpty(txtTokenDiserver.Text))
                requeridosDIAPI += $"{(string.IsNullOrEmpty(requeridosAPI) ? "" : ", ")}Token";

        

            string msg = string.Empty;
            if (!string.IsNullOrEmpty(requeridos))
            {
                msg += "Credenciales SAP \n";

                if (requeridos.Any(x => x == ','))
                    msg += $"* Los campos {requeridos} son requeridos. \n\n";
                else
                    msg += $"* El campo {requeridos} es requerido.\n\n";

            }

            if (!string.IsNullOrEmpty(requeridosMysql))
            {
                msg += "Credenciales WooCommerce \n";

                if (requeridosMysql.Any(x => x == ','))
                    msg += $"* Los campos {requeridosMysql} son requeridos.\n\n";
                else
                    msg += $"* El campo {requeridosMysql} es requerido. \n\n";

            }

            if (!string.IsNullOrEmpty(requeridosAPI))
            {
                msg += "Credenciales REST API Woocommerce\n";

                if (requeridosAPI.Any(x => x == ','))
                    msg += $"* Los campos {requeridosAPI} son requeridos.";
                else
                    msg += $"* El campo {requeridosAPI} es requerido.";
            }

            if (!string.IsNullOrEmpty(requeridosDIAPI))
            {
                msg += "Credenciales DISERVER API\n";

                if (requeridosDIAPI.Any(x => x == ','))
                    msg += $"* Los campos {requeridosDIAPI} son requeridos.";
                else
                    msg += $"* El campo {requeridosDIAPI} es requerido.";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }

        private bool validateFieldSAP()
        {
            string requeridos = string.Empty;

            if (string.IsNullOrEmpty(txtServidor.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Servidor";

            if (string.IsNullOrEmpty(txtBaseDatos.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Base de datos primaria";

            if (string.IsNullOrEmpty(txtBdBit.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Base de datos de bitácoras";

            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Usuario";

            if (string.IsNullOrEmpty(txtContrasenia.Text.Trim()))
                requeridos += $"{(string.IsNullOrEmpty(requeridos) ? "" : ", ")}Contraseña";

            string msg = string.Empty;
            if (!string.IsNullOrEmpty(requeridos))
            {
                msg += "Credenciales SAP \n";

                if (requeridos.Any(x => x == ','))
                    msg += $"* Los campos {requeridos} son requeridos. \n\n";
                else
                    msg += $"* El campo {requeridos} es requerido.\n\n";

            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }



        private bool validateFieldDIAPI()
        {
            string requeridosDIAPI = string.Empty;

            if (string.IsNullOrEmpty(txtUrlDiserver.Text))
                requeridosDIAPI += $"{(string.IsNullOrEmpty(requeridosDIAPI) ? "" : ", ")}Dirección Url DISERVER";

            if (string.IsNullOrEmpty(txtTokenDiserver.Text))
                requeridosDIAPI += $"{(string.IsNullOrEmpty(requeridosDIAPI) ? "" : ", ")}Token";
            string msg = string.Empty;

            if (!string.IsNullOrEmpty(requeridosDIAPI))
            {
                msg += "Credenciales DISERVER API\n";

                if (requeridosDIAPI.Any(x => x == ','))
                    msg += $"* Los campos {requeridosDIAPI} son requeridos. \n\n";
                else
                    msg += $"* El campo {requeridosDIAPI} es requerido.\n\n";

            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }
        private bool validateFieldMysql()
        {
            string requeridosMysql = string.Empty;


            if (string.IsNullOrEmpty(txtServidorMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Servidor";

            if (string.IsNullOrEmpty(txtBaseDatosMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Base de datos";

            if (string.IsNullOrEmpty(txtUsuarioMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Usuario";

            if (string.IsNullOrEmpty(txtContraseniaMysql.Text.Trim()))
                requeridosMysql += $"{(string.IsNullOrEmpty(requeridosMysql) ? "" : ", ")}Contraseña";

            string msg = string.Empty;

            if (!string.IsNullOrEmpty(requeridosMysql))
            {
                msg += "Credenciales WooCommerce \n";

                if (requeridosMysql.Any(x => x == ','))
                    msg += $"* Los campos {requeridosMysql} son requeridos.";
                else
                    msg += $"* El campo {requeridosMysql} es requerido.";

            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }

        private void btnProbarConexión_Click(object sender, EventArgs e)
        {
            if (validateFieldSAP())
                if (OpenConnectionSAP())
                    CloseConnectionSAP();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validateField())
            {
                CreateXML2();
            }
        }

        private void CreateXML()
        {
            try
            {
                if (Directory.Exists(ruta)) // Revisar si existe el directorio
                {
                    if (File.Exists(rutacompleta))
                        File.Delete(rutacompleta); // borrarlo

                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);
                    XmlElement cuerpo = doc.CreateElement(string.Empty, "credenciales", string.Empty);
                    doc.AppendChild(cuerpo);

                    XmlElement nodeServidor = doc.CreateElement(string.Empty, "Servidor", string.Empty);
                    cuerpo.AppendChild(nodeServidor);
                    XmlText Servidor = doc.CreateTextNode(txtServidor.Text.Trim());
                    nodeServidor.AppendChild(Servidor);

                    XmlElement nodeBaseDatos = doc.CreateElement(string.Empty, "BaseDatos", string.Empty);
                    cuerpo.AppendChild(nodeBaseDatos);
                    XmlText BaseDatos = doc.CreateTextNode(txtBaseDatos.Text.Trim());
                    nodeBaseDatos.AppendChild(BaseDatos);

                    XmlElement nodeUsuario = doc.CreateElement(string.Empty, "Usuario", string.Empty);
                    cuerpo.AppendChild(nodeUsuario);
                    XmlText Usuario = doc.CreateTextNode(txtUsuario.Text.Trim());
                    nodeUsuario.AppendChild(Usuario);

                    XmlElement nodeContrasenia = doc.CreateElement(string.Empty, "Contraseña", string.Empty);
                    cuerpo.AppendChild(nodeContrasenia);
                    XmlText Contrasenia = doc.CreateTextNode(txtContrasenia.Text.Trim());
                    nodeContrasenia.AppendChild(Contrasenia);

                    doc.Save(rutacompleta);

                    MessageBox.Show("Operación realizada con éxito.");
                }
                else
                {
                    MessageBox.Show($"No se encontró el directorio {ruta}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void CreateXML2()
        {
            try
            {
                if (Directory.Exists(ruta)) // Revisar si existe el directorio
                {
                    if (File.Exists(rutacompleta))
                        File.Delete(rutacompleta); // borrarlo

                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);
                    XmlElement cuerpo = doc.CreateElement(string.Empty, "credenciales", string.Empty);
                    doc.AppendChild(cuerpo);

                    XmlElement nodeSAP = doc.CreateElement(string.Empty, "SAP", string.Empty);
                    cuerpo.AppendChild(nodeSAP);

                    XmlElement nodeServidor = doc.CreateElement(string.Empty, "Servidor", string.Empty);
                    nodeSAP.AppendChild(nodeServidor);
                    XmlText Servidor = doc.CreateTextNode(txtServidor.Text.Trim());
                    nodeServidor.AppendChild(Servidor);

                    XmlElement nodeBaseDatos = doc.CreateElement(string.Empty, "BaseDatosPrimaria", string.Empty);
                    nodeSAP.AppendChild(nodeBaseDatos);
                    XmlText BaseDatos = doc.CreateTextNode(txtBaseDatos.Text.Trim());
                    nodeBaseDatos.AppendChild(BaseDatos);

                    XmlElement nodeBaseDatosBit = doc.CreateElement(string.Empty, "BaseDatosBitacoras", string.Empty);
                    nodeSAP.AppendChild(nodeBaseDatosBit);
                    XmlText BaseDatosBit = doc.CreateTextNode(txtBdBit.Text.Trim());
                    nodeBaseDatosBit.AppendChild(BaseDatosBit);

                    XmlElement nodeUsuario = doc.CreateElement(string.Empty, "Usuario", string.Empty);
                    nodeSAP.AppendChild(nodeUsuario);
                    XmlText Usuario = doc.CreateTextNode(txtUsuario.Text.Trim());
                    nodeUsuario.AppendChild(Usuario);

                    XmlElement nodeContrasenia = doc.CreateElement(string.Empty, "Contraseña", string.Empty);
                    nodeSAP.AppendChild(nodeContrasenia);
                    XmlText Contrasenia = doc.CreateTextNode(txtContrasenia.Text.Trim());
                    nodeContrasenia.AppendChild(Contrasenia);


                    XmlElement nodeWooCommerce = doc.CreateElement(string.Empty, "WooCommerce", string.Empty);
                    cuerpo.AppendChild(nodeWooCommerce);

                    XmlElement nodeServidormysql = doc.CreateElement(string.Empty, "Servidor", string.Empty);
                    nodeWooCommerce.AppendChild(nodeServidormysql);
                    XmlText ServidorMySql = doc.CreateTextNode(txtServidorMysql.Text.Trim());
                    nodeServidormysql.AppendChild(ServidorMySql);

                    XmlElement nodeBaseDatosMysql = doc.CreateElement(string.Empty, "BaseDatos", string.Empty);
                    nodeWooCommerce.AppendChild(nodeBaseDatosMysql);
                    XmlText BaseDatosMysql = doc.CreateTextNode(txtBaseDatosMysql.Text.Trim());
                    nodeBaseDatosMysql.AppendChild(BaseDatosMysql);

                    XmlElement nodeUsuarioMysql = doc.CreateElement(string.Empty, "Usuario", string.Empty);
                    nodeWooCommerce.AppendChild(nodeUsuarioMysql);
                    XmlText UsuarioMysql = doc.CreateTextNode(txtUsuarioMysql.Text.Trim());
                    nodeUsuarioMysql.AppendChild(UsuarioMysql);

                    XmlElement nodeContraseniaMysql = doc.CreateElement(string.Empty, "Contraseña", string.Empty);
                    nodeWooCommerce.AppendChild(nodeContraseniaMysql);
                    XmlText ContraseniaMysql = doc.CreateTextNode(txtContraseniaMysql.Text.Trim());
                    nodeContraseniaMysql.AppendChild(ContraseniaMysql);


                    XmlElement ApiRest = doc.CreateElement(string.Empty, "RestApi", string.Empty);
                    cuerpo.AppendChild(ApiRest);

                    XmlElement nodeUrlApi = doc.CreateElement(string.Empty, "UrlApi", string.Empty);
                    ApiRest.AppendChild(nodeUrlApi);
                    XmlText UrlApi = doc.CreateTextNode(txtUrl.Text.Trim());
                    nodeUrlApi.AppendChild(UrlApi);

                    XmlElement nodeClaveUsuario = doc.CreateElement(string.Empty, "ClaveCliente", string.Empty);
                    ApiRest.AppendChild(nodeClaveUsuario);
                    XmlText ClaveCliente = doc.CreateTextNode(txtCvCliente.Text.Trim());
                    nodeClaveUsuario.AppendChild(ClaveCliente);

                    XmlElement nodeClaveSecreta = doc.CreateElement(string.Empty, "ClaveSecreta", string.Empty);
                    ApiRest.AppendChild(nodeClaveSecreta);
                    XmlText ClaveSecreta = doc.CreateTextNode(txtCvSecreta.Text.Trim());
                    nodeClaveSecreta.AppendChild(ClaveSecreta);


                    //NODO DISERVERAPI
                    XmlElement DIServerAPI = doc.CreateElement(string.Empty, "DIServerAPI", string.Empty);
                    cuerpo.AppendChild(DIServerAPI);

                    XmlElement nodeUrlDIApi = doc.CreateElement(string.Empty, "UrlDIApi", string.Empty);
                    DIServerAPI.AppendChild(nodeUrlDIApi);
                    XmlText UrlDIApi = doc.CreateTextNode(txtUrlDiserver.Text.Trim());
                    nodeUrlDIApi.AppendChild(UrlDIApi);

                    XmlElement nodeTokenDiAPI = doc.CreateElement(string.Empty, "TokenDIApi", string.Empty);
                    DIServerAPI.AppendChild(nodeTokenDiAPI);
                    XmlText TokenDIApi = doc.CreateTextNode(txtTokenDiserver.Text.Trim());
                    nodeTokenDiAPI.AppendChild(TokenDIApi);

                    //XmlElement nodeSessionDIAPI = doc.CreateElement(string.Empty, "SessionDIAPI", string.Empty);
                    //DIServerAPI.AppendChild(nodeSessionDIAPI);
                    //XmlText SessionDIAPI = doc.CreateTextNode(txtSessionIdDiserver.Text.Trim());
                    //nodeSessionDIAPI.AppendChild(SessionDIAPI);

                    doc.Save(rutacompleta);

                    MessageBox.Show("Operación realizada con éxito.");
                }
                else
                {
                    MessageBox.Show($"No se encontró el directorio {ruta}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void ReadXML()
        {
            try
            {
                if (!Directory.Exists(ruta)) // Revisar si existe el directorio
                    return;
                
                if (!File.Exists(rutacompleta)) // Revisar si existe el archivo
                    return;

                XDocument xml = XDocument.Load(rutacompleta, LoadOptions.None);

                XElement credenciales = xml.Element("credenciales");
                XElement credencialesSAP = credenciales.Element("SAP");
                string servidorSAP = credencialesSAP.Element("Servidor").Value;
                string BaseDatosSAP = credencialesSAP.Element("BaseDatosPrimaria").Value;
                string BaseDatosSAPBit = credencialesSAP.Element("BaseDatosBitacoras").Value;
                string UsuarioSAP = credencialesSAP.Element("Usuario").Value;
                string ContraseniaSAP = credencialesSAP.Element("Contraseña").Value;

                txtBaseDatos.Text = BaseDatosSAP;
                txtBdBit.Text = BaseDatosSAPBit;
                txtServidor.Text = servidorSAP;
                txtUsuario.Text = UsuarioSAP;
                txtContrasenia.Text = ContraseniaSAP;

                XElement credencialesMysql = credenciales.Element("WooCommerce");
                string servidorMysql = credencialesMysql.Element("Servidor").Value;
                string BaseDatoMysql = credencialesMysql.Element("BaseDatos").Value;
                string UsuarioMysql = credencialesMysql.Element("Usuario").Value;
                string ContraseniaMysql = credencialesMysql.Element("Contraseña").Value;

                txtBaseDatosMysql.Text = BaseDatoMysql;
                txtServidorMysql.Text = servidorMysql;
                txtUsuarioMysql.Text = UsuarioMysql;
                txtContraseniaMysql.Text = ContraseniaMysql;

                XElement credencialesRestApi = credenciales.Element("RestApi");

                string url = credencialesRestApi.Element("UrlApi").Value;
                string ClaveCliente = credencialesRestApi.Element("ClaveCliente").Value;
                string ClaveSecreta = credencialesRestApi.Element("ClaveSecreta").Value;

                txtUrl.Text = url;
                txtCvCliente.Text = ClaveCliente;
                txtCvSecreta.Text = ClaveSecreta;

                txtBaseDatos.Focus();

            }
            catch(Exception ex) { }
        }

        private void btnProbarConexionMysql_Click(object sender, EventArgs e)
        {

            if (validateFieldMysql())
                if (OpenConnectionMysql())
                    CloseConnectionMySql();
        }

        #region OpenConnections

        public bool OpenConnectionSAP()
        {
            bool fgConnection = false;
            bool fgConnection2 = false;
            string msg = string.Empty;

            try
            {
                //hanaConnection = new HanaConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Hana"].ConnectionString);
                hanaConnection = new HanaConnection($"Server={txtServidor.Text}; UserID={txtUsuario.Text}; Password={txtContrasenia.Text}; Current Schema={txtBaseDatos.Text};");
                hanaConnection.Open();
                
                msg += $"[OK] Conexión realizada con éxito con la base de datos {txtBaseDatos.Text}.";
                fgConnection = true;

                if (hanaConnection != null)
                    hanaConnection.Close();

                try
                {
                    hanaConnection = new HanaConnection($"Server={txtServidor.Text}; UserID={txtUsuario.Text}; Password={txtContrasenia.Text}; Current Schema={txtBdBit.Text};");
                    hanaConnection.Open();
                    msg += $"\n[OK] Conexión realizada con éxito con la base de datos {txtBdBit.Text}.";
                    fgConnection2 = true;

                    if (hanaConnection != null)
                        hanaConnection.Close();
                }
                catch(Exception ex)
                {
                    msg += $"\n[X] No fue posible realizar conexión con la base de datos {txtBdBit.Text}.";
                }

                if(msg != "")
                    MessageBox.Show(msg);

            }
            catch (HanaException ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No es posible realiza la conexión con el servidor.");
                fgConnection = false;
            }

            return (fgConnection && fgConnection2);
        }
        public bool CloseConnectionSAP()
        {
            bool fgClose = false;

            try
            {
                if (hanaConnection != null)
                {
                    hanaConnection.Close();
                    Console.Write("Conexión cerrada con éxito.");
                    fgClose = true;
                }
            }
            catch (HanaException ex)
            {
                Console.Write(ex.ToString());
                fgClose = false;
            }

            return fgClose;
        }

        public bool OpenConnectionMysql()
        {
            try
            {
                string connectionString = $"SERVER={txtServidorMysql.Text}; DATABASE={txtBaseDatosMysql.Text}; User Id={txtUsuarioMysql.Text}; PASSWORD={txtContraseniaMysql.Text};";
                conexion = new MySqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Conexión establecida con éxito.");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1042:
                        MessageBox.Show("Unable to connect to any of the specified MySQL hosts.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private  bool CloseConnectionMySql()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Clone();
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        #endregion

        private void btnTestDiserver_Click(object sender, EventArgs e)
        {
            DIServerApi obDiAPI = new DIServerApi();
            if(validateFieldDIAPI())
            {
                obDiAPI.Url = txtUrlDiserver.Text;
                obDiAPI.Token = txtTokenDiserver.Text;
                if (obDiAPI.WSLogin())
                {
                    MessageBox.Show("Conexión establecida con éxito.");
                    txtSessionIdDiserver.Text = obDiAPI.Session;
                    obDiAPI.WSLogout();
                }
            }

        }
    }
}
