using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace lesson1pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle [] rectangle  = new Rectangle[10];
            Tringle []tringle = new Tringle[10];

            var rectangels = from item in rectangle
                          where item.Width > 3
                          select item;

            var tringles = from item in tringle
                           where item.RibLength2 > 2
                            select item;


        }
    }
}
