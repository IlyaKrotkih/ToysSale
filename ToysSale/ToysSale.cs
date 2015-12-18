using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public delegate void SelectionMade(object obj);

    class ToysSale
    {
        public static IMongoDatabase dbToySale;
        public static bool ConnState;
    }
}
