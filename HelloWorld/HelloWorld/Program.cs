using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers  = new List<int>();
            //Console.WriteLine('yoooo');
            var smallests = GetSmallests(numbers, 0);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentNullException("list", "List cannot be empty or NULL");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be less than or equal to zero or greater than a list size");
            
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }    
            }

            return min;
        }
    }
}