using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ 
class DictionaryCollection
        {
            static void Main()
            {
                Dictionary<string, int> priceList = new Dictionary<string, int>();
                priceList.Add("Pizza", 15);
                priceList.Add("Hot Dog", 2);
                priceList.Add("Burger", 5);
                priceList.Add("Noodles", 6);
                Console.WriteLine("There are {0} items", priceList.Count);
                Console.WriteLine("Price of Pizza is {0}", priceList["Pizza"]);
                Console.Write("Enter food item name whose price you want to see ");
                string str = Console.ReadLine();
                if (priceList.ContainsKey(str))
                    Console.WriteLine("Price of {0} is {1}", str, priceList[str]);
                else
                    Console.WriteLine("Sorry, {0} not found", str);
                List<string> foodList = new List<string>(priceList.Keys);
                Console.WriteLine("Below is the list of available food items");
                foreach (string items in foodList)
                {
                    Console.WriteLine("{0}", items);
                }
                Console.WriteLine("Below is the complete price list");
                foreach (KeyValuePair<string, int> pair in priceList)
                {
                    Console.WriteLine("Price of {0} is {1}", pair.Key, pair.Value);
                }
                priceList.Remove("Pizza");
                Console.WriteLine("Number of items left is {0}", priceList.Count);
            }
        }
    }
    

