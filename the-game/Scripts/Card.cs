public enum CardType
{
    Attack,
    Defense,
    Trick,
    Trap
}

public class Card
{
    public string Name;
    public CardType Type;

    public Card(string name, CardType type)
    {
        Name = name;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Name} ({Type})";
    }
}
