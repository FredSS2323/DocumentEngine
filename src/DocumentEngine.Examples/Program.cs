using DocumentEngine.Documents;
using DocumentEngine.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

var receipt = new ReceiptModel
{
    Number = "001",
    Receiver = "João da Silva",
    Description = "Pagamento referente ao serviço prestado.",
    Amount = 250.50m,
    Date = DateOnly.FromDateTime(DateTime.Now)
};

var service = new DocumentService();

service.GenerateReceipt(receipt, "Receipt.pdf");