namespace taskD03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Stack s1 = new Stack(1);
            //Stack s2 = new Stack(2);


            //Console.WriteLine(Stack.GetCounter());



           Queue q1 = new Queue(5);
            q1.enqueue(10);
            Console.WriteLine(q1.front);
            q1.enqueue(20);
            Console.WriteLine(q1.front);
            q1.enqueue(30);
            Console.WriteLine(q1.front);
            q1.enqueue(40);
            Console.WriteLine(q1.front);
            q1.enqueue(50);
            Console.WriteLine(q1.front);
            q1.dequeue();
            Console.WriteLine(q1.front);
            q1.dequeue();
            q1.dequeue();
            q1.dequeue();
            q1.dequeue();
            q1.dequeue();




        }
    }
}
