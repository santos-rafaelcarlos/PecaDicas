using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDica.App.Common
{
    public static class ConverterHelper<TipoA, TipoB>
    {
        public static TipoB ConvertAParaB(TipoA item)
        {
            TipoB retVal = Activator.CreateInstance<TipoB>();

            foreach (var propertyA in typeof(TipoA).GetProperties())
                foreach (var propertyB in typeof(TipoB).GetProperties())
                {
                    if (propertyA.Name != propertyB.Name
                        || propertyA.PropertyType != propertyB.PropertyType)
                        continue;

                    Object value = propertyA.GetValue(item, null);

                    propertyB.SetValue(retVal, value, null);
                }

            return retVal;
        }

        public static IEnumerable<TipoB> ConvertAParaB(IEnumerable<TipoA> items)
        {
            List<TipoB> retVal = new List<TipoB>();

            foreach (var item in items)
               retVal.Add(ConvertAParaB(item));

            return retVal;
        }
    } 
}