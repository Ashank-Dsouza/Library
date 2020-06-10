using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IService
    {
        List<string> GetListOfGenre(string genre);
        List<string> GetBookDetails(int id);
    }
}
