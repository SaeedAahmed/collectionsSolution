using collections.part02;
using collections.reverse;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Write a Report about all Collections Given in the Session and Compare [Structure, Time Complexity, and Business Case With Implemented Examples]

            /// Array
            ///Structure:fixed-size collections of elements of the same type
            ///Time complexity : O(1)
            ///Business case:used when the size of the collection is known beforehand
            ///int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            ///Console.WriteLine(numbers[2]);

            /// ArrayList
            ///Structure: is a non-generic collection ,  can store items of any type , can dynamically resize itself to accommodate new elements
            ///Time complexity: O(1)
            ///Business case:when you need a collection that can store a variety of types and when the size of the collection changes frequently
            ///ArrayList list = new ArrayList();
            ///list.Add(1);
            ///list.Add("Hello");
            ///list.Add(3.14);
            ///list.Add(true);
            ///Console.WriteLine(list[0]); 
            ///Console.WriteLine(list[1]); 
            ///Console.WriteLine(list[2]); 
            ///Console.WriteLine(list[3]);
            ///list.RemoveAt(1);
            ///Console.WriteLine(list[1]);
            ///foreach (var item in list)
            ///{
            ///    Console.WriteLine(item);
            ///}

            /// List<T>
            ///is a dynamic array that automatically resizes itself as needed. Internally, it uses an array to store elements,
            ///and when this array reaches its capacity, it is resized to a larger array, and the existing elements are copied to the new array.
            ///Time complexity: O(1)
            ///List<int> numbers = new List<int>() { 1 , 2 , 3 , 4 , 5};
            ///
            ///numbers.Add(6);
            ///numbers.AddRange(new int[] { 7, 8, 9 });
            ///numbers.Insert(2, 10);
            ///numbers.Remove(3);
            ///foreach (int i in numbers)
            ///{
            ///    Console.WriteLine(i);
            ///}

            /// linkedList<T>
            ///Structure:consists of a series of nodes. Each node contains a reference to the next node and the previous node, allowing for efficient insertion and deletion operations
            ///Time complexity: O(n)
            ///Business cases:is useful in scenarios where frequent insertions and deletions are required
            ///LinkedList<int> list = new LinkedList<int>();
            ///
            ///list.AddFirst( 1 );
            ///list.AddLast( 3 );
            ///       
            ///LinkedListNode<int> node;
            ///node=list.Find(1);
            ///list.AddAfter(node , 2);
            ///list.AddBefore(node , 4);
            ///Console.WriteLine($"Count = {list.Count}");
            ///
            ///foreach (int i in list) 
            ///{
            ///    Console.WriteLine(i);
            ///}

            ///Stack<T
            ///Structure:is implemented as a dynamic array internally, ensuring that elements are stored in a contiguous block of memory
            ///First in last out
            ///Business cases:is useful in scenarios where elements need to be processed in a LIFO order
            ///Stack<int> stack = new Stack<int>();
            ///stack.Push(1);
            ///stack.Push(2);  
            ///stack.Push(3);
            ///Console.WriteLine(stack.Peek()); // return element in top without removeing it
            ///stack.Pop();
            ///Console.WriteLine(stack.Peek());

            ///Queue<T>
            ///Structure: queue is a linear data structure that follows the First-In-First-Out (FIFO) principle.
            ///This means that the first element added to the queue will be the first one to be removed.
            ///Time complexity : O(1)
            ///Queue<int> queue = new Queue<int>();  
            ///queue.Enqueue(1);
            ///queue.Enqueue(2);   
            ///queue.Enqueue(3);
            ///queue.Dequeue(); // return last element at stare then remove it
            ///queue.Peek();// return last element at stare without removeing

            ///Hashtable non-generic
            ///Structure: is implemented using a hash table. It uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found
            ///Time complexity : O(1)
            ///Business cases:is useful in scenarios where quick lookups, insertions, and deletions are required
            ///
            ///Hashtable hashtable = new Hashtable();
            /// //Key is unique
            ///hashtable.Add("saeed", 123);
            ///hashtable.Add("mohamed", 456);
            ///hashtable.Add("sami", 789);
            ///
            ///foreach (DictionaryEntry entry in hashtable)
            ///{
            ///    Console.WriteLine($"{entry.Key}: {entry.Value}");
            ///}
            ///

            ///generic hashTable[Dictionary<TKey, TValue>]
            ///Structure:  is implemented using a hash table. It maintains a collection of key-value pairs where each key is unique
            ///Time complexity : O(1)
            ///Business cases:is useful in scenarios where quick lookups, insertions, and deletions are required with key-based access
            ///
            ///Dictionary<string, int> dictionary = new Dictionary<string, int>();
            ///dictionary.Add("saeed", 123);
            ///dictionary.Add("ahmed", 456);
            ///dictionary.Add("mohamed", 789);
            ///
            ///foreach (var i in dictionary)
            ///{
            ///    Console.WriteLine($"{i.Key}: {i.Value}");
            ///}
            ///
            ///int age = dictionary["saeed"];
            ///Console.WriteLine(age);
            ///
            ///dictionary.Remove("saeed");
            ///Console.WriteLine("Dictionary after remove");
            ///foreach (var i in dictionary)
            ///{
            ///    Console.WriteLine($"{i.Key}: {i.Value}");
            ///}
            #endregion

            #region Part02 Task one

            //ArrayList list = new ArrayList() { 1, 6, 3, 4, 2 ,16,7};
            //Console.WriteLine("Before reverse");
            //foreach (int i in list)
            //{
            //    Console.Write(i);
            //}

            //Reverse.ReversaArrayList(list);

            //Console.WriteLine("\nAfter reverse");
            //foreach (int i in list)
            //{
            //    Console.Write(i);
            //}
            #endregion

            #region Part02 Task two
            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7};
            //Console.WriteLine("numbers");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number+" ");
            //}


            //ArrayList evenNumbers = EvenNumbers.Even(numbers);
            //Console.WriteLine("\nEven Number");
            //foreach (int number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region Part02 task three
            FixedSizeList<int> list = new FixedSizeList<int>(5);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            ////list.Add(6); // xxxx ---> Cannot add more items

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list.Get(i));
            //}

            #endregion

         
        }
    }
}
