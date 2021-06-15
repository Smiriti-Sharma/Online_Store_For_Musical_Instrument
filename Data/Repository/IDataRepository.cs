using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_For_Musical_Instrument.Data.Repository;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Data.Repository
{
    public interface IDataRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Delete(int id);
        bool Update(Product item);
    }
}
