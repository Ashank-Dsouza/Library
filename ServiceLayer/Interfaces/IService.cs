using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IService
    {
        GenreList GetListOfGenre(string genre);
        BookDetails GetBookDetails(int id);
    }
}
