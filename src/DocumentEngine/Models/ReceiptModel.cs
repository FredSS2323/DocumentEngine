namespace DocumentEngine.Models;

public sealed class ReceiptModel
{
    public string Number { get; init; } = string.Empty;

    public string Receiver { get; init; } = string.Empty;

    public decimal Amount { get; init; }

    public string Description { get; init; } = string.Empty;

    public DateTime Date { get; init; } = DateTime.Now;
}