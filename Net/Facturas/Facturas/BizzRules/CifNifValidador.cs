using System;

namespace Facturas.BizzRules
{
    public class CifNifValidador
    {
        public static bool ValidarCifNifNie(string cadena)
        {
            cadena = cadena.ToUpper();
            return cadena.Length == 9 && ValidateCif(cadena) || ValidarNif(cadena);
        }

        public static bool ValidarNif(string nif)
        {
            return nif.Length == 9 && LetraNif(nif.Substring(0, 8)).Equals(nif[nif.Length - 1]);
        }

        /// <summary> Tabla de asignación. </summary>
        public static string Correspondencia = "TRWAGMYFPDXBNJZSQVHLCKET";

        /// <summary> Genera la letra correspondiente a un DNI. </summary>
        /// <param name="dni"> DNI a procesar. </param>
        /// <returns> Letra correspondiente al DNI. </returns>
        public static char LetraNif(string dni)
        {
            int n;

            if ((dni == null) || (dni.Length != 8) || (!int.TryParse(dni, out n)))
            {
                throw new ArgumentException("El DNI debe contener 8 dígitos.");
            }

            return Correspondencia[n % 23];
        }

        /// <summary> Genera la letra correspondiente a un NIE. </summary>
        /// <param name="nie"> NIE a procesar. </param>
        /// <returns> Letra correspondiente al NIE. </returns>
        public static char LetraNie(string nie)
        {
            int n;

            if ((nie == null) || (nie.Length != 8) || ((char.ToUpper(nie[0]) != 'X') && (char.ToUpper(nie[0]) != 'Y') && (char.ToUpper(nie[0]) != 'Z')) || (!int.TryParse(nie.Substring(1), out n)))
            {
                throw new ArgumentException("El NIE debe comenzar con la letra X, Y o Z seguida de 7 dígitos.");
            }

            switch (char.ToUpper(nie[0]))
            {
                case 'X':
                    return Correspondencia[n % 23];
                case 'Y':
                    return Correspondencia[(10000000 + n) % 23];
                case 'Z':
                    return Correspondencia[(20000000 + n) % 23];
                default:
                    return '\0';
            }
        }

        public static bool ValidateCif(string cif)
        {
            cif = cif.Replace(" ", string.Empty).Replace("-", string.Empty);

            if (string.IsNullOrEmpty(cif)) return false;
            cif = cif.Trim().ToUpper();

            //Debe tener una longitud igual a 9 caracteres;
            if (cif.Length != 9) return false;
            // ... y debe comenzar por una letra, la cual pasamos a mayúscula, ... 
            // 
            string firstChar = cif.Substring(0, 1);
            // ...que necesariamente deberá de estar comprendida en 
            // el siguiente intervalo: ABCDEFGHJNPQRSUVW 
            // 
            string cadena = "ABCDEFGHJNPQRSUVW";
            if (cadena.IndexOf(firstChar) == -1) return false;
            try
            {
                Int32 sumaPar = default(Int32);
                Int32 sumaImpar = default(Int32);
                // A continuación, la cadena debe tener 7 dígitos + el dígito de control. 
                // 
                string cifSinControl = cif.Substring(0, 8);
                string digits = cifSinControl.Substring(1, 7);
                for (Int32 n = 0; n <= digits.Length - 1; n += 2)
                {
                    if (n < 6)
                    {
                        // Sumo las cifras pares del número que se corresponderá 
                        // con los caracteres 1, 3 y 5 de la variable «digits». 
                        // 
                        sumaPar += Convert.ToInt32(digits[n + 1].ToString());
                    }
                    // Multiplico por dos cada cifra impar (caracteres 0, 2, 4 y 6). 
                    // 
                    Int32 dobleImpar = 2 * Convert.ToInt32(digits[n].ToString());
                    // Acumulo la suma del doble de números impares. 
                    // 
                    sumaImpar += (dobleImpar % 10) + (dobleImpar / 10);
                }
                // Sumo las cifras pares e impares. 
                // 
                Int32 sumaTotal = sumaPar + sumaImpar;
                // Me quedo con la cifra de las unidades y se la resto a 10, siempre 
                // y cuando la cifra de las unidades sea distinta de cero 
                // 
                sumaTotal = (10 - (sumaTotal % 10)) % 10;
                // Devuelvo el Dígito de Control dependiendo del primer carácter 
                // del NIF pasado a la función. 
                //
                string digitoControl;
                switch (firstChar)
                {
                    case "N":
                    case "P":
                    case "Q":
                    case "R":
                    case "S":
                    case "W":
                        // NIF de entidades cuyo dígito de control se corresponde 
                        // con una letra. 
                        // 
                        // Al estar los índices de los arrays en base cero, el primer 
                        // elemento del array se corresponderá con la unidad del número 
                        // 10, es decir, el número cero. 
                        // 
                        char[] characters = { 'J', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
                        digitoControl = characters[sumaTotal].ToString();
                        break;
                    default:
                        // NIF de las restantes entidades, cuyo dígito de control es un número. 
                        // 
                        digitoControl = sumaTotal.ToString();
                        break;
                }
                return digitoControl.Equals(cif.Substring(8, 1));
            }
            catch (Exception)
            {
                // Cualquier excepción producida, devolverá false. 
                return false;
            }
        }
    }
}
