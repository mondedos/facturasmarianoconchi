using System;
using System.Collections.Generic;

using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using Facturas.Properties;
using System.Security.Cryptography;

namespace Facturas.BizzRules
{
    /// <summary>
    /// Clase encargada de la generación de ficheros PDF para las facturas
    /// </summary>
    public class PDFGenerador
    {
        private IFactura _factura;

        public PDFGenerador(IFactura factura)
        {
            _factura = factura;
        }
        /// <summary>
        /// Método que realiza la construcción de una factura en PDF.
        /// </summary>
        public void Run()
        {
            string escritorio = Settings.Default.carpetaSalidaPDF;

            string nombreFichero = System.IO.Path.Combine(escritorio, string.Format("Factura-{0}.pdf", _factura.Numero));



            // step 1: creation of a document-object
            Document document = new Document();


            // step 2:
            // we create a writer that listens to the document
            // and directs a PDF-stream to a file
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nombreFichero, FileMode.Create));

            MyPdfPageEventHelpPageNo footer = new MyPdfPageEventHelpPageNo();
            footer.Hash = FirmarFactura(_factura);
            footer.NumeroFactura = _factura.Numero;
            writer.PageEvent = footer;


            // step 3: we open the document
            document.Open();

            PdfContentByte cb = writer.DirectContent;

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


            cb.BeginText();


            cb.SetFontAndSize(bf, 65);
            cb.SetCMYKColorFill(0, 0, 0, Settings.Default.nivelLMFondo);

            String text = string.Format("L. M. {0}", Settings.Default.licencia);

            int y = 650;
            //for (int i = 1; i < 8; i++)
            //{
            //    // we show some text starting on some absolute position with a given alignment
            //    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, text, 400, y - 75 * i, 0);
            //}

            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, text, 500, y - 75, 270);

            cb.SetCMYKColorFill(0, 0, 0, 255);
            cb.EndText();



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
            if (string.IsNullOrEmpty(telefono))
            {
                telefono = "*".PadRight(9, '*');
            }
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
                FormatearBorde(new PdfPCell(new Phrase("Concepto",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                FormatearBorde(new PdfPCell(new Phrase("Km",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                FormatearBorde(new PdfPCell(new Phrase(string.Format("{0}/Km",System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol),FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))), 
                FormatearBorde(new PdfPCell(new Phrase("Horas de espera",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))),
                FormatearBorde(new PdfPCell(new Phrase(string.Format("{0}/Hora de espera",System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol),FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))),
                FormatearBorde(new PdfPCell(new Phrase("Cantidad",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize)))) });
            aTable.Rows.Add(fila);


            decimal total = GenerarLinea(aTable.Rows, _factura.Lineas);

            decimal totalSinIva = total / (1 + Settings.Default.iva / 100);

            PdfPCell celdaBlanco = new PdfPCell(new Phrase(string.Empty));


            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearBorde(FormatearPieTabla(new PdfPCell(new Phrase("SUBTOTAL",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))))), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",Math.Round( totalSinIva,2)))))) });

            aTable.Rows.Add(fila);



            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()),  
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearBorde(FormatearPieTabla(new PdfPCell(new Phrase(string.Format("IVA {0} {1}",Settings.Default.iva,System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol),FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))))), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",Math.Round( total-totalSinIva,2)))))) });

            aTable.Rows.Add(fila);

            fila = new PdfPRow(new PdfPCell[6] {
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()), 
                        FormatearCeldaVacia(new PdfPCell()),
                        FormatearBorde(FormatearPieTabla(new PdfPCell(new Phrase("TOTAL",FontFactory.GetFont(FontFactory.HELVETICA_BOLD, textSize))))),
                        FormatearCeldaVacia(new PdfPCell()),
                       FormatearBorde( FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", Math.Round(total,2))))))});
            aTable.Rows.Add(fila);


            //aTable.AddCell(fila);
            paragraph.Add(aTable);
            document.Add(paragraph);

            //paragraph = new Paragraph();

            //paragraph.SpacingBefore = 20;
            //paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6);
            //paragraph.Alignment = Element.ALIGN_RIGHT;
            //paragraph.Add(FirmarFactura(_factura, total));

            

            //document.Add(paragraph);
            //iTextSharp.text.HeaderFooter)
            //HeaderFooter footer ;//= new PDFHeaderFooter(new Phrase("Antes de imprimir este mensaje, asegúrate de que es necesario. Proteger el medio ambiente está también en tu mano."), true);

            //document.SetFooter(footer);





            // step 5: we close the document
            EscribirMetaInformacion(document, _factura, total);

            document.Close();


            //EstamparMarcaAgua(nombreFichero);

            try
            {
                Process.Start(nombreFichero);
            }
            catch (System.ComponentModel.Win32Exception)
            {


            }

        }
        private PdfPCell FormatearBorde(PdfPCell celda)
        {
            celda.BorderWidth = (float)Convert.ToDouble(Settings.Default.tablaBorde);

            return celda;
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
        /// <summary>
        /// Método que realiza el cálculo de firma de factura.
        /// </summary>
        /// <param name="factura">Factura a firmar</param>
        /// <returns>cadena de firma</returns>
        private string FirmarFactura(IFactura factura)
        {
            StringBuilder sb = new StringBuilder(Settings.Default.licencia);

            decimal total = 0;

            //suma el total a pagar
            foreach (ILineaFactura item in factura.Lineas)
            {
                total += item.Cantidad;
            }


            sb.Append(factura.Numero).Append(Settings.Default.ccc)
                .Append(total).Append(factura.Nombre).Append(Settings.Default.nif);

            return GetSHA1(sb.ToString());
        }
        public static string GetSHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private decimal GenerarLinea(List<PdfPRow> list, IEnumerable<ILineaFactura> lineas)
        {
            decimal total = 0;
            foreach (ILineaFactura item in lineas)
            {
                total += item.Cantidad;
                PdfPRow fila = new PdfPRow(new PdfPCell[6] {
                        FormatearBorde(new PdfPCell(new Phrase(item.Concepto))), 
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(Convert.ToString(item.Kilometros))))), 
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", item.KilometrosEuros))))),
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(Convert.ToString(item.HorasEspera))))),
                        FormatearBorde(FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}", item.HorasEuros))))),
                       FormatearBorde( FormatearEuros(new PdfPCell(new Phrase(String.Format("{0:C}",item.Cantidad))))) });
                list.Add(fila);
            }

            return total;
        }

        private void EscribirMetaInformacion(Document document, IFactura factura, decimal importe)
        {
            document.AddTitle(string.Format("Factura {0}", factura.Numero));
            document.AddSubject(string.Format("Factura por translado en taxi emitida a {0}", factura.Nombre));

            StringBuilder claves = new StringBuilder(string.Format("Importe {0} {1}", importe, System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol));

            //foreach (var item in collection)
            //{
            //    if (Convert.ToBoolean(claves.Length))
            //    {
            //        claves.Append(", ");
            //    }
            //}


            document.AddKeywords(claves.ToString());
            document.AddCreator("Ricardo Prieto Mendoza, email: ricardo.prietomendozaATgmail.com");
            document.AddAuthor(Settings.Default.nombre);
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





    public class MyPdfPageEventHelpPageNo : iTextSharp.text.pdf.PdfPageEventHelper
    {
        protected PdfTemplate total;
        protected BaseFont helv;
        private bool settingFont = false;

        public string Hash { get; set; }

        private int _numeroPagina = 0;

        public int NumeroFactura { get; set; }
        

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            total = writer.DirectContent.CreateTemplate(100, 100);
            total.BoundingBox = new Rectangle(-20, -20, 100, 100);

            helv = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);

            if (Convert.ToBoolean(_numeroPagina))
            {
                //Ya no estamos en la primera página
                PdfPTable tableTitle = new PdfPTable(1);

                PdfPCell cell = new PdfPCell(new Phrase(string.Format("FACTURA TAXI Mariano Nº {0}",NumeroFactura) + Environment.NewLine));

                cell.Border = 0;
                cell.PaddingBottom = 15;
                

                tableTitle.AddCell(cell);

                document.Add(tableTitle);

            }

            _numeroPagina++;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfContentByte cb = writer.DirectContent;
            cb.SaveState();

            float textBase = document.Bottom - 20;
            float textSize = 8; //helv.GetWidthPoint(text, 12); 
            cb.BeginText();
            cb.SetFontAndSize(helv, 8);

            cb.SetTextMatrix(document.Left,textBase);
            cb.ShowText(string.Format("Página {0}", document.PageNumber));
            cb.SetTextMatrix(document.Right-(Hash.Length<<2), textBase);
            cb.ShowText(Hash);
            cb.EndText();
            cb.AddTemplate(total, document.Right - textSize, textBase);


            //if ((writer.PageNumber % 2) == 1)
            //{
              
            //}
            //else
            //{
            //    float adjust = helv.GetWidthPoint("0", 12);
            //    cb.SetTextMatrix(document.Right - textSize - adjust, textBase);
            //    cb.ShowText(text);
            //    cb.EndText();
            //    cb.AddTemplate(total, document.Right - adjust, textBase);
            //}
            cb.RestoreState();
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            //total.BeginText();
            //total.SetFontAndSize(helv, 12);
            //total.SetTextMatrix(0, 0);
            //int pageNumber = writer.PageNumber - 1;
            //total.ShowText(Convert.ToString(pageNumber));
            //total.EndText();
        }

    }
}
