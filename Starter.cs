using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfContacts
{
    public class Starter
    {
        public void Start()
        {
            Service service = new Service();
            ListContainer listContainer = new ListContainer();
            Console.WriteLine("write your Culture");
            string culture = Console.ReadLine();
            switch (culture.ToLower())
            {
                case "ru":
                    service.Writer(listContainer._unSortedList, listContainer._en);
                    break;

                default:
                    service.Writer(listContainer._en, listContainer._unSortedList);
                    break;
            }
        }
    }
}
