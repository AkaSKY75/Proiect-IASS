using GenerareRaportPDF.Core;

namespace GenerareRaportPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacient pacient = new Pacient() { 
                Nume = "Vasi",
                Prenume = "Ovidiu",
                Judet = "TImis",
                Localitatea = "Lugoj",
                UnitateSanitara = " Judetean",
                Cnp = "1990409351523" ,
                StareCivila = Core.Enums.StareCivila.Casatorit,
                DomiciliuLocal = "Lugoj",
                Strada = "Lalelelor",
                DomiciliuNr = 22,
                Ocupatie = "doctor",
                LocDeMunca = "Bosch",
                AntecedenteHeredo = "Infractiune perversa cu minore",
                AntecedentePersonale = "baga prea mult la aparate deci va rog sa il intelegeti",
                ConditiiDeMunca = "Sunt propriul meu sef deci sunt bos, lucru cum am eu chef si bag bani la aparate",
                SchimbariDomiciliu = "Acum sunt in Timisoara, si  ma mut unde am kef",
                SchimbariLocMunca = "Am bani de i trag cu roaba",
                Consultatii = new List<Consultatie> {
                    new Consultatie{Data = DateTime.Now, Locul = "Timisoara", Simptome = " il doare in cot de viata", Diagnostic = " o betie zdravana", Cod = "aalala", Prescriptie = "multa bautura la bbord", NrZileConcediu = 100},
                    new Consultatie{Data = DateTime.Now, Locul = "Timisoara", Simptome = " il doare in cot de viata", Diagnostic = " o betie zdravana", Cod = "aalala", Prescriptie = "multa bautura la bbord", NrZileConcediu = 100},
                },

            };

            GeneratePDF pdf = new GeneratePDF(pacient);
            //if (pdf.GenerateFisaMedicala())
            //{
            //    Console.WriteLine("Pdf generat cu succes!");
            //}
            //else
            //{
            //    Console.WriteLine("Generarea nu a fost cu succes!");
            //}

            GenerareXML xml = new GenerareXML(pacient);
            xml.GenerareXMLPacient();
            
        }
    }
}