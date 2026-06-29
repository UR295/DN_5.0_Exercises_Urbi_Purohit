using System;

namespace FactoryMethodPatternExample
{
    class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Word Document Created.");
        }
    }
}
