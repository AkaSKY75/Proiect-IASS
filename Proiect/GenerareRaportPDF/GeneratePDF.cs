using System;
using GenerareRaportPDF.Core;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace GenerareRaportPDF
{
    public class GeneratePDF
    {
        private Pacient _pacient;
        public List<Consultatie> ConsultatiiList { get; set; }
        public GeneratePDF(Pacient pacient)
        {
            _pacient = pacient;
            ConsultatiiList = new List<Consultatie>();
        }

        public bool GenerateFisaMedicala()
        {
            try
            {
                var currentPath = Path.Combine(Directory.GetCurrentDirectory(),"file_output");
                var namePdf = _pacient.Nume + "_" + _pacient.Prenume + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";

                PdfWriter writer = new PdfWriter(Path.Combine(currentPath, namePdf));
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                Paragraph headerLeft = new Paragraph($"Judetul: {_pacient.Judet}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);

                headerLeft.Add(new Tab());
                headerLeft.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                headerLeft.Add($"Nr. 8332 / 123123");
                document.Add(headerLeft);

                Paragraph localitate = new Paragraph($"Localitatea: {_pacient.Localitatea}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);

                localitate.Add(new Tab());
                localitate.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                localitate.Add($"Codul numeric personal:").SetVerticalAlignment(VerticalAlignment.TOP);

                Table cnpTable = new Table(13, false).SetVerticalAlignment(VerticalAlignment.BOTTOM).SetFontSize(8);
                foreach (var item in _pacient.Cnp.ToCharArray())
                {
                    Cell cell = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(item.ToString()));
                    cnpTable.AddCell(cell);
                }

                localitate.Add(cnpTable);
                document.Add(localitate);                

                Paragraph unitSan = new Paragraph($"Unitate sanitara: {_pacient.UnitateSanitara}")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10).SetKeepWithNext(true);
                document.Add(unitSan);
                        
                // Linie noua
                Paragraph newline = new Paragraph(new Text("\n"));
                document.Add(newline);

                Paragraph titlu = new Paragraph($"FISA DE CONSULTATII MEDICALE")
               .SetTextAlignment(TextAlignment.CENTER).SetBold()
               .SetFontSize(16);
                document.Add(titlu);

                Paragraph subtitlu = new Paragraph($"-ADULTI-")
                .SetTextAlignment(TextAlignment.CENTER).SetBold()
                .SetFontSize(16);
                document.Add(subtitlu);

                document.Add(newline);
                document.Add(newline);

                int[] datas = _pacient.DataNasterii();

                string repeater = string.Concat(Enumerable.Repeat(".", 15));
                Paragraph rand1 = new Paragraph($"Numele: ")
                 .SetTextAlignment(TextAlignment.LEFT)
                 .SetFontSize(10);
                rand1.Add($"{_pacient.Nume} {repeater}");
                rand1.Add($"Prenumele: {_pacient.Prenume}  {repeater}");
                rand1.Add($"Sexul: {_pacient.Sex} {repeater}");
                document.Add(rand1);

                            
                Paragraph rand2 = new Paragraph($"Data nasterii: ")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10);
                rand2.Add($"anul {datas[2]}   {repeater}");
                rand2.Add($" luna {datas[1]} {repeater} ");
                rand2.Add($" ziua {datas[0]}  {repeater}.");
                rand2.Add($"Starea civila:  {_pacient.StareCivila} {repeater}");
                document.Add(rand2);

                Paragraph rand3 = new Paragraph($"Domiciliul: ")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10);
                rand3.Add($"localitatea: {_pacient.DomiciliuLocal} {repeater}");
                rand3.Add($"   str. {_pacient.Strada}{repeater}");
                rand3.Add($"   nr. {_pacient.DomiciliuNr} {repeater}");
                document.Add(rand3);

                Paragraph rand4 = new Paragraph($"Ocupatia: {_pacient.Ocupatie}{repeater}")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10);
                rand4.Add($" Locul de munca: {_pacient.LocDeMunca}{repeater}");            
                document.Add(rand4);

                document.Add(newline);

                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);

                Paragraph title1 = new Paragraph($"Schimbari de:")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(12); 
                document.Add(title1);

                Paragraph subtitle = new Paragraph($"domiciliu")
                .SetUnderline()
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(10);

                subtitle.Add(new Tab());
                subtitle.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                subtitle.Add($"loc de munca:")
                .SetUnderline()
                .SetFontSize(10);
                document.Add(subtitle);

                Paragraph subtitle2 = new Paragraph($" {_pacient.SchimbariDomiciliu} {repeater}")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10);

                subtitle2.Add(new Tab());
                subtitle2.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                subtitle2.Add($" {_pacient.SchimbariLocMunca} {repeater}")
                .SetFontSize(10);
                document.Add(subtitle2);

                document.Add(ls);

                Paragraph subtitle3 = new Paragraph(new Text($"Antecedente:\n"))
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12).SetBold().SetUnderline();
                document.Add(subtitle3);

                subtitle3 = new Paragraph($"Heredo-colaterale: {_pacient.AntecedenteHeredo} {repeater}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(10);
                document.Add(subtitle3);


                Paragraph subtitle4 = new Paragraph($"Personale: {_pacient.AntecedentePersonale} {repeater}")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(10);
                document.Add(subtitle4);


                document.Add(newline);

                //Conditii de munca:

                Paragraph subtitle5 = new Paragraph($"Conditii de munca: ")               
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12).SetUnderline().SetBold();
                document.Add(subtitle5);

                subtitle5 = new Paragraph($" {_pacient.ConditiiDeMunca} {repeater}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(10);
                document.Add(subtitle5);

                document.Add(newline);
                document.Add(newline);

                //  CONSULTATII, INVESTIGATII tabel ce se genereaza in functie de lista de consultatii

                if (_pacient.Consultatii.ToList().Count > 0)
                {
                    Table consultatiiTable = new Table(7, false);
                    consultatiiTable.SetHorizontalAlignment(HorizontalAlignment.CENTER);

                    //facem cap de tabel
                    Cell cell1 = new Cell()
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(new Text("Data: \nanul/luna/ziua")));

                    Cell cell2 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Locul")));

                    Cell cell3 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Simptome")));

                    Cell cell4 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Diagnostic")));

                    Cell cell5 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Codul")));

                    Cell cell6 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Prescriptii \n Recomandari**")));

                    Cell cell7 = new Cell()
                   .SetBackgroundColor(ColorConstants.WHITE)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(new Text("Nr.Zile\nConcediu medical;\nNr.Certificat")));

                    consultatiiTable.AddCell(cell1);
                    consultatiiTable.AddCell(cell2);
                    consultatiiTable.AddCell(cell3);
                    consultatiiTable.AddCell(cell4);
                    consultatiiTable.AddCell(cell5);
                    consultatiiTable.AddCell(cell6);
                    consultatiiTable.AddCell(cell7);

                    foreach (var consult in _pacient.Consultatii)
                    {
                        Cell celli1 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Data.ToString("yyyy/MM/dd")}")));

                        Cell celli2 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Locul}")));

                        Cell celli3 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Simptome}")));

                        Cell celli4 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Diagnostic}")));

                        Cell celli5 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Cod}")));

                        Cell celli6 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.Prescriptie}")));

                        Cell celli7 = new Cell()
                        .SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(new Text($"{consult.NrZileConcediu}")));

                        consultatiiTable.AddCell(celli1);
                        consultatiiTable.AddCell(celli2);
                        consultatiiTable.AddCell(celli3);
                        consultatiiTable.AddCell(celli4);
                        consultatiiTable.AddCell(celli5);
                        consultatiiTable.AddCell(celli6);
                        consultatiiTable.AddCell(celli7);
                    }

                    document.Add(consultatiiTable);
                }
              
                //int n = pdf.GetNumberOfPages();
                //for (int i = 1; i <= n; i++)
                //{
                //    document.ShowTextAligned(new Paragraph(String
                //    .Format("Pagina" + i + " din " + n)),
                //    559, 806, i, TextAlignment.RIGHT,
                //   VerticalAlignment.TOP, 0);
                //}
                document.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }


    }
}
