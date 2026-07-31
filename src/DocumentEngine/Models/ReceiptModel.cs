namespace DocumentEngine.Models;

public sealed record ReceiptModel
{
    public required string Number { get; init; }

    public required string Receiver { get; init; }

    public required string Description { get; init; }

    public decimal Amount { get; init; }

    public DateOnly Date { get; init; }
}