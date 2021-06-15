using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_Store_For_Musical_Instrument.Data.Repository;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Data.DataManager
{
    public class ProductManager : IDataRepository
    {
        private List<Product> data = new List<Product>
        {
            new Product {ProductId = 1,
                        ProductName = "Guitar",
                        CategoryId = 1,
                        Brand="Belear",
                        Price=3000,
                        ProductDescription="Acoustic Guitar,Model Number: 41C, Inch BLK Series: Vega",
                        QuantityOnHand=6,
                        ProductImage="~/Content/Images/AcousticGuitar.jpg"
                        },
            new Product {ProductId = 2,
                        ProductName = "Drum",
                        CategoryId = 2,
                        Brand="Yamaha",
                        Price=47000,
                        ProductDescription="Acoustic Drum,RDP2F5 Burgundy Glitter Rydeen Acoustic Drum Kit",
                        QuantityOnHand=3,
                        ProductImage="~/Content/Images/AcousticDrum.jpg"
                        },
         };

        private static ProductManager repo = new ProductManager();
        public static IDataRepository getRepository()
        { return repo; }
        public IEnumerable<Product> GetAll()
        {
            return data;
        }

        public Product Get(int id)
        {
            var matches = data.Where(r => r.ProductId == id);
            return matches.Count() > 0 ? matches.First() : null;
        }
        public Product Add(Product item)
        {
            item.ProductId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            Product item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public bool Update(Product entity)
        {
            Product product = Get(entity.ProductId);
            if (product != null)
            {
                product.ProductName = entity.ProductName;
                product.Price = entity.Price;
                product.Brand = entity.Brand;
                product.ProductDescription = entity.ProductDescription;
                product.QuantityOnHand = entity.QuantityOnHand;
                product.ProductImage = entity.ProductImage;
                product.CategoryId = entity.CategoryId;
                product.Category = entity.Category;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}