using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD03
{
    public class Queue
    {
        int[] arr;
        public int back;
        public int front;
        int size;
        private static int counter;
        public Queue(int _size) 
        {
            counter++;
            back = -1;
            front = 0;
            size = _size;
            arr = new int[size];
        }
        public void enqueue(int num)
        {
            if (back != size -1)
            {
                back++;
                arr[back] = num;
                Console.WriteLine($"{num} is added");
            }
            else
            {
                Console.WriteLine("FULLLL");
            }
        }
        public  int dequeue() 
        {
            int result = -1324;
            if (front != size )
            {
                result = arr[front];
                Console.WriteLine($"removed: {arr[front]}");
                front++;
            }
            else
            {
                Console.WriteLine("Emptyy");
            }
            return result;
        }

    }
}
