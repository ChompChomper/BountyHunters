using Godot;
using System.Collections.Generic;

public class Player
{
    public string Name;
    public List<Card> Hand = new List<Card>();

    public Player(string name)
    {
        Name = name;
    }

    public void DrawCard(Card card)
    {
        Hand.Add(card);
    }

    public void PrintHand()
    {
        GD.Print($"-- {Name}'s Hand --");
        foreach (var card in Hand)
        {
            GD.Print(card.ToString());
        }
    }
}





