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
            sort["white"] = "#FFFFFF";
            sort["silver"] = "#C0C0C0";
            sort["gray"] = "#808080";
            sort["black"] = "000000";

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine("{0} {1}",item.Key ,item.Value);
            }

            sort = new SortedList();
            sort["white"] = "#FFFFFF";
            sort["silver"] = "#C0C0C0";
            sort["gray"] = "#808080";
            sort["black"] = "000000";

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Класс для сравнения объектов,Icomparer - предоставляет метод для сравнения
        /// </summary>
        public class DescCompare : IComparer
        {
            /// <summary>
            /// Сравнивает два объекта без учета регистра строк
            /// </summary>
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object x, object y)
            {
                //y & x меняем местами для убывания
                return comparer.Compare(y,x);
            }
        }
    }
}
