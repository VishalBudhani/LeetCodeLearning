using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();
            //stack.Push(100);
            //stack.Push(200);
            //stack.Push(300);
            //stack.Push(400);
            //stack.Peek();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            int[] arr = {2, 7, 11, 15};
            int target = 9;
            var result = TwoSum(arr, target);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (dict.ContainsKey(difference))
                {
                    var index = dict[difference];
                    if (index < i)
                    {
                        result[0] = index;
                        result[1] = i;
                    }
                    else
                    {
                        result[0] = i;
                        result[1] = index;
                    }
                    break;
                }
                dict[nums[i]] = i;
            }
            return result;
        }
    }

    class Stack<T>
    {
        private static readonly int MaxSize = 3;
        private T[] array = new T[MaxSize];
        private int top;
        public Stack()
        {
            top = -1;
        }

        public bool Push(T item)
        {
            if (top == MaxSize-1)
            {
                Console.WriteLine("Stack full");
                return false;
            }
            array[++top] = item;
            return true;
        }

        public T Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack empty");
                var t = -99999;
                return (T)Convert.ChangeType(t, typeof(T));
            }
            return array[top--];
        }

        public bool Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty");
                return false;
            }
            Console.WriteLine("Top most item is: {0}", array[top]);
            return false;
        }

    }
}
