using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Facturas.BizzRules
{
    public class Util
    {
        public static void CopiarPropiedadesTipo<T1, T2>(T1 origen, T2 destino)
        {
            Type tipoPropiedad = null;
            System.Reflection.PropertyInfo pdestino = null;
            foreach (System.Reflection.PropertyInfo var in origen.GetType().GetProperties())
            {
                pdestino = destino.GetType().GetProperty(var.Name);
                if (var.CanRead && pdestino != null && pdestino.CanWrite)
                {
                    object valor = var.GetValue(origen, null);
                    tipoPropiedad = pdestino.PropertyType;
                    if (valor != null)
                    {
                        if (tipoPropiedad.IsEnum)
                        {
                            pdestino.SetValue(destino, Enum.Parse(tipoPropiedad, valor.ToString()), null);
                        }
                        else if (tipoPropiedad.IsArray)
                        {
                            Type tiarr = Type.GetType(tipoPropiedad.FullName, true);
                            object[] avalor = valor as object[];

                            pdestino.SetValue(destino, Activator.CreateInstance(tiarr, new object[] { avalor.Length }), null);


                            object[] nuevoarray = pdestino.GetValue(destino, null) as object[];
                            //copiamos por reflexion los objetos que cuelgan
                            object vi = null;
                            for (int i = 0; i < avalor.Length; i++)
                            {
                                vi = avalor[i];
                                if (vi is ICloneable)
                                {
                                    nuevoarray[i] = ((ICloneable)vi).Clone();
                                }
                            }
                        }
                        else if (valor is IConvertible)
                        {
                            pdestino.SetValue(destino, ChangeType(valor, tipoPropiedad), null);
                        }
                        else if (valor is ICloneable)
                        {
                            pdestino.SetValue(destino, ((ICloneable)valor).Clone(), null);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Nueva version de Conver.ChangeType que es capaz de trabajar con tipos nulables.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="conversionType"></param>
        /// <returns></returns>
        public static object ChangeType(object value, Type conversionType)
        {
            // Note: This if block was taken from Convert.ChangeType as is, and is needed here since we're
            // checking properties on conversionType below.
            if (conversionType == null)
            {
                throw new ArgumentNullException("conversionType");
            } // end if

            // If it's not a nullable type, just pass through the parameters to Convert.ChangeType


            if (conversionType.IsGenericType &&
                conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                // It's a nullable type, so instead of calling Convert.ChangeType directly which would throw a
                // InvalidCastException (per http://weblogs.asp.net/pjohnson/archive/2006/02/07/437631.aspx),
                // determine what the underlying type is
                // If it's null, it won't convert to the underlying type, but that's fine since nulls don't really
                // have a type--so just return null
                // Note: We only do this check if we're converting to a nullable type, since doing it outside
                // would diverge from Convert.ChangeType's behavior, which throws an InvalidCastException if
                // value is null and conversionType is a value type.
                if (value == null)
                {
                    return null;
                } // end if

                // It's a nullable type, and not null, so that means it can be converted to its underlying type,
                // so overwrite the passed-in conversion type with this underlying type
                NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            } // end if

            // Now that we've guaranteed conversionType is something Convert.ChangeType can handle (i.e. not a
            // nullable type), pass the call on to Convert.ChangeType
            return Convert.ChangeType(value, conversionType);
        }

    }
}
