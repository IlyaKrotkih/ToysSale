using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    class Sale
    {
        public ObjectId Id { get; set; }
        public Client SaleClient { get; set; }
        public decimal SummGoods { get; set; }
        public List<ExistingGoods> Basket { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
