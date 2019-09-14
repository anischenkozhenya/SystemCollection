using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя класс SortedList, создайте небольшую коллекцию
//и выведите на экран значения пар «ключ- значение»
//сначала в алфавитном порядке, а затем в обратном.
namespace Task1
{    
     class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortedList();
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine("{0} {1}",item.Key ,item.Value);
            }
            sort = new SortedList(new DescCompare());
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
        public class DescCompare : IComparer
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object x, object y)
            {
                return comparer.Compare(y,x);
            }
        }
    }
}
