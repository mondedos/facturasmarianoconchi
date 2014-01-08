using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Facturas.BizzRules
{
    public static class Iban
    {
        #region Atributos

        private static readonly IbanData[] IbanDatas = new[]
           {
               
new IbanData
                    {
                        CountryCode = "AD",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^AD\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "AE",
                        IsEU924 = false,
                        Lenght = 23,
    RegexStructure = @"^AE\d{2}[a-zA-Z0-9]{19}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "AL",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^AL\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "AO",
                        IsEU924 = false,
                        Lenght = 25,
    RegexStructure = @"^AO\d{2}[a-zA-Z0-9]{21}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "AT",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^AT\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "AZ",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^AZ\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BA",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^BA\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BE",
                        IsEU924 = false,
                        Lenght = 16,
    RegexStructure = @"^BE\d{2}[a-zA-Z0-9]{12}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BF",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^BF\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BG",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^BG\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BH",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^BH\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BI",
                        IsEU924 = false,
                        Lenght = 16,
    RegexStructure = @"^BI\d{2}[a-zA-Z0-9]{12}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BJ",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^BJ\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "BR",
                        IsEU924 = false,
                        Lenght = 29,
    RegexStructure = @"^BR\d{2}[a-zA-Z0-9]{25}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CG",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^CG\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CH",
                        IsEU924 = false,
                        Lenght = 21,
    RegexStructure = @"^CH\d{2}[a-zA-Z0-9]{17}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CI",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^CI\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CM",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^CM\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CR",
                        IsEU924 = false,
                        Lenght = 21,
    RegexStructure = @"^CR\d{2}[a-zA-Z0-9]{17}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CV",
                        IsEU924 = false,
                        Lenght = 25,
    RegexStructure = @"^CV\d{2}[a-zA-Z0-9]{21}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CY",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^CY\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "CZ",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^CZ\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "DE",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^DE\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "DK",
                        IsEU924 = false,
                        Lenght = 18,
    RegexStructure = @"^DK\d{2}[a-zA-Z0-9]{14}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "DO",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^DO\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "DZ",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^DZ\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "EE",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^EE\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "EG",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^EG\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "ES",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^ES\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "FI",
                        IsEU924 = false,
                        Lenght = 18,
    RegexStructure = @"^FI\d{2}[a-zA-Z0-9]{14}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "FO",
                        IsEU924 = false,
                        Lenght = 18,
    RegexStructure = @"^FO\d{2}[a-zA-Z0-9]{14}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "FR",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^FR\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GA",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^GA\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GB",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^GB\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GE",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^GE\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GI",
                        IsEU924 = false,
                        Lenght = 23,
    RegexStructure = @"^GI\d{2}[a-zA-Z0-9]{19}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GL",
                        IsEU924 = false,
                        Lenght = 18,
    RegexStructure = @"^GL\d{2}[a-zA-Z0-9]{14}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GR",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^GR\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "GT",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^GT\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "HR",
                        IsEU924 = false,
                        Lenght = 21,
    RegexStructure = @"^HR\d{2}[a-zA-Z0-9]{17}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "HU",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^HU\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "IE",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^IE\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "IL",
                        IsEU924 = false,
                        Lenght = 23,
    RegexStructure = @"^IL\d{2}[a-zA-Z0-9]{19}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "IR",
                        IsEU924 = false,
                        Lenght = 26,
    RegexStructure = @"^IR\d{2}[a-zA-Z0-9]{22}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "IS",
                        IsEU924 = false,
                        Lenght = 26,
    RegexStructure = @"^IS\d{2}[a-zA-Z0-9]{22}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "IT",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^IT\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "KW",
                        IsEU924 = false,
                        Lenght = 30,
    RegexStructure = @"^KW\d{2}[a-zA-Z0-9]{26}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "KZ",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^KZ\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "LB",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^LB\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "LI",
                        IsEU924 = false,
                        Lenght = 21,
    RegexStructure = @"^LI\d{2}[a-zA-Z0-9]{17}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "LT",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^LT\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "LU",
                        IsEU924 = false,
                        Lenght = 20,
    RegexStructure = @"^LU\d{2}[a-zA-Z0-9]{16}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "LV",
                        IsEU924 = false,
                        Lenght = 21,
    RegexStructure = @"^LV\d{2}[a-zA-Z0-9]{17}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MC",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^MC\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MD",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^MD\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "ME",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^ME\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MG",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^MG\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MK",
                        IsEU924 = false,
                        Lenght = 19,
    RegexStructure = @"^MK\d{2}[a-zA-Z0-9]{15}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "ML",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^ML\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MR",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^MR\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MT",
                        IsEU924 = false,
                        Lenght = 31,
    RegexStructure = @"^MT\d{2}[a-zA-Z0-9]{27}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MU",
                        IsEU924 = false,
                        Lenght = 30,
    RegexStructure = @"^MU\d{2}[a-zA-Z0-9]{26}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "MZ",
                        IsEU924 = false,
                        Lenght = 25,
    RegexStructure = @"^MZ\d{2}[a-zA-Z0-9]{21}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "NL",
                        IsEU924 = false,
                        Lenght = 18,
    RegexStructure = @"^NL\d{2}[a-zA-Z0-9]{14}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "NO",
                        IsEU924 = false,
                        Lenght = 15,
    RegexStructure = @"^NO\d{2}[a-zA-Z0-9]{11}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "PK",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^PK\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "PL",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^PL\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "PS",
                        IsEU924 = false,
                        Lenght = 29,
    RegexStructure = @"^PS\d{2}[a-zA-Z0-9]{25}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "PT",
                        IsEU924 = false,
                        Lenght = 25,
    RegexStructure = @"^PT\d{2}[a-zA-Z0-9]{21}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "QA",
                        IsEU924 = false,
                        Lenght = 29,
    RegexStructure = @"^QA\d{2}[a-zA-Z0-9]{25}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "RO",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^RO\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "RS",
                        IsEU924 = false,
                        Lenght = 22,
    RegexStructure = @"^RS\d{2}[a-zA-Z0-9]{18}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SA",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^SA\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SE",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^SE\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SI",
                        IsEU924 = false,
                        Lenght = 19,
    RegexStructure = @"^SI\d{2}[a-zA-Z0-9]{15}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SK",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^SK\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SM",
                        IsEU924 = false,
                        Lenght = 27,
    RegexStructure = @"^SM\d{2}[a-zA-Z0-9]{23}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "SN",
                        IsEU924 = false,
                        Lenght = 28,
    RegexStructure = @"^SN\d{2}[a-zA-Z0-9]{24}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "TN",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^TN\d{2}[a-zA-Z0-9]{20}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "TR",
                        IsEU924 = false,
                        Lenght = 26,
    RegexStructure = @"^TR\d{2}[a-zA-Z0-9]{22}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "UA",
                        IsEU924 = false,
                        Lenght = 29,
    RegexStructure = @"^UA\d{2}[a-zA-Z0-9]{25}$"
                    
                    }
,
new IbanData
                    {
                        CountryCode = "VG",
                        IsEU924 = false,
                        Lenght = 24,
    RegexStructure = @"^VG\d{2}[a-zA-Z0-9]{20}$"
                    
                    }

           };

        #endregion


        #region Metodos

        /// <summary>
        /// Genera un código Iban a partir de un código de pais.
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="ccc"></param>
        /// <returns></returns>
        public static string GenerateIban(string countryCode, string ccc)
        {
            string modifiedIban = ccc + countryCode + "00";

            modifiedIban = Regex.Replace(modifiedIban, @"\D",
                                         m => ((int)m.Value[0] - 55).ToString());

            string startmodifiedIban = modifiedIban.Substring(0, 2);

            modifiedIban = modifiedIban.Substring(2);

            int remainer = 0;
            while (modifiedIban.Length >= 7)
            {
                remainer = int.Parse(remainer + startmodifiedIban + modifiedIban.Substring(0, 7)) % 97;
                modifiedIban = modifiedIban.Substring(7);

                startmodifiedIban = string.Empty;
            }
            remainer = 98 - int.Parse(remainer + modifiedIban) % 97;

            return countryCode + System.Convert.ToString(remainer) + ccc;
        }

        public static void CheckIban(string iban, bool cleanText, ErrorInfo errorInfo)
        {
            //errorInfo.ErrorText = "El IBAN parece ser correcto.";
            errorInfo.ErrorType = ErrorType.Default;

            if (cleanText) // remove empty space & convert all uppercase
                iban = Regex.Replace(iban, @"\s", string.Empty).ToUpper();

            if (Regex.IsMatch(iban, @"\W"))
            {
                errorInfo.ErrorText = "El IBAN contiene caracteres no válidos.";
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            if (!Regex.IsMatch(iban, @"^\D\D\d\d.+"))
            {
                errorInfo.ErrorText = "La estructura del IBAN es erróneo.";
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            if (Regex.IsMatch(iban, @"^\D\D00.+|^\D\D01.+|^\D\D99.+"))
            {
                errorInfo.ErrorText = "Los dígitos de control del IBAN se equivocan.";
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            string countryCode = iban.Substring(0, 2);

            IbanData currentIbanData = IbanDatas.Where(id => id.CountryCode == countryCode).FirstOrDefault();

            if (!IbanDatas.Any(id => id.CountryCode == countryCode))
            {
                errorInfo.ErrorText = string.Format("IBAN para el país de {0} actualmente no está disponible.",
                                countryCode);
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            if (iban.Length != currentIbanData.Lenght)
            {
                errorInfo.ErrorText = string.Format("El IBAN de {0} debe ser {1} caracteres.",
                                countryCode, currentIbanData.Lenght);
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            if (!Regex.IsMatch(iban, currentIbanData.RegexStructure))
            {
                errorInfo.ErrorText = "La estructura específica del país IBAN es erróneo.";
                errorInfo.ErrorType = ErrorType.Critical;
                return;
            }

            string modifiedIban = iban.ToUpper().Substring(4) + iban.Substring(0, 4);
            modifiedIban = Regex.Replace(modifiedIban, @"\D",
                                          m => ((int)m.Value[0] - 55).ToString());

            string startmodifiedIban = modifiedIban.Substring(0, 2);

            modifiedIban = modifiedIban.Substring(2);

            int remainer = 0;
            while (modifiedIban.Length >= 7)
            {
                remainer = int.Parse(remainer + startmodifiedIban + modifiedIban.Substring(0, 7)) % 97;
                modifiedIban = modifiedIban.Substring(7);

                startmodifiedIban = string.Empty;
            }
            remainer = int.Parse(remainer + modifiedIban) % 97;

            if (remainer != 1)
            {
                errorInfo.ErrorText = "El IBAN es incorrecto.";
                errorInfo.ErrorType = ErrorType.Critical;
            }
        }


        #endregion


    }
}