using System;
using System.Collections;
using System.Collections.Generic;

namespace Sinftaski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <string> q = new Queue <string>();
            q.Enqueue("Jale");
            q.Enqueue("Kamal");
            q.Enqueue("Nergiz");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Stack(q);
        
          
            
        }
        public Queue<string> Stack(Queue<string> queue)
        {

            Stack<string> stack = new Stack<string>();
            foreach (var item in queue)
            {
                stack.Push(item);
            }
            
            Queue<string> queue2 = new Queue<string>();
            foreach (var item in stack)
            {
                queue2.Enqueue(item);
            }
            return queue2;
            
        }
    }   
    
}
