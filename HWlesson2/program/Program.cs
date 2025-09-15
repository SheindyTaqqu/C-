using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shelf<Book>> bookShelves = new List<Shelf<Book>>();
            //var bookShelves = new List<Shelf<Book>>();

            var shelf1 = new Shelf<Book>(1, 1, 20);
            shelf1.AddItem(new Book(1, "world war 2", "y.k", 500, "children", "Bloomsbury", 12));
            shelf1.AddItem(new Book(2, "1945", "g.o", 328, "Dystopian", "Secker & Warburg", 8));

            var shelf2 = new Shelf<Book>(2, 1, 25);
            shelf2.AddItem(new Book(3, "small world", "shalom cohen", 281, "Drama", "J.B. Lippincott & Co.", 10));

            bookShelves.Add(shelf1);
            bookShelves.Add(shelf2);

            // הדפסת התוצאה
            foreach (var shelf in bookShelves)
            {
                Console.WriteLine(shelf);
            }

            WightShelf(bookShelves);
            foreach (var shelf in bookShelves) { 
            var generBook = from Shelf in bookShelves
                            from book in shelf.Items
                            where book.Genre == "children"
                            select book;
            Console.WriteLine("childrens book");
            Console.WriteLine(generBook.ToString());
        }
        }

            public static void WightShelf(List<Shelf<Book>> bookShelves)
            {
            
                foreach (var shelf in bookShelves)
                {
                    double totalWeight = shelf.Items.Sum(book => book.Weight);
                    if (shelf.WeightCapacity <= totalWeight)
                    {
                        Console.WriteLine("the shelf is:");
                        Console.WriteLine(shelf);
                
                    }
                }
            }


            
    }
    }


