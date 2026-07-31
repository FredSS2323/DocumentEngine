using QuestPDF.Infrastructure;
using DocumentEngine.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace DocumentEngine.Documents;


public sealed class ReceiptDocument : IDocument
{

    private readonly ReceiptModel _receipt;

    public ReceiptDocument(ReceiptModel receipt)
    {
        _receipt = receipt;
    }
    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(2, Unit.Centimetre);

            page.Content()
                .Text("RECIBO")
                .FontSize(24)
                .Bold();
        });
    }
}

