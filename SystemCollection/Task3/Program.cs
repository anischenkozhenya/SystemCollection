using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и
//вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Dictionary<int, double> corp = new Dictionary<int, double>();
            corp.Add(random.Next(1000,9999),random.NextDouble()*100);
            corp.Add(random.Next(1000, 9999), random.NextDouble()*100);
            corp.Add(random.Next(1000, 9999), random.NextDouble()*100);
            foreach (var item in corp)
            {
                Console.WriteLine("{0} {1} млн$",item.Key,item.Value);
            }
            Console.WriteLine(new string('_',20));
            SortedDictionary<int, double> corp2 = new SortedDictionary<int, double>();
            corp2.Add(random.Next(1000, 9999), random.NextDouble() * 100);
            corp2.Add(random.Next(1000, 9999), random.NextDouble() * 100);
            corp2.Add(random.Next(1000, 9999), random.NextDouble() * 100);
            foreach (var item in corp2)
            {
                Console.WriteLine("{0} {1} млн$", item.Key, item.Value);
            }            
            Console.ReadKey();
        }
    }
}
