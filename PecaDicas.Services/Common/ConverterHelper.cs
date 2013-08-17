using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDicas.Services.Common
{
    internal static class ConverterHelper<T>
    {
        internal static T TryConverter(object obj)
        {
            T item = (T)obj;

            if (item == null)
                throw new ConverterException();

            return item;
        }
    }

    internal class ConverterException : Exception
    {
        public ConverterException()
            :base("Tipo inválido")
        {
            
        }
    }
}