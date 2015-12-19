using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Client
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronumic { get; set; }
        public DateTime DateRegistration { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + Patronumic;
        }
    }
    public class ControlClient : IControlBD
    {
        IMongoDatabase Database;
        IMongoCollection<Client> collection;

        public ControlClient(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Client>("Client");//Незабыть переименовать коллекцию
        }

        public void Add()
        {
            Client cl = new Client();
            cl.DateRegistration = DateTime.Now;
            FormClient frm = new FormClient(cl);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(cl);
            }
        }
        public void Remove(object o)
        {
            Client cl = (Client)o;
            collection.DeleteOne<Client>(i1 => i1.Id == cl.Id);
        }
        public void Update(object o)
        {
            Client cl = (Client)o;
            FormClient frm = new FormClient(cl);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<Client>(i1 => i1.Id == cl.Id, cl);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Client> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Client> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}
