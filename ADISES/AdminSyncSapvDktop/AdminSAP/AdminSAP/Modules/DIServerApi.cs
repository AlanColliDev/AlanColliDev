using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;



namespace AdminSAP.Modules
{
    public class DIServerApi
     {
        private string url;
        //http://192.168.15.113/ws_SAP/DIServer.asmx";
        private string token;
            
        //"iVAsfVBMz0SklEv1qFSmOEMR4rSRSc1dxsioKjXmEVHVnhEuqZ+LvhXnHJjY8ZEWexzIyqrsSViZIi73ZrtpV3lV2UBBJ8KevYpgwNmSGWVBtseoLUT8Ww==";
        private string session;

        public string Token { get => token; set => token = value; }
        public string Url { get => url; set => url = value; }
        public string Session { get => session; set => session = value; }

        public bool WSLogin()
        {
            try
            {
                string response;
                WSIL.DIServer DIServer;
                DIServer = new WSIL.DIServer { Url = Url };

                response = DIServer.LoginSSL(Token);

                if (WSValidate(response))
                {
                    PrintLog("DIServerApiClass", "LINE 22 ", $"Resultado de la conexion Exitosa: {response}");
                    Session = response;
                    return true;
                } 
            }
            catch (Exception e)
            {
                PrintLog("DIServerApiClass", "LINE 28 CATCH ", $"Resultado de la conexion: {e.ToString()}");
            }
            return false;

            //SesionActiva(response);
        }

        private bool WSValidate(string response)
        {
            WSIL.DIServer DIServer = new WSIL.DIServer { Url = Url };

            if (DIServer.Validate(response))
            {
                return true;
            }
            else
            {
                if (DIServer.Validate(response))
                    return true;
                return false;
            }

        }

        public void WSLogout()
        {
            WSIL.DIServer DIServer = new WSIL.DIServer { Url = Url };
            string response = DIServer.Logout(Session);
            PrintLog("DIServerApiClass", "LINE 64 CATCH ", $"Session close: {response}");


        }
        public string WSAddObject(string BOMObject, string Command)
        {
            
            System.Xml.XmlNode xmlNode;

            WSIL.DIServer DIServer = new WSIL.DIServer { Url = Url };
            xmlNode = DIServer.AddObject(Session, BOMObject, Command);

            //richTxtAddObject.Clear();
            PrintLog("DIServerApiClass", "LINE 63 CATCH ", $"Session: {Session}");

            string xmlResponse = FormatXML(xmlNode.OuterXml);
            return (!string.IsNullOrEmpty(xmlResponse) ? xmlResponse : "no se creo");
        }

        public int GetIdResponse(string resp)
        {
            XDocument xml = XDocument.Parse(resp);
            XNamespace ns = "http://www.sap.com/SBO/DIS";

            int IdQuot = 0;
            if (xml.Root.Descendants(ns + "AddObjectResponse").Elements(ns + "RetKey").Any())
            {

                IdQuot = (int)xml.Root.Descendants(ns + "AddObjectResponse").Elements(ns + "RetKey").FirstOrDefault();
                PrintLog("DIServerApiClass", "LINE 84 GetIdResponse()", $"IdQuot: {IdQuot.ToString()}");

                Console.Write(Convert.ToInt32(IdQuot));
                return IdQuot;
            }
            return 0;

        }

        public string FormatXML(string xml)
        {
            string result = "";

            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mStream, Encoding.Unicode);
            System.Xml.XmlDocument document = new System.Xml.XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = System.Xml.Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                System.IO.StreamReader sReader = new System.IO.StreamReader(mStream);

                // Extract the text from the StreamReader.
                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (System.Xml.XmlException)
            {
                // Handle the exception
            }

            mStream.Close();
            writer.Close();

            return result;
        }

        public string ObjToStringXML<T>(T objeto, System.Xml.Serialization.XmlSerializerNamespaces ns, Boolean OmitXmlDeclaration = false)
        {
            System.Xml.Serialization.XmlSerializer serializer;
            System.Xml.XmlWriter writer;
            System.IO.StringWriter stream;
            System.Xml.XmlWriterSettings settings;

            settings = new System.Xml.XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = OmitXmlDeclaration;

            stream = new System.IO.StringWriter();
            writer = System.Xml.XmlWriter.Create(stream, settings);

            serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            serializer.Serialize(writer, objeto, ns);

            return stream.ToString();
        }

        public void PrintLog(string function, string nivelCatch, string message)
        {
            string path = @"C:\Program Files (x86)\Adises\Logs\";
            string pathComplete = $"{path}log_{DateTime.Now.ToString("ddMMyyyy")}.txt";
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (StreamWriter writer = new StreamWriter(pathComplete, true))
                {
                    writer.WriteLine($"--------------------------Start-----------------------------");

                    writer.WriteLine($"function: {function}");
                    writer.WriteLine($"nivelCatch: {nivelCatch}");
                    writer.WriteLine($"Hora: {DateTime.Now.ToString("hh:mm:ss tt")}");
                    writer.WriteLine($"message: {message}");

                    writer.WriteLine($"---------------------------Finish----------------------------\n\n");
                    writer.Close();
                }
            }
            catch (Exception ex) { }
        }
        //public static DIServerApi getInstance => new DIServerApi();


     }
}
