using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zajecia13
{
    public class IOFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string[] allData = File.ReadAllLines(fileName);
            var people = allData
                .Select(line => CSVStringToPersonConverter.Convert(line));

            return people.ToList();
        }
    }
}