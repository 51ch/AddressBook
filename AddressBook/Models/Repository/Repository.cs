using System.Collections.Generic;

namespace AddressBook.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Record> Records
        {
            get { return context.Records; }
        }

        public void SaveRecord(Record record)
        {
            if (record.Id == 0)
            {
                context.Records.Add(record);
            }
            else
            {
                Record dbRecord = context.Records.Find(record.Id);
                if (dbRecord != null)
                {
                    dbRecord.FirstName = record.FirstName;
                    dbRecord.MiddleName = record.MiddleName;
                    dbRecord.LastName = record.LastName;
                    dbRecord.Email = record.Email;
                    dbRecord.Phone = record.Phone;
                }
            }
            context.SaveChanges();
        }

        public void DeleteRecord(Record record)
        {
            context.Records.Remove(record);
            context.SaveChanges();
        }
    }
}