using System.Collections.Generic;

namespace zajecia13
{
    public interface IReader
    {
        List<Person> ReadPeople(string fileName);
    }
}