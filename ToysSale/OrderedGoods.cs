using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class OrderedGoods
    {
        public ObjectId Id { get; set; }
        public Nomenclature GoodsNomenclature { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WhosalePrice { get; set; }
        public int Count { get; set; }
        public DateTime DateDeparture { get; set; }
        public DateTime DateRecive { get; set; }
        public bool IsComplite { get; set; }

        public override string ToString()
        {
            if (GoodsNomenclature != null)
            {
                if (IsComplite == true) return "Поставка от " + DateDeparture.Date.ToShortDateString() + ", " + GoodsNomenclature.ToString() + " (оприходована)";
                else return "Поставка от " + DateDeparture.Date.ToShortDateString() + ", " + GoodsNomenclature.ToString();
            }
            else
                return "Поставка от " + DateDeparture.Date.ToShortDateString();
        }
    }

    public class ControlOrderedGoods : IControlBD
    {
        IMongoDatabase Database;
        public IMongoCollection<OrderedGoods> collection;

        public ControlOrderedGoods(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<OrderedGoods>("OrderedGoods");
        }

        public void Add()
        {
            OrderedGoods og = new OrderedGoods();
            og.DateDeparture = og.DateRecive = DateTime.Now;
            og.IsComplite = false;
            FormOrderedGoods frm = new FormOrderedGoods(og);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(og);
            }
        }
        public void Remove(object o)
        {
            OrderedGoods og = (OrderedGoods)o;
            collection.DeleteOne<OrderedGoods>(i1 => i1.Id == og.Id);
        }
        public void Update(object o)
        {
            OrderedGoods og = (OrderedGoods)o;
            FormOrderedGoods frm = new FormOrderedGoods(og);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<OrderedGoods>(i1 => i1.Id == og.Id, og);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<OrderedGoods> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<OrderedGoods> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}