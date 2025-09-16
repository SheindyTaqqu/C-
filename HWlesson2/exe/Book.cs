using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Book : Item
{
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }
    public string Publisher { get; set; }
    public double Weight { get; set; }
    public double Price { get; set; }

    public Book(int id, string title, string author, int pages, string genre, string publisher, double weight, double price)
        : base(id, title)
    {
        Author = author;
        Pages = pages;
        Genre = genre;
        Publisher = publisher;
        Weight = weight;
        Price = price;

    }

    public override string ToString()
    {
        return $"Book: {Title} by {Author}, {Pages} pages, Genre: {Genre}, Publisher: {Publisher},Weight:{Weight},Price:{Price}";
    }
}
