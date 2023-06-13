using System.Collections;

namespace HomeWork_Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        
        public abstract IEnumerator GetEnumerator();
    }
}