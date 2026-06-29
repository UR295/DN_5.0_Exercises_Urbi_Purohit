using System;

namespace FactoryMethodPatternExample
{
    abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
