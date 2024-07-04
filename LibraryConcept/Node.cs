using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConcept
{
    public class Node<T>
    {


        public T Element { get; set; }

        public Node<T> Next { get; set; }


    }
}
    
