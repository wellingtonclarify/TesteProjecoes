using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProjecoes.Model.Extensions
{
    public static class ObjectExtensions
    {
        public static T Clone<T>(this T obj) where T : class
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            T rCopy = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            return rCopy;
        }
    }
}
