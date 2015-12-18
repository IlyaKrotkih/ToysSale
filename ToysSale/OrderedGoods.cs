using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    class OrderedGoods
    {
        public ObjectId Id { get; set; }
        public Nomenclature GoodsNomenclature { get; set; }
        public decimal price { get; set; }
        public decimal WhosalePrice { get; set; }
        public int count { get; set; }
    }
}
