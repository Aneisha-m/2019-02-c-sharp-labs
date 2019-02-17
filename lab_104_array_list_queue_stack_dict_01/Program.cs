using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 10 MIN CHALLENGE :
            // PUT 10 NUMBERS IN ARRAY
            int[] myArray = new int[] {0,1,2,3,4,5,6,7,8,9};

            // MOVE ITEMS TO A LIST AND ADD 1
            List<int> myList = new List<int>();
            foreach (var i in myArray)
            {
                myList.Add(myArray[i] + 1);
            }

            // MOVE TO STACK AND ADD 1
            Stack<int> myStack = new Stack<int>();
            for(var i = 0; i < myList.Count; i++)
            {
                int stackOutput= myList[i];
                myStack.Push(stackOutput + 1);
            }

            // MOVE TO QUEUE AND ADD 1
            Queue<int> myQueue = new Queue<int>();
            for(int i = 0; i < 10; i++)
            {
                int queueOutput = myStack.Pop();
                myQueue.Enqueue(queueOutput + 1);
            }

           // MOVE TO DICTIONARY AND ADD 1
           Dictionary<int, int> myDictionary = new Dictionary<int, int>();
           for(int  i = 0; i < 10; i ++)
           {
                myDictionary.Add(i, myQueue.Dequeue() + 1);
           }

           // RETURN TOTAL
            int total = 0;
            foreach (var i in myDictionary)
            {
                total += i.Value;
                Console.WriteLine(i);
            }
            Console.WriteLine(total);
        }
    } // CLASS PROGRAM END
} // NAMESAPCE END
