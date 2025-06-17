namespace DesignPatterns.Creational.FactoryMethod._03;

// Product interface
public interface IDocument
{
    void Open();
    void Save();
}

// Concrete products
public class PDFDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document");
    public void Save() => Console.WriteLine("Saving PDF document");
}

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word document");
    public void Save() => Console.WriteLine("Saving Word document");
}

// Creator with factory method
public abstract class DocumentCreator
{
    // Factory Method
    public abstract IDocument CreateDocument();

    // Operation using factory method
    public void OpenDocument()
    {
        IDocument document = CreateDocument();
        document.Open();
    }
}

// Concrete creators
public class PDFDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument() => new PDFDocument();
}

public class WordDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument() => new WordDocument();
}