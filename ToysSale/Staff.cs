using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public class Staff
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronumic { get; set; }
        public Department StaffDepartment { get; set; }
        public string Position { get; set; }
        public Decimal salary { get; set; }
        public DateTime DateApplyToWork { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + Patronumic;
        }
    }

    public class ControlStaff : IControlBD
    {
        IMongoDatabase Database;
        IMongoCollection<Staff> collection;

        public ControlStaff(IMongoDatabase database)
        {
            this.Database = database;
            collection = Database.GetCollection<Staff>("Nomenclature");
        }

        public void Add()
        {
            Staff staff = new Staff();
            staff.DateApplyToWork = DateTime.Now;
            FormStaff frm = new FormStaff(staff);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.InsertOne(staff);
            }
        }
        public void Remove(object o)
        {
            Staff staff = (Staff)o;
            collection.DeleteOne<Staff>(i1 => i1.Id == staff.Id);
        }
        public void Update(object o)
        {
            Staff staff = (Staff)o;
            FormStaff frm = new FormStaff(staff);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                collection.ReplaceOne<Staff>(i1 => i1.Id == staff.Id, staff);
            }
        }
        public IEnumerable<object> GetList()
        {
            var filter = new BsonDocument();
            IEnumerable<Staff> list = collection.Find(filter).ToEnumerable();
            return list;
        }

        public IEnumerable<object> GetList(BsonDocument Filter)
        {
            var filter = Filter;
            IEnumerable<Staff> list = collection.Find(filter).ToEnumerable();
            return list;
        }
    }
}