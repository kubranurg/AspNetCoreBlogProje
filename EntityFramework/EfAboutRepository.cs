using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrate;

namespace DataAcessLayer.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>,IAbout
    {
    }
}
