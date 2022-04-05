

using System.Reflection;
using System.Xml;
using GenerareRaportPDF.Core;
namespace GenerareRaportPDF
{
    public class GenerareXML
    {
        private Pacient _pacient;
        public GenerareXML(Pacient pacient)
        {
            _pacient = pacient;
        }
        public void GenerareXMLPacient()
        {
            XmlDocument xml = new XmlDocument();
            //crearea xmlDeclaration
            XmlDeclaration xml_declaration = xml.CreateXmlDeclaration("1.0", "utf-8", "");
            xml.AppendChild(xml_declaration);

            XmlNode root = xml.CreateNode(XmlNodeType.Element, "Pacient", ""); 
            xml.AppendChild(root);

            PropertyInfo[] properties = typeof(Pacient).GetProperties();
            PropertyInfo[] propertiesConsultatie = typeof(Consultatie).GetProperties();

            foreach (var property in properties)
            {

                var isEnumerable = typeof(List<Consultatie>).IsAssignableFrom(property.PropertyType);
                if (isEnumerable)
                {
                                  
                    foreach(var item in _pacient.Consultatii)
                    {
                        XmlNode tmpNode = xml.CreateNode(XmlNodeType.Element, $"Consultatie", "");
                        foreach(var prop in propertiesConsultatie)
                        {
                            XmlNode consultNode = xml.CreateNode(XmlNodeType.Element, $"{prop.Name}", "");
                            consultNode.InnerText = item.;
                            tmpNode.AppendChild(consultNode);
                        }

                        root.AppendChild(tmpNode);
                    }
                }
                else
                {

                    XmlNode tmpNode = xml.CreateNode(XmlNodeType.Element, $"{property.Name}", "");
                    tmpNode.InnerText = "Marcel";
                    root.AppendChild(tmpNode); 

                }


               
            }
            Console.WriteLine("S-a generat xml");
            var currentPath = Path.Combine(Directory.GetCurrentDirectory(), "file_output");
            var nameXML = _pacient.Nume + "_" + _pacient.Prenume + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xml";
            var xmlFile = Path.Combine(currentPath, nameXML);

            xml.Save(xmlFile);

            Console.WriteLine("XML generat cu success!");
        }

        public void GenerareXMLTotiPacientii(List<Pacient> pacienti)
        {

        }
    }
}
