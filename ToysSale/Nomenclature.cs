using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Nomenclature
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
    }

    public class ControlNomenclature: IControlBD
    {
        IMongoDatabase Database;
        IMongoCollection<Nomenclature> collection;

        public ControlNomenclature(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Nomenclature>("Nomenclature");
        }

        public void Add()
        {
            Nomenclature nom = new Nomenclature();
            FormNomenclature frm= new FormNomenclature(nom);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(nom);
            }
        }
        public void Remove(object o)
        {
            Nomenclature nom = (Nomenclature)o;
            collection.DeleteOne<Nomenclature>(i1 => i1.Id == nom.Id);
        }
        public void Update(object o)
        {
            Nomenclature nom = (Nomenclature)o;
            FormNomenclature frm = new FormNomenclature(nom);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<Nomenclature>(i1 => i1.Id == nom.Id, nom);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Nomenclature> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Nomenclature> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}
