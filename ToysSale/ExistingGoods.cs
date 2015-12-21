using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class ExistingGoods
    {
        public ObjectId Id { get; set; }
        public Nomenclature GoodsNomenclature { get; set; }
        public decimal price { get; set; }
        public int count { get; set; }

        public override string ToString()
        {
            if (GoodsNomenclature != null)
                return GoodsNomenclature.ToString();
            else return "";
        }
    }
    public class ControlExistingGoods : IControlBD
    {
        IMongoDatabase Database;
        public IMongoCollection<ExistingGoods> collection;

        public ControlExistingGoods(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<ExistingGoods>("ExistingGoods");
        }

        public void Add()
        {
            ExistingGoods eg = new ExistingGoods();
            FormGoods frm = new FormGoods(eg);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(eg);
            }
        }
        public void Remove(object o)
        {
            ExistingGoods eg = (ExistingGoods)o;
            collection.DeleteOne<ExistingGoods>(i1 => i1.Id == eg.Id);
        }
        public void Update(object o)
        {
            ExistingGoods eg = (ExistingGoods)o;
            FormGoods frm = new FormGoods(eg);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<ExistingGoods>(i1 => i1.Id == eg.Id, eg);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<ExistingGoods> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<ExistingGoods> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        private string Debet(IEnumerable<OrderedGoods> todebet, ControlOrderedGoods controldb)
        {
            ControlOrderedGoods controlOrderedgoods = controldb;
            IEnumerable<OrderedGoods> ToDebet = todebet;
            IEnumerable<ExistingGoods> ListExistingGoods = GetList().Select<object, ExistingGoods>(i1 => i1 as ExistingGoods);
            List<ExistingGoods> ListCompliteAdd = new List<ExistingGoods>();
            List<ExistingGoods> ListCompliteUpgate = new List<ExistingGoods>();
            foreach (OrderedGoods og in ToDebet)
            {
                ExistingGoods ex;
                try { ex = ListExistingGoods.Single(i1 => i1.GoodsNomenclature.Id == og.GoodsNomenclature.Id); }
                catch { ex = null; }
                if (ex == null)
                {
                    ex = new ExistingGoods
                    {
                        GoodsNomenclature = og.GoodsNomenclature,
                        price = og.RetailPrice,
                        count = og.Count
                    };
                    collection.InsertOne(ex);
                    ListCompliteAdd.Add(ex);
                }
                else
                {
                    ex.GoodsNomenclature = og.GoodsNomenclature;
                    ex.price = (ex.price * Convert.ToDecimal(ex.count) + og.RetailPrice * Convert.ToDecimal(og.Count)) / Convert.ToDecimal(ex.count + og.Count);
                    ex.count += og.Count;
                    collection.ReplaceOne<ExistingGoods>(i1 => i1.Id == ex.Id, ex);
                    ListCompliteUpgate.Add(ex);
                }
                og.IsComplite = true;
                controlOrderedgoods.collection.ReplaceOne<OrderedGoods>(i1 => i1.Id == og.Id, og);
            }
            return "Оприходовано:\n    " + ListCompliteAdd.Count.ToString() + " новых наименований;\n    " + ListCompliteUpgate.Count.ToString() + " имеюшихся наименований.";
        }

        public string QDebetOrderedGoods()
        {
            ControlOrderedGoods controlOrderedgoods = new ControlOrderedGoods(ToysSale.dbToySale);
            IEnumerable<OrderedGoods> ListCompliteOrderedGoods = controlOrderedgoods.GetList()
                .Select<object, OrderedGoods>(i1 => i1 as OrderedGoods)
                .Where<OrderedGoods>(i1 => i1.DateRecive <= DateTime.Now && i1.IsComplite == false);
            return Debet(ListCompliteOrderedGoods, controlOrderedgoods);
        }

        public string FormDebetOrderedGoods()
        {
            ControlOrderedGoods controlOrderedgoods = new ControlOrderedGoods(ToysSale.dbToySale);
            IEnumerable<OrderedGoods> ListOrderedGoods = controlOrderedgoods.GetList()
                .Select<object, OrderedGoods>(i1 => i1 as OrderedGoods)
                .Where<OrderedGoods>(i1 => i1.IsComplite == false);
            List<OrderedGoods> ListToDebetGoods = new List<OrderedGoods>();
            FormDebetGoods frm = new FormDebetGoods(ListOrderedGoods, ListToDebetGoods);
            frm.ShowDialog();
            return Debet(ListOrderedGoods, controlOrderedgoods);
        }
    }
}