using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList.Models
{
    public class Node<T>
    {
        public Node(T? item)
        {
            Item = item;
            NextItem = null;
        }

        public T? Item { get; set; }

        public Node<T>? NextItem { get; set; }    
    }
}
