using GenerareRaportPDF.Core.Enums;

namespace GenerareRaportPDF.Core
{
    public class Pacient
    {

        //date personale pacient
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cnp { get; set; }
        public char Sex { get; set; }
        public StareCivila StareCivila { get; set; }
        public string DomiciliuLocal { get; set; }
        public string Strada { get; set; }
        public int DomiciliuNr { get; set; }
        public string Ocupatie { get; set; }
        public string LocDeMunca { get; set; }


        public string[] SchimbariDomiciliu { get; set; } = new string[2];

        public string[] Antecedente { get; set; } = new string[2];

        public string ConditiiDeMunca { get; set; }

        //date legate de fisa
        public string Judet { get; set; }
        public string Localitatea { get; set; }
        public string UnitateSanitara { get; set; }

        //Lista cu Consultatii 
        public List<Consultatie> Consultatii { get; set; } = new List<Consultatie>();


        public int[] DataNasterii()
        {
            int[] dataNas = new int[3];
            //verificare cnp:


            int.TryParse(DateTime.Now.Year.ToString().Substring(1, 3), out int anul_actual);
            int.TryParse(Cnp.Substring(1, 2), out int cnpAn);
            int.TryParse(Cnp.Substring(3, 2), out int cnpLuna);
            int.TryParse(Cnp.Substring(5, 2), out int cnpZi);

            var anul = 0;

            //data nasterii
            if (Cnp.ElementAt(0) == '1' || Cnp.ElementAt(0) == '2' || Cnp.ElementAt(0) == '5' || Cnp.ElementAt(0) == '6')
            {
                if (cnpLuna <= 12)
                {
                    if (cnpZi <= 31)
                        Console.WriteLine($"AN:{cnpAn } : LUNA: {cnpLuna} : ZI : {cnpZi}");
                }
            }

            if (Cnp.ElementAt(0) == '1' || Cnp.ElementAt(0) == '2')
            {
                anul = 1900 + cnpAn;
            }
            else if ((Cnp.ElementAt(0) == '5' || Cnp.ElementAt(0) == '6') && cnpAn  < anul_actual)
            {
                anul = 2000 + cnpAn;
               
            }

            //calcul sex
            if(Cnp.ElementAt(0) == '1' || Cnp.ElementAt(0) == '5')
            {
                Sex = 'M';
            }
            else if(Cnp.ElementAt(0) == '2' || Cnp.ElementAt(0) == '6')
            {
                Sex = 'F';
            }

            dataNas[0] = cnpZi;
            dataNas[1] = cnpLuna;
            dataNas[2] = anul;

            return dataNas;
        }

        
    }
}
