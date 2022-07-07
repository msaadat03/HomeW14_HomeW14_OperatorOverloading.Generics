using System;

namespace HomeW14_ReviewLessonTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringList list = new StringList();
            list.Add("Sada");
            list.Add("Fidosh");

            list.GetAll();

            IntList list1 = new IntList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(100);

            list1.GetAll();

        
        }
    }

    public class StringList
    {
        private string[] arr;

        public StringList()
        {
            arr = new string[0];
        }
        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }




    public class IntList
    {
        private int[] arr;

        public IntList()
        {
            arr = new int[0];
        }

        public void Add(int m)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = m;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
