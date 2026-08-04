using DocumentEngine.Documents;
using DocumentEngine.Models;
using QuestPDF.Fluent;

public sealed class DocumentService
{
    public void GenerateReceipt(ReceiptModel receipt, string filePath)
    {
        var document = new ReceiptDocument(receipt);

        document.GeneratePdf(filePath);
    }
}