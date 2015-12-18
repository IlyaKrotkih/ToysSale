using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    class Nomenclature
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
    }
}
