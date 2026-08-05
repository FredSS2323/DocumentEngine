using DocumentEngine.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace DocumentEngine.Documents;

public sealed class ReceiptDocument : BaseDocument
{
    private readonly ReceiptModel _receipt;

    public ReceiptDocument(ReceiptModel receipt)
    {
        _receipt = receipt;
    }

    protected override void ComposeHeader(IContainer container)
    {
        container
            .AlignCenter()
            .Text("RECIBO")
            .FontSize(28)
            .Bold();
    }

    protected override void ComposeContent(IContainer container)
    {
        container
            .PaddingTop(1, Unit.Centimetre)
            .Column(column =>
            {
                column.Spacing(12);

                AddField(column, "Número", _receipt.Number);
                AddField(column, "Destinatário", _receipt.Receiver);
                AddField(column, "Descrição", _receipt.Description);
                AddField(column, "Valor", _receipt.Amount.ToString("C"));
                AddField(column, "Data", _receipt.Date.ToString("dd/MM/yyyy"));
            });
    }

    private static void AddField(ColumnDescriptor column, string label, string value)
    {
        column.Item().Column(item =>
        {
            item.Spacing(3);

            item.Item()
                .Text(label)
                .FontSize(13)
                .SemiBold();

            item.Item()
                .Text(value)
                .FontSize(16);
        });
    }
}