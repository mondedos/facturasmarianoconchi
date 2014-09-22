using FacturaElectronica32;
using Facturas.BizzRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturaElectronica32
{
    public partial class Facturae
    {
        double _total;

        public static Facturae Create()
        {
            Facturae factura = new Facturae
            {
                FileHeader = new FileHeaderType
                {
                    Modality = ModalityType.I,
                    InvoiceIssuerType = InvoiceIssuerTypeType.EM,
                    Batch = new BatchType
                    {
                        BatchIdentifier = "DNI",
                        InvoicesCount = 1,
                        InvoiceCurrencyCode = CurrencyCodeType.EUR
                    }
                },
            };

            return factura;
        }

        public void SetDNIEmisor(string dni)
        {
            FileHeader.Batch.BatchIdentifier = dni;
        }
        public void SetTotal(decimal total)
        {
            SetTotal(Convert.ToDouble(total));
        }
        public void SetTotal(double total)
        {
            _total = total;
            AmountType typeInvoicesAmount = FileHeader.Batch.TotalInvoicesAmount ?? new AmountType
            {

            };
            typeInvoicesAmount.TotalAmount = total;
            FileHeader.Batch.TotalInvoicesAmount = typeInvoicesAmount;

            AmountType typeTotalOutstandingAmount = FileHeader.Batch.TotalOutstandingAmount ?? new AmountType
            {

            };
            typeTotalOutstandingAmount.TotalAmount = total;
            FileHeader.Batch.TotalOutstandingAmount = typeTotalOutstandingAmount;
            AmountType typeTotalExecutableAmount = FileHeader.Batch.TotalExecutableAmount ?? new AmountType
            {

            };

            typeTotalExecutableAmount.TotalAmount = total;
            FileHeader.Batch.TotalExecutableAmount = typeTotalExecutableAmount;
        }

        
    }


    public partial class InvoiceType
    {
        internal static InvoiceType Create(IFactura factura)
        {
            InvoiceType invoice = new InvoiceType
            {
                InvoiceHeader = new InvoiceHeaderType
                {
                    InvoiceNumber=Convert.ToString(factura.Numero),
                    InvoiceSeriesCode=string.Empty,
                    InvoiceDocumentType=InvoiceDocumentTypeType.FA,
                    InvoiceClass=InvoiceClassType.OO
                },
                InvoiceIssueData = new InvoiceIssueDataType
                {

                }
            };


            return invoice;
        }

    }
}
