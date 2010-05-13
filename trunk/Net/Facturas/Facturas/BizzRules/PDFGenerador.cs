using System;
using System.Collections.Generic;

using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using Facturas.Properties;

namespace Facturas.BizzRules
{
    public class PDFGenerador
    {
        private IFactura _factura;

        public PDFGenerador(IFactura factura)
        {
            _factura = factura;
        }

        public void Run()
        {
            string nombreFichero = string.Format("Factura-{0}.pdf", _factura.Numero);

            // step 1: creation of a document-object
            Document document = new Document();


            // step 2:
            // we create a writer that listens to the document
            // and directs a PDF-stream to a file
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nombreFichero, FileMode.Create));



            EscribirMetaInformacion(document);

            // step 3: we open the document
            document.Open();

            // step 4: we add a paragraph to the document
            Paragraph paragraph = new Paragraph(new Chunk("FACTURA TAXI Mariano",
            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.SpacingAfter = 10;




            document.Add(paragraph);
            paragraph = new Paragraph();

            float textSize = paragraph.Font.Size;

            paragraph.Add(string.Format("FECHA: {0}", _factura.Fecha.ToShortDateString()));
            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("FACTURA Nº: {0}", _factura.Numero));


            document.Add(paragraph);
            paragraph = new Paragraph();

            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize);
            paragraph.Add(string.Format("Licencia Municipal: {0}", Settings.Default.licencia));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(Settings.Default.nombre);


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(Settings.Default.direccion);


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(Settings.Default.poblacionCP);


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Teléfono: {0}", Settings.Default.telefono));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Móvil: {0}", Settings.Default.movil));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("E-Mail: {0}", Settings.Default.email));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("NIF: {0}", Settings.Default.nif));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("CCC: {0}", Settings.Default.ccc));


            document.Add(paragraph);
            paragraph = new Paragraph();

            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize);
            paragraph.Add("FACTURAR A:");





            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Nombre: {0}", _factura.Nombre));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Dirección: {0}", _factura.Direccion));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Ciudad: {0}", _factura.Ciudad));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("Código Postal: {0}", _factura.CodigoPostal));


            document.Add(paragraph);
            paragraph = new Paragraph();

            string telefono = _factura.Telefono;
            paragraph.Add(string.Format("Teléfono: {0}", telefono));


            document.Add(paragraph);
            paragraph = new Paragraph();


            paragraph.Add(string.Format("CIF/NIF: {0}", _factura.Cif));


            document.Add(paragraph);
            paragraph = new Paragraph();

            paragraph.ExtraParagraphSpace = 10;

            float[] medidasColumnas = new float[6] { 40, 7, 7, 7, 7, 10 };
            //tabla
            PdfPTable aTable = new PdfPTable(medidasColumnas);    // 2 rows, 2 columns
            aTable.WidthPercentage = 100;
            aTable.SpacingBefore = 20;


            PdfPRow fila = new PdfPRow(new PdfPCell[6] {
                new PdfPCell(new Phrase("Concepto",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))), 
                new PdfPCell(new Phrase("Km",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))), 
                new PdfPCell(new Phrase("€/Km",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))), 
                new PdfPCell(new Phrase("Horas de espera",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))),
                new PdfPCell(new Phrase("€/Hora de espera",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))),
                new PdfPCell(new Phrase("Cantidad",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))) });
            aTable.Rows.Add(fila);


            float total = GenerarLinea(aTable.Rows, _factura.Lineas);

            float totalSinIva = total / (1 + Settings.Default.iva);

            PdfPCell celdaBlanco = new PdfPCell(new Phrase(string.Empty));


            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearPieTabla(new PdfPCell(new Phrase("SUBTOTAL",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",Math.Round( totalSinIva,2))))) });

            aTable.Rows.Add(fila);



            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()),  
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearPieTabla(new PdfPCell(new Phrase(string.Format("IVA {0} %",Settings.Default.iva),FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",Math.Round( total-totalSinIva,2))))) });

            aTable.Rows.Add(fila);

            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearPieTabla(new PdfPCell(new Phrase("TOTAL",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", Math.Round(total,2)))))});
            aTable.Rows.Add(fila);


            //aTable.AddCell(fila);
            paragraph.Add(aTable);
            document.Add(paragraph);

            
            
            //iTextSharp.text.HeaderFooter
            //HeaderFooter footer ;//= new PDFHeaderFooter(new Phrase("Antes de imprimir este mensaje, asegúrate de que es necesario. Proteger el medio ambiente está también en tu mano."), true);
            
            //document.SetFooter(footer);

            // step 5: we close the document
            document.Close();


            EstamparMarcaAgua(nombreFichero);

            Process.Start(nombreFichero);
        }
        private PdfPCell FormatearCeldaVacia(PdfPCell celda)
        {
            celda.Border = 0;
            celda.BorderWidth = 0;

            return celda;
        }
        private PdfPCell FormatearPieTabla(PdfPCell celda)
        {
            celda.HorizontalAlignment = Element.ALIGN_LEFT;
            celda.Colspan = 2;

            return celda;
        }

        private PdfPCell FormatearEuros(PdfPCell celda)
        {
            celda.HorizontalAlignment = Element.ALIGN_RIGHT;


            return celda;
        }


        private float GenerarLinea(List<PdfPRow> list, IEnumerable<ILineaFactura> lineas)
        {
            float total = 0;
            foreach (ILineaFactura item in lineas)
            {
                total += item.Cantidad;
                PdfPRow fila = new PdfPRow(new PdfPCell[6] {
                        new PdfPCell(new Phrase(item.Concepto)), 
                        FormatearEuros(new PdfPCell(new Phrase(Convert.ToString(item.Kilometros)))), 
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", Settings.Default.eurosXKilometros)))),
                        FormatearEuros(new PdfPCell(new Phrase(Convert.ToString(item.HorasEspera)))),
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", Settings.Default.eurosXHora)))),
                        FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",item.Cantidad)))) });
                list.Add(fila);
            }

            return total;
        }

        private void EscribirMetaInformacion(Document document)
        {
            document.AddTitle("Hello World example");
            document.AddSubject("This example explains step 3 in Chapter 1");
            document.AddKeywords("Metadata, iText, step 3, tutorial");
            document.AddCreator("My program using iText");
            document.AddAuthor("Bruno Lowagie");
            document.AddHeader("Expires", "0");

        }

        //private void Firmar()
        //{
        //        debug("Started ...");

        //        debug("Checking certificate ...");
        //        Cert myCert = null;
        //        try
        //        {
        //            myCert = new Cert(certTextBox.Text, passwordBox.Text);
        //            debug("Certificate OK");
        //        }
        //        catch (Exception ex)
        //        {
        //            debug("Error : please make sure you entered a valid certificate file and password");
        //            debug("Exception : " + ex.ToString());
        //            return;
        //        }


        //        debug("Creating new MetaData ... ");

        //        //Adding Meta Datas
        //        MetaData MyMD = new MetaData();
        //        MyMD.Author = authorBox.Text;
        //        MyMD.Title = titleBox.Text;
        //        MyMD.Subject = subjectBox.Text;
        //        MyMD.Keywords = kwBox.Text;
        //        MyMD.Creator = creatorBox.Text;
        //        MyMD.Producer = prodBox.Text;


        //        debug("Signing document ... ");
        //        PDFSigner pdfs = new PDFSigner(inputBox.Text, outputBox.Text, myCert, MyMD);
        //        pdfs.Sign(Reasontext.Text, Contacttext.Text, Locationtext.Text, SigVisible.Checked);

        //        debug("Done :)");

        //}

        private void EstamparMarcaAgua(string nombreFichero)
        {
            PdfReader pdfReader = new PdfReader(nombreFichero);
            PdfStamper stamp = new PdfStamper(pdfReader, new FileStream(nombreFichero.Replace(".pdf", "[temp][file].pdf"), FileMode.Create));

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Base64ToImage.ConvertThis("Hola mundo"), BaseColor.GRAY);
            img.SetAbsolutePosition(250, 300); // set the position in the document where you want the watermark to appear (0,0 = bottom left corner of the page)

            PdfContentByte waterMark;
            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                waterMark = stamp.GetUnderContent(page);
                waterMark.AddImage(img);
            }
            stamp.FormFlattening = true;
            stamp.Close();

            // now delete the original file and rename the temp file to the original file
            File.Delete(nombreFichero);
            File.Move(nombreFichero.Replace(".pdf", "[temp][file].pdf"), nombreFichero);

        }         
    }


}
