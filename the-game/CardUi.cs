using Godot;

public partial class CardUI : Control
{
    private Label _cardLabel;

    public override void _Ready()
    {
        _cardLabel = GetNode<Label>("CardLabel");
    }

    public void SetCardText(string text)
    {
        _cardLabel.Text = text;
    }
}
