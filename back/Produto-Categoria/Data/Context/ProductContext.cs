using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ProductContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ProductContext():base("Data Source=192.168.0.186;Initial Catalog=Product/Category;Persist Security Info=True;User ID=ProdCat;Password=@123321")
        {

        }
    }
}
