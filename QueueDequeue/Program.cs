using System;

class Queue
{
    private int[] items;
    private int front, rear;

    public Queue()
    {
        items = new int[5];
        front = -1;
        rear = -1;
    }

    public bool IsFull()
    {
        if (front == 0 && rear == items.Length - 1)
        {
            return true;
        }
        return false;
    }

    public bool IsEmpty()
    {
        if (front == -1)
            return true;
        else
            return false;
    }

    public void Enqueue(int element)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full");
        }
        else
        {
            if (front == -1) front = 0;
            rear++;
            items[rear] = element;
            Console.WriteLine("\nInserted " + element);
        }
    }

    public int Dequeue()
    {
        int element;
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return (-1);
        }
        else
        {
            element = items[front];
            if (front >= rear)
            {
                front = -1;
                rear = -1;
            } /* Q has only one element, so we reset the queue after deleting it. */
            else
            {
                front++;
            }
            Console.WriteLine("\nDeleted -> " + element);
            return (element);
        }
    }

    public void Display()
    {
        /* Function to display elements of Queue */
        int i;
        if (IsEmpty())
        {
            Console.WriteLine("\nEmpty Queue");
        }
        else
        {
            Console.WriteLine("\nFront index-> " + front);
            Console.WriteLine("Items -> ");
            for (i = front; i <= rear; i++)
                Console.Write(items[i] + " ");
            Console.WriteLine("\nRear index-> " + rear);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue q = new Queue();

        
    //deQueue is not possible on empty queue
q.Dequeue();

        //enQueue 5 elements
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);
        q.Enqueue(5);

        // 6th element can't be added to because the queue is full
        q.Enqueue(6);

        q.Display();

        //deQueue removes element entered first i.e. 1
        q.Dequeue();

        //Now we have just 4 elements
        q.Display();

        Console.ReadKey();
    }
}
