using DataAcessLayer.Abstract;
using DataAcessLayer.Concrate;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blogs>, IBlog
    {
        public List<Blogs> GetListWithCategory()
        {
            using (var db = new Context())
            {
                return db.Blogs.Include(x => x.Categories).ToList();
            }
             
        }
    }
}
