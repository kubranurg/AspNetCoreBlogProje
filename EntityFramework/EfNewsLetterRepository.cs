﻿using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.EntityFramework
{
   public class EfNewsLetterRepository : GenericRepository<NewsLetter>,INewsLetter
    {

    }
}
