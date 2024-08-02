using System.Collections;

namespace ASSADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            //Write a Report about all Collections Given in the Session and Compare
            //[Structure, Time Complexity, and Business Case With Implemented Examples]
            #region Non Generic Collections : Arraylist
            /*
             * Structure:
             * Automatically resizes as elements are added
             * Time Complexity: in the worst case insertion
             * Business Case:
             *  Legacy, type-unsafe collection, suitable for mixed-type data.
            */
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine($" {item}");
            //}
            #endregion

            #region Generic Collections : List<T>
            /*
             * Structure:
             * Grows automatically
             * Time Complexity:  in the worst case insertion
             * Business Case:
             * General-purpose, type-safe collection, excellent for indexed access.
            */
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach (var item in list)
            //{
            //    Console.WriteLine($" {item}");
            //}
            #endregion

            #region Generic Collections : LinkedList<T>
            /*
             * Structure:
             *  Doubly linked list, each element contains a reference to the next and previous elements.
             * Time Complexity:  in the best case insertion
             * Business Case:
             * Best for frequent insertions/deletions at arbitrary positions.
            */
            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddLast(1);
            //linkedList.AddLast(2);
            //linkedList.AddLast(3);

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine($" {item}");
            //}
            #endregion

            #region Generic Collections : Stack<T>
            /*
             * Structure:
             * LIFO (Last In, First Out) collection.
             * Time Complexity:  in the best case insertion
             * Business Case:
             * LIFO structure, ideal for reversing, undo operations.
            */
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //int top = stack.Pop();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine($" {item}");
            //}
            #endregion

            #region Generic Collections :  Queue<T>
            /*
             * Structure:
             * FIFO (First In, First Out) collection.
             * Time Complexity:  in the best case insertion
             * Business Case:
             * FIFO structure, perfect for scheduling and processing elements in order.
            */
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int front = queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine($" {item}");
            }
            #endregion

            #endregion
            #region part02

            #region  You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList myList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original ArrayList:");
            //foreach (var item in myList)
            //{
            //    Console.Write(item + " ");
            //}

            //ReverseArrayList.Reverse(myList);

            //Console.WriteLine("\nReversed ArrayList:");
            //foreach (var item in myList)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> myNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = EvenNumbersFilter.GetEvenNumbers(myNumbers);

            //Console.WriteLine("Even numbers:");
            //foreach (int num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
          
            
            FixedSizeList<int> list = new FixedSizeList<int>(3);

            list.Add(1);
            list.Add(2);
            list.Add(3);

            try
            {
                list.Add(4);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);  // Output: List capacity exceeded. Cannot add more elements.
            }

            try
            {
                // Getting elements
                Console.WriteLine(list.Get(0));  // Output: 1
                Console.WriteLine(list.Get(1));  // Output: 2
                Console.WriteLine(list.Get(2));  // Output: 3

                // Trying to access an element at an invalid index
                Console.WriteLine(list.Get(3));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);  // Output: Index is out of range.
            }
            #endregion
          
            #endregion
        }
    }
}
