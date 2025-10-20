using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Shelf<T> where T : Item
{
    public int ShelfNumber { get; set; }
    public int ColumnNumber { get; set; }
    public double WeightCapacity { get; set; }
    public List<T> Items { get; set; } = new List<T>();

    public Shelf(int shelfNumber, int columnNumber, double weightCapacity)
    {
        ShelfNumber = shelfNumber;
        ColumnNumber = columnNumber;
        WeightCapacity = weightCapacity;
    }

    public void AddItem(T item)
    {
        Items.Add(item);
    }

    public override string ToString()
    {
        string result = $"Shelf #{ShelfNumber}-{ColumnNumber} ({WeightCapacity}kg):\n";
        foreach (var item in Items)
        {
            result += "  - " + item.ToString() + "\n";
        }
        return result;
    }
}

