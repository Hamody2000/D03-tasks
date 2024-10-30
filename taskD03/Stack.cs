using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace taskD03
{
    public class Stack

    {
        int[] arr;
        int tos;
        int size;
        private static int counter;

        public static int GetCounter()
        {
            return counter;
        }
        public Stack(int _size)
        {
            counter++;
            tos = 0;
            size = _size;
            arr = new int[size];
        }
        public void Push(/*Stack this,*/int number)
        {
            //if (tos != size)
            if (!IsFull())
            {
                arr[tos] = number;
                this.tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!");
            }
        }

        public int Pop()
        {
            int result = -1234;
            //if (tos != 0)
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                //return result;
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
                //return -1234;
                ////Effective way -> throw runtime error
            }
            return result;
        }

        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        public int Peak()
        {
            return arr[tos - 1];
        }


    }

}
