using System;
using System.Linq;

namespace zajecia13
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("data.txt");

            var sortedPeople = people
                .OrderBy(person => person.Surname)
                .ThenBy(person => person.Name);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }
            
            Writer writer = new Writer();
            writer.WriteToFile(sortedPeople.First(), "result.txt");
            writer.WritePhoneNumberToFile(sortedPeople.First(), "phones.txt");
            
            writer.WritePhoneNumberToFile(sortedPeople, "phones2.txt");
            writer.WritePhonesInGroupsOfTen(sortedPeople);
            writer.WritePhonesBySurname(sortedPeople);
        }
    }
}