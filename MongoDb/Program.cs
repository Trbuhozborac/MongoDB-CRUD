using System;

namespace MongoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Dusan",
            //    LastName = "Mihajlovic",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "Petra Konjovica 12",
            //        City = "Zabalj",
            //        State = "Serbia",
            //        ZipCode = "21230"
            //    }
            //};
            //db.InsertRecord("Users", person);

            var recs = db.LoadRecords<NameModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");
                Console.WriteLine();
            }

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName} {rec.LastName}");

            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }

            //    Console.WriteLine();
            //}
            // var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("d326ee5c-a05e-4b95-91f4-50e4aba443be"));
            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecords("Users", oneRec.Id, oneRec);
            // db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }


}
