using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace zajecia13
{
    public class Writer
    {
        public void WriteToFile(Person person, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);
            writer.Write($"[{person.Id}] [{person.Name}] [{person.Surname}] [{person.Phone}]");
        }

        public void WritePhoneNumberToFile(Person person, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);
            writer.Write($"{person.Phone} \n");
        }

        public void WritePhoneNumberToFile(IEnumerable<Person> people, string fileName)
        {
            foreach (var person in people)
            {
                WritePhoneNumberToFile(person, fileName);
            }
        }

        public void WritePhonesInGroupsOfTen(IEnumerable<Person> people)
        {
            int i = 0;
            string folder = "phone-number-groups/";
            string fileName = "group-nr-" + (i+1);
            StreamWriter writer= new StreamWriter(folder + fileName, true);
            writer.Close();
            
            foreach (var person in people)
            {
                if (i % 10 == 0)
                {
                    int j = i / 10;
                    fileName = "group-nr-" + j;
                    writer = new StreamWriter(folder + fileName, true);
                }   
                
                writer.Write($"{person.Phone} \n");

                if (i % 10 == 9)
                {
                    writer.Close();
                }

                i += 1;
            }
            
        }
    }
}