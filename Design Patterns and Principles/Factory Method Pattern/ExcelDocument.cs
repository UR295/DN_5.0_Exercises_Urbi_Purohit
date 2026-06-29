using System;

namespace FactoryMethodPatternExample
{
    class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Excel Document Created.");
        }
    }
}
