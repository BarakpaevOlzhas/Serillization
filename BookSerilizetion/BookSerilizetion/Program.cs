using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BookSerilizetion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> TestBooks = new List<Book>
            {
                new Book
                {
                    Name = "BookOne",
                    Price = 2000,
                    Avtor = "Chelovek",
                    Year = 1940
                },
                new Book
                {
                    Name = "BookTwo",
                    Price = 23422,
                    Avtor = "NeChelovek",
                    Year = 2001
                },
                new Book
                {
                    Name = "BookThree",
                    Price = 2000,
                    Avtor = "ChelovekPayk",
                    Year = 2222
                },
            };

            BinaryFormatter formatter = new BinaryFormatter();            

            if (!Directory.Exists(@"C:/data"))
            {
                Directory.CreateDirectory(@"C:/data");
            }

            using (FileStream file = File.Create(@"C:/data/Books.bin"))
            {
                formatter.Serialize(file, TestBooks);
            }

            using (FileStream file = File.OpenRead(@"C:/data/Books.bin"))
            {
                var result = formatter.Deserialize(file) as List<Book>;
                foreach (var book in result)
                {
                    Console.WriteLine(book.Name);
                }
            }

            

        }
    }
}
