using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace DocumentEngine.Documents;

public abstract class BaseDocument : IDocument
{
    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            ConfigurePage(page);

            page.Header().Element(ComposeHeader);

            page.Content().Element(ComposeContent);

            page.Footer().Element(ComposeFooter);
        });
    }

    private void ConfigurePage(PageDescriptor page)
    {
        page.Size(PageSizes.A4);
        page.Margin(2, Unit.Centimetre);
    }

    protected virtual void ComposeHeader(IContainer container)
    {
    }

    protected virtual void ComposeContent(IContainer container)
    {
    }

    protected virtual void ComposeFooter(IContainer container)
    {
    }
}