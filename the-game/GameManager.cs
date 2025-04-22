using Godot;
using System;
using System.Collections.Generic;

public partial class GameManager : Node
{
    List<Card> deck = new List<Card>();
    List<Player> players = new List<Player>();
    const int HandSize = 7;

    public override void _Ready()
    {
        CreatePlayers();
        BuildDeck();
        ShuffleDeck();
        DealCards();

        foreach (var player in players)
        {
            player.PrintHand();
        }
    }

    void CreatePlayers()
    {
        players.Add(new Player("Alice"));
        players.Add(new Player("Bob"));
        players.Add(new Player("Charlie"));

        GD.Print("Players created.");
    }

    void BuildDeck()
    {
        for (int i = 0; i < 10; i++) deck.Add(new Card($"Attack {i}", CardType.Attack));
        for (int i = 0; i < 10; i++) deck.Add(new Card($"Defense {i}", CardType.Defense));
        for (int i = 0; i < 5; i++) deck.Add(new Card($"Trap {i}", CardType.Trap));
        for (int i = 0; i < 5; i++) deck.Add(new Card($"Trick {i}", CardType.Trick));

        GD.Print("Deck built.");
    }

    void ShuffleDeck()
    {
        Random rand = new Random();
        for (int i = 0; i < deck.Count; i++)
        {
            int swap = rand.Next(deck.Count);
            var temp = deck[i];
            deck[i] = deck[swap];
            deck[swap] = temp;
        }

        GD.Print("Deck shuffled.");
    }

    void DealCards()
    {
        for (int i = 0; i < HandSize; i++)
        {
            foreach (var player in players)
            {
                if (deck.Count == 0) return;
                player.DrawCard(deck[0]);
                deck.RemoveAt(0);
            }
        }

        GD.Print("Cards dealt.");
    }
}



