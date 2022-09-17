using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Abstract
{
    public interface IMessage2 : IGeneric<Message2>
    {
        List<Message2> GetListWithMessage2ByWriter(int id);
        List<Message2> GetSendBoxWthMessage2BtWriter(int id);
    }
}
