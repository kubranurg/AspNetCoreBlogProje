﻿using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category> , ICategory
    {
    }
}
