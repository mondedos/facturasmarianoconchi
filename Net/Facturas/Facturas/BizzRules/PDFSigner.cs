using System.Collections.Generic;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Pkcs;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.xml.xmp;

namespace Facturas.BizzRules
{
    /// <summary>
    /// This class hold the certificate and extract private key needed for e-signature 
    /// </summary>
    class Cert
    {
        #region Attributes

        private string path = string.Empty;
        private string _password = string.Empty;
        private AsymmetricKeyParameter _akp;
        private X509Certificate[] _chain;

        #endregion

        #region Accessors
        public X509Certificate[] Chain
        {
            get { return _chain; }
        }
        public AsymmetricKeyParameter Akp
        {
            get { return _akp; }
        }

        public string Path
        {
            get { return path; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion

        #region Helpers

        private void ProcessCert()
        {
            string alias = null;

            //First we'll read the certificate file
            Pkcs12Store pk12 = new Pkcs12Store(new FileStream(Path, FileMode.Open, FileAccess.Read), _password.ToCharArray());

            //then Iterate throught certificate entries to find the private key entry

            foreach (var item in pk12.Aliases)
            {
                alias = ((string)item);
                if (pk12.IsKeyEntry(alias))
                    break;
            }

            _akp = pk12.GetKey(alias).Key;
            X509CertificateEntry[] ce = pk12.GetCertificateChain(alias);
            _chain = new X509Certificate[ce.Length];
            for (int k = 0; k < ce.Length; ++k)
                _chain[k] = ce[k].Certificate;

        }
        #endregion

        #region Constructors
        public Cert()
        { }
        public Cert(string cpath)
        {
            path = cpath;
            ProcessCert();
        }
        public Cert(string cpath, string cpassword)
        {
            path = cpath;
            Password = cpassword;
            ProcessCert();
        }
        #endregion

    }

    /// <summary>
    /// This is a holder class for PDF metadata
    /// </summary>
    class MetaData
    {
        private Dictionary<string, string> _info = new Dictionary<string, string>();

        public Dictionary<string, string> Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public string Author
        {
            get { return _info["Author"]; }
            set { _info.Add("Author", value); }
        }
        public string Title
        {
            get { return _info["Title"]; }
            set { _info.Add("Title", value); }
        }
        public string Subject
        {
            get { return _info["Subject"]; }
            set { _info.Add("Subject", value); }
        }
        public string Keywords
        {
            get { return _info["Keywords"]; }
            set { _info.Add("Keywords", value); }
        }
        public string Producer
        {
            get { return _info["Producer"]; }
            set { _info.Add("Producer", value); }
        }

        public string Creator
        {
            get { return _info["Creator"]; }
            set { _info.Add("Creator", value); }
        }

        public Dictionary<string, string> GetMetaData()
        {
            return _info;
        }
        public byte[] GetStreamedMetaData()
        {
            MemoryStream os = new MemoryStream();
            XmpWriter xmp = new XmpWriter(os, _info);
            xmp.Close();
            return os.ToArray();
        }

    }


    /// <summary>
    /// this is the most important class
    /// it uses iTextSharp library to sign a PDF document
    /// </summary>
    class PdfSigner
    {
        private string inputPDF = string.Empty;
        private string outputPDF = string.Empty;
        private Cert myCert;
        private MetaData metadata;

        public PdfSigner(string input, string output)
        {
            inputPDF = input;
            outputPDF = output;
        }

        public PdfSigner(string input, string output, Cert cert)
        {
            inputPDF = input;
            outputPDF = output;
            myCert = cert;
        }
        public PdfSigner(string input, string output, MetaData md)
        {
            inputPDF = input;
            outputPDF = output;
            metadata = md;
        }
        public PdfSigner(string input, string output, Cert cert, MetaData md)
        {
            inputPDF = input;
            outputPDF = output;
            myCert = cert;
            metadata = md;
        }

        public void Verify()
        {
        }


        public void Sign(string sigReason, string sigContact, string sigLocation, bool visible)
        {
            PdfReader reader = new PdfReader(inputPDF);
            //Activate MultiSignatures
            PdfStamper st = PdfStamper.CreateSignature(reader, new FileStream(outputPDF, FileMode.Create, FileAccess.Write), '\0', null, true);
            //To disable Multi signatures uncomment this line : every new signature will invalidate older ones !
            //PdfStamper st = PdfStamper.CreateSignature(reader, new FileStream(outputPDF, FileMode.Create, FileAccess.Write), '\0'); 

            st.MoreInfo = metadata.GetMetaData();
            st.XmpMetadata = metadata.GetStreamedMetaData();
            PdfSignatureAppearance sap = st.SignatureAppearance;

            sap.SetCrypto(myCert.Akp, myCert.Chain, null, PdfSignatureAppearance.WINCER_SIGNED);
            sap.Reason = sigReason;
            sap.Contact = sigContact;
            sap.Location = sigLocation;
            if (visible)
                sap.SetVisibleSignature(new iTextSharp.text.Rectangle(100, 100, 250, 150), 1, null);

            st.Close();
        }

    }
}




