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
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2
    {
        public List<Message2> GetSendBoxWthMessage2BtWriter(int id)
        {
            using(var db = new Context())
            {
                return db.Message2s.Include(x => x.ReceiverUser).Where(y => y.SenderID == id).ToList();
            }
        }
        public List<Message2> GetListWithMessage2ByWriter(int id)
        {
            using(var db = new Context())
            {
                return db.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }
}
