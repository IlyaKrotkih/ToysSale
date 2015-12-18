using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Department
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ControlDepartment : IControlBD
    {
        IMongoDatabase Database;
        IMongoCollection<Department> collection;

        public ControlDepartment(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Department>("Department");
        }

        public void Add()
        {
            Department dep = new Department();
            FormDepartment frm = new FormDepartment(dep);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(dep);
            }
        }
        public void Remove(object o)
        {
            Department nom = (Department)o;
            collection.DeleteOne<Department>(i1 => i1.Id == nom.Id);
        }
        public void Update(object o)
        {
            Department dep = (Department)o;
            FormDepartment frm = new FormDepartment(dep);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<Department>(i1 => i1.Id == dep.Id, dep);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Department> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Department> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}
