using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

public class Game : Item
{
    public string Platform { get; set; }
    public int AgeRating { get; set; }
    public string Developer { get; set; }
    public bool IsMultiplayer { get; set; }

    public Game(int id, string title, string platform, int ageRating, string developer, bool isMultiplayer)
        : base(id, title)
    {
        Platform = platform;
        AgeRating = ageRating;
        Developer = developer;
        IsMultiplayer = isMultiplayer;
    }

    public override string ToString()
    {
        return $"Game: {Title}, Platform: {Platform}, Age: {AgeRating}+, Developer: {Developer}, Multiplayer: {IsMultiplayer}";
    }
}

