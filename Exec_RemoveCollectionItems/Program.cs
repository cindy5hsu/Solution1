using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
    //在集合中移除多個項目
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> source = new List<int> { 1, 2, 3, 4, 5 };
            source.Remove(2);
            source.Remove(4);
            foreach (int item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
