using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollectionsLibrary;

namespace GenericCollections
{ // I started with a library and then sort of abandoned actually implementing it how I should've as the 
  // exercise was a little bit less complex than I initially spooked myself into thinking it would be.
  // So I have a useless-library. There. I said it.
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.MyList();

            LinkedList linkedList = new LinkedList();
            linkedList.MyLinkedList();

            Queue queue = new Queue();
            queue.MyQueue();

            Stack stack = new Stack();
            stack.MyStack();

            Dictionary dictionary = new Dictionary();
            dictionary.MyDictionary();

            SortedList sortedList = new SortedList();
            sortedList.MySortedList();

            HashSet hashSet = new HashSet();
            hashSet.MyHashSet();

            Console.ReadLine();
        }
    }
}

/*Assignment
Project 1

In a new project, instantiate an instance of each of the generic collection classes described in Chapter 18:

List<T>,
LinkedList<T>,
Queue<T>,
Stack<T>,
Dictionary<TKey, TValue>,
SortedList<TKey, TValue>, and
HashSet<T>).
Insert 5 values of a type of your choosing into each of these collections, 
then iterate over the collection and print each value to the console. 
Print a line above your iteration stating which data structure you're printing from, 
and print a blank line between the last item in the collection and the description of the following data structure.
*/
