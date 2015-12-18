using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public delegate void SelectionMade(object obj);

    public interface IControlBD
    {
        void Add();
        void Update(object o);
        void Remove(object o);
        IEnumerable<object> GetList();
    }

    class ToysSale
    {
        public static IMongoDatabase dbToySale;
        public static bool ConnState;
    }
}
