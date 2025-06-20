using System;

namespace FactoryMethodPatternExample.Documents
{
    public class PdfDocument : IDocument
    {
        public void Create() => Console.WriteLine("pdf document Created");
        public void Save() => Console.WriteLine("Word document saved as pdf");
    }
}
