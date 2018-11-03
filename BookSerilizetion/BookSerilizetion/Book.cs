using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSerilizetion
{
    [Serializable]
    public class Book
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public string Avtor { set; get; }
        public int Year { set; get; }
    }
}
