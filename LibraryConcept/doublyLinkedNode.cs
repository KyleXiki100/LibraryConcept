using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConcept
{
    public class doublyLinkedNode<T>
    {
        public T Element { get; set; }
        public doublyLinkedNode<T> Next { get; set; }
        public doublyLinkedNode<T> Previous { get; set; }
    }

}
