

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
        public void ScriereXML()
        {
            XmlDocument xml = new XmlDocument();
            //crearea xmlDeclaration
            XmlDeclaration xml_declaration = xml.CreateXmlDeclaration("1.0", "utf-8", "");
            xml.AppendChild(xml_declaration);

            XmlNode root = xml.CreateNode(XmlNodeType.Element, "Pacient", ""); 
            xml.AppendChild(root);

            PropertyInfo[] properties = typeof(Pacient).GetProperties();
            

            foreach (var property in properties)
            {

                var isEnumerable = typeof(List<Consultatie>).IsAssignableFrom(property.PropertyType);
                if (property.PropertyType.IsArray)
                {
                    Console.WriteLine($"array : {property.Name}");
                }

                if (isEnumerable)
                {
                    Console.WriteLine($" is Enumerable : Consultatie" );
                }
                Console.WriteLine(property.Name);
                //pentru fiecare studenti din listBox
                //XmlNode tmpNode = xml.CreateNode(XmlNodeType.Element, $"{property.ToString()}", "");
                //tmpNode.InnerText = properties.GetValue;
                //root.AppendChild(tmpNode); //adaugarea nodului ca si copil la nodul radacina
            }
            var currentPath = Path.Combine(Directory.GetCurrentDirectory(), "file_output");
            var xmlFile = Path.Combine(currentPath, "random.xml");
            xml.Save(xmlFile);

            Console.WriteLine("XML generat cu success!");
        }
    }
}
