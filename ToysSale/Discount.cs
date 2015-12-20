using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Discount
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountValue { get; set; }

        public override string ToString()
        {
            return Name + " " + DiscountValue.ToString();
        }
    }
    public class ControlDiscount : IControlBD
    {
        IMongoDatabase Database;
        IMongoCollection<Discount> collection;

        public ControlDiscount(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Discount>("Discount");
        }

        public void Add()
        {
            Discount dc = new Discount();
            FormDiscount frm = new FormDiscount(dc);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(dc);
            }
        }
        public void Remove(object o)
        {
            Discount dc = (Discount)o;
            collection.DeleteOne<Discount>(i1 => i1.Id == dc.Id);
        }
        public void Update(object o)
        {
            Discount dc = (Discount)o;
            FormDiscount frm = new FormDiscount(dc);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<Discount>(i1 => i1.Id == dc.Id, dc);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Discount> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Discount> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}
