using AdarshBookstore.DataAccess.Data;
using AdarshBookstore.DataAccess.Repository.IRepository;
using AdarshBookstore.DataAccess.Repository;
using AdarshBookstore.Models;
using AdarshBookstore.DataAccess.Repository.IRepository;
using AdarshBookstore.Models;
using AdarshBookstore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdarshBookstore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.ID == category.ID);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
            }
        }
    }
}