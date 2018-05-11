using System.Collections.Generic;
using System.Linq;

namespace TesteProjecoes.Model.Extensions
{
    public static class BaseModelExtensions
    {
        public static T GetById<T>(this IList<T> list, int id) where T : BaseModel
        {
            return list.SingleOrDefault(l => l.Id == id);
        }
    }
}
