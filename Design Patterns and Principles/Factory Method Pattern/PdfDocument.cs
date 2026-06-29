using System;

namespace FactoryMethodPatternExample
{
    class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("PDF Document Created.");
        }
    }
}
