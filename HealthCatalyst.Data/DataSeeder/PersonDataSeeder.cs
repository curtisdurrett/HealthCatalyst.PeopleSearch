using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HealthCatalyst.Domain.Models;
using HealthCatalyst.Data.DataSeeder;

namespace HealthCatalyst.Data.Repository
{
    public class PersonDataSeeder : IPersonDataSeeder
    {
        private readonly DatabaseContext _databaseContext;

        public PersonDataSeeder(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int SeedData()
        {
            // Remove add records from persons table
            //var rows = from o in db.Persons
            //           select o;
            //foreach (var row in rows)
            //{
            //    db.Persons.Remove(row);
            //}
            //db.SaveChanges();

            // Add seed records to persons table
            int recordsAdded = 0;
            using (var db = new DatabaseContext())
            {
                db.Persons.Add(new Person
                {
                    FirstName = "Chris",
                    LastName = "Peele",
                    DateOfBirth = new DateTime(1974, 5, 12),
                    Interests = "old movies, Iot",
                    PictureFileName = "ChrisPeele.jpg",
                    AddressLine1 = "709 Pony Street",
                    AddressLine2 = null,
                    City = "Harker Heights",
                    State = "TX",
                    Zip = "76523"
                });

                db.Persons.Add(new Person
                {
                    FirstName = "Daniel",
                    LastName = "Durrett",
                    DateOfBirth = new DateTime(2002, 2, 21),
                    Interests = "welding, computer games",
                    PictureFileName = "DanielDurrett.jpg",
                    AddressLine1 = "3309 De Leon Cir",
                    AddressLine2 = null,
                    City = "Belton",
                    State = "TX",
                    Zip = "76513"
                });

                db.Persons.Add(new Person
                {
                    FirstName = "Christopher",
                    LastName = "Durrett",
                    DateOfBirth = new DateTime(2004, 6, 8),
                    Interests = "reading, chess, band",
                    PictureFileName = "ChristopherDurrett.jpg",
                    AddressLine1 = "3309 DeLeon Cir",
                    AddressLine2 = null,
                    City = "Belton",
                    State = "TX",
                    Zip = "76513"
                });

                recordsAdded = db.SaveChanges();
            } 

            return recordsAdded;   
        }
    }
}
