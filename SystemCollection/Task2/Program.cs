using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими
//продукции.Из коллекции можно получать категории товаров, которые купил покупатель или по
//категории определить покупателей.
namespace Task2
{
    
    class Program
    {
        static List<Buyer> GetUserByProduct(Dictionary<Buyer, List<Product>> dictionary, Product product)
        {
            List<Buyer> buyers = new List<Buyer>();
            foreach (var item in dictionary)
            {
                if (item.Value.Contains(product))
                {
                    buyers.Add(item.Key);
                }
            }
            return buyers;
        }

        static void Main(string[] args)
        {
            Buyer buyer0 = new Buyer("Евгений", "Анищенко");
            var buyer1 = new Buyer("Денис", "Селиванов");
            var buyer2 = new Buyer("Дмитрий", "Постоялкин");
            var buyer3 = new Buyer("Елена", "Иванова");
            Dictionary<Buyer, List<Product>> dictionary = new Dictionary<Buyer, List<Product>>();
            dictionary.Add(buyer0, new List<Product>() { Product.Food, Product.Clothes, Product.SportInvertary });
            dictionary.Add(buyer1, new List<Product>() { Product.Food, Product.Alcohol, Product.SportInvertary });
            dictionary.Add(buyer2, new List<Product>() { Product.Food, Product.Shoe, Product.SportInvertary });
            dictionary.Add(buyer3, new List<Product>() { Product.Food, Product.Shoe, Product.Clothes, Product.Cosmetic });
            foreach (var item in dictionary)
            {
                Console.Write("{0}:", item.Key.FullName);
                foreach (var prod in (List<Product>)item.Value)
                {
                    Console.Write(prod + ","); ;
                }
                Console.WriteLine("");
            }
            Console.WriteLine(new string('-', 20));

            var user = GetUserByProduct(dictionary, Product.Alcohol);
            foreach (var item in user)
            {
                Console.WriteLine(item.FullName);
            }
            Console.ReadKey();
        }
        
    }
}
