using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Sale
    {
        public ObjectId Id { get; set; }
        public Staff ResponsibleStaff { get; set; }
        public Client SaleClient { get; set; }
        public decimal SummGoods { get; set; }
        public List<BasketItem> Basket { get; set; }
        public DateTime SaleDate { get; set; }

        public override string ToString()
        {
            return "Покупка от: " + SaleDate.ToString() + ", на сумму: " + SummGoods.ToString();
        }
    }

    public class ControlSale : IControlBD
    {
        IMongoDatabase Database;
        public IMongoCollection<Sale> collection;
        Staff staff;

        public ControlSale(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Sale>("Sale");
        }

        public  void SetStaff(object o)
        {
            this.staff = o as Staff;
        }

        public void Add()
        {
            Sale s = new Sale();
            s.SaleDate = DateTime.Now;
            s.ResponsibleStaff = staff;
            FormSale frm = new FormSale(s, false);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK && s.SummGoods > 0)
            {
                collection.InsertOne(s);

                ControlExistingGoods controlEG = new ControlExistingGoods(ToysSale.dbToySale);
                List<ExistingGoods> ListEG = controlEG.GetList()
                    .Select<object, ExistingGoods>(i1 => (ExistingGoods)i1)
                    .ToList<ExistingGoods>();
                foreach (BasketItem bi in s.Basket)
                {
                    ExistingGoods eg = ListEG.Single(i1 => i1.GoodsNomenclature.Id == bi.BasketNomenclature.Id);
                    if (eg.count - bi.Count == 0)
                        controlEG.Remove(eg);
                    else
                    {
                        eg.count -= bi.Count;
                        controlEG.collection.ReplaceOne<ExistingGoods>(i1 => i1.Id == eg.Id, eg);
                    }
                }
            }
        }
        public void Remove(object o)
        {
            Sale s = (Sale)o;
            collection.DeleteOne<Sale>(i1 => i1.Id == s.Id);
        }
        public void Update(object o)
        {
            Sale s = (Sale)o;
            FormSale frm = new FormSale(s,true);
            frm.ShowDialog();
            //if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    collection.ReplaceOne<Sale>(i1 => i1.Id == s.Id, s);
            //}
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Sale> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Sale> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}