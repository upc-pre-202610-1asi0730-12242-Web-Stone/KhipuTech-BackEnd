namespace WebStone.Khiputech.platform.Capacity.Domain.Model.ValueObjects;

public record Capacity
{
    public int Value { get; }

    public Capacity(int value)
    {
        if (value > 40)
            throw new ArgumentException("Maximun capacity for this room is 40.");
        
        if (value <=0)
            throw new ArgumentException("Invalid value");
        Value = value;
    }
}