using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfContacts
{
    public class ListContainer
    {
        public List<string> _unSortedList = new List<string>() { "Aba,a", "stas", "стаs", "Tom", "BOB", "0Tids1", "4b", "ukr.player", "укр.player", "Tom", "4help", "04374", "65474", "fd43" };
        public List<string> _num = new List<string>();
        public List<string> _en = new List<string>();
        public ListContainer()
        {
            _unSortedList.Add("afd");
            _unSortedList.Add("vc");
            _unSortedList.Add("trueew");
            _unSortedList.Add("aasd");
            _unSortedList.Add("534");
            _unSortedList.Add("qq");
            _unSortedList.Add("134");
            _unSortedList.Add("ав");
            _unSortedList.Add("имсчи");
            _unSortedList.Add("пмыф");
            _unSortedList.Add("фыв");
            _unSortedList.Add("ке");
            _unSortedList.Add("аыв");
            _unSortedList.Add("пмс");
            _unSortedList.Sort();
            StartSort(_unSortedList, _num, 10, 48);
            StartSort(_unSortedList, _en, 26, 65);
            Console.WriteLine();
        }

        public void Acs()
        {
            List<string> a = new List<string>(_unSortedList);
            List<string> b = new List<string>(_num);
            List<string> c = new List<string>(_en);
        }

        public void StartSort(List<string> curentList, List<string> listByGroup, int numarate, int indexs)
        {
            for (int i = 0; i < curentList.Count; i++)
            {
                char[] d = curentList[i].ToCharArray();
                for (int j = 0; j < numarate; j++)
                {
                    if (char.ToLower(d[0]) == char.ToLower(Convert.ToChar(j + indexs)))
                    {
                        listByGroup.Add(curentList[i]);
                        curentList.RemoveAt(i);
                        i--;

                        break;
                    }
                }
            }
        }
    }
}
