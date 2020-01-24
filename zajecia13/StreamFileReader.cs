using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zajecia13
{
    public class StreamFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            using var reader = new StreamReader(fileName);
            string data = reader.ReadToEnd();
            string[] lines = data.Split(
                new []{'\n', '\r'}, 
                StringSplitOptions.RemoveEmptyEntries
                );
            var people = lines
                .Select(line => CSVStringToPersonConverter.Convert(line));

            return people.ToList();
        }
    }
}