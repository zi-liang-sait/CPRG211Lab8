using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab8
{
    public class Node
    {
        public Node? Next {  get; set; }
        public string? Data {  get; set; }

        public Node()
        {
            this.Next = null;
            this.Data = null;
        }

        public Node(Node? next, string? data)
        {
            Next = next;
            Data = data;
        }
    }
}
