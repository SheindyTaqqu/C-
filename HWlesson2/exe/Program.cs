using System;
using System.Collections.Generic;
using System.Linq;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shelf<Book>> bookShelves = new List<Shelf<Book>>();


            var shelf1 = new Shelf<Book>(1, 1, 20);
            shelf1.AddItem(new Book(1, "world war 2", "y.k", 500, "children", "Bloomsbury", 12, 70));
            shelf1.AddItem(new Book(2, "1945", "g.o", 328, "Dystopian", "yefey nof", 8, 85));

            var shelf2 = new Shelf<Book>(2, 1, 25);
            shelf2.AddItem(new Book(3, "small world", "shalom cohen", 200, "Drama", "yefey nof", 10, 100));

            bookShelves.Add(shelf1);
            bookShelves.Add(shelf2);

            // הדפסת התוצאה
            foreach (var shelf in bookShelves)
            {
                Console.WriteLine(shelf);
            }

            WightShelf(bookShelves);



            var genreBooks = from shelf in bookShelves
                             where (from book in shelf.Items
                                    where book.Genre == "children"
                                    select book).Any()
                             select shelf;

            Console.WriteLine("Children's books shelfs:");
            foreach (var shelf in genreBooks)
            {
                Console.WriteLine($"Shelf number: {shelf.ShelfNumber}");
            }



            var shelvesWithExpensiveBooks =
                from shelf in bookShelves
                where (from book in shelf.Items
                       where book.Price >= 90
                       select book).Any()
                select shelf;

            Console.WriteLine("Shelves that contain expensive books:");
            foreach (var shelf in shelvesWithExpensiveBooks)
            {
                Console.WriteLine($"Shelf number: {shelf.ShelfNumber}"); // אפשר גם shelf.Name אם יש
            }


            var pageBook =
                from shelf in bookShelves
                where (from book in shelf.Items
                       where book.Pages >= 300
                       select book).Any()
                select shelf;

            Console.WriteLine("Shelves with big books:");
            foreach (var shelf in pageBook)
            {
                Console.WriteLine($"Shelf number: {shelf.ShelfNumber}");
            }

            var yefeyNofBooks = from shelf in bookShelves
                                where (from book in shelf.Items
                                       where book.Publisher == "yefey nof"
                                       select book).Any()
                                select shelf;

            Console.WriteLine("yefy nof books shelfs:");
            foreach (var shelf in yefeyNofBooks)
            {
                Console.WriteLine($"Shelf number: {shelf.ShelfNumber}");
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


