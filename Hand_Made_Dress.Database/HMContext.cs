using Hand_Made_Dress.Entities;
using System.Data.Entity;

namespace Hand_Made_Dress.Database
{
    class HMContext: DbContext
    {
        public HMContext():base("DefaultConnection")
        {
        }

        public DbSet<Products> Productses { get; set; }
        public DbSet<Categories> Categorieses { get; set; }
    }
}
