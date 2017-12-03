using System;

using HealthCatalyst.Data;

// To create database
// Run dotnet ef migrations add InitialCreate
// Run dotnet ef database update

// To dump records in DB
// Run dotnet run

namespace HealthCatalyst.CreateSQLiteDB
{
    class Program
    {
        public static void Main()
        {

            DumpRecords();

        }

        public static void DumpRecords() 
        {
            using (var db = new DatabaseContext())
            {
                Console.WriteLine();
                Console.WriteLine("All persons in database:");
                foreach (var person in db.Persons)
                {
                    Console.WriteLine(" - {0}, {1}", person.LastName, person.FirstName);
                }
            }          
        }
    }
}
