using FactoryMethodPatternExample.Factories;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main()
        {
            DocumentFactory factory = new WordDocumentFactory();
            factory.ProcessDocument();
            
            factory = new PdfDocumentFactory();
            factory.ProcessDocument();
            
            factory = new ExcelDocumentFactory();
            factory.ProcessDocument();

            Console.WriteLine("All documents processed successfully!");
        }
    }
}