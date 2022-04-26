

using System.Collections;

namespace Lesson_3
{
    public class Lesson_3
    {
        public void ArraySorter(int[] arrayOfIntegers)
        {
            int temp;

           
            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)

                
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)

                    
                    if (arrayOfIntegers[i] > arrayOfIntegers[j])
                    {

                        temp = arrayOfIntegers[i];
                        arrayOfIntegers[i] = arrayOfIntegers[j];
                        arrayOfIntegers[j] = temp;
                    }
            for (int j = 0; j < arrayOfIntegers.Length; j++)
            {
                Console.WriteLine(arrayOfIntegers[j]);
            }
        }
        public static void Main(String[] args)
        {
            Lesson_3 lesson = new Lesson_3();
           /* int[] arrayOfIntegers = new int[5] { -5, 0, 6, 8, -6 };
            foreach (int number in arrayOfIntegers)
            {
                Console.WriteLine(number);
            }*/
            //Arrays
           // lesson.ArraySorter(arrayOfIntegers);
            //multidimensional array
          /*  double[,] arrayOfDouble = new double [3,3]
            {
                {1.2, 2.1, 3.5 },
                {5.5, 6.4, 7.8 },
                {7.1, 2.4, 4.6 }
            };
            //size1 = GetLength(0)= 3
            //size2 = GetLength(1)= 4
            for (int i=0; i<arrayOfDouble.GetLength(0); i++)
            {
                //0
                for(int j =0; j<arrayOfDouble.GetLength(1); j++)
                {
                    Console.WriteLine(arrayOfDouble[i, j]);
                }
            }
            var i1 = arrayOfDouble[0,0];
            var i2 = arrayOfDouble[1, 2];
            var i3 = arrayOfDouble[1, 3];

            //Compute summ of first row elements
            double summ = 0;
            for(int j=0; j< arrayOfDouble.GetLength(1); j++)
            {
                summ += arrayOfDouble[0, j];
            }
            Console.WriteLine(summ);*/
            //Collections
            //non-generic
             ArrayList list = new ArrayList() { "dhcgdhcv",5, true};
            list.Add("gfewhjhg");
            list.Add(5);
            list.Add(true);
             SortedList sortedList = new SortedList();
             Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "yghykyg");
            hashtable.Add(1, "efqwfwfqwgqrwg0");
            hashtable.Add(2, "yghvfgkyg");
            // key1 = 1 value ="yghykyg"
            Queue queue = new Queue();
             Stack stack = new Stack();
             BitArray bitArray = new BitArray(6);

             //generic
             IEnumerable<int> genericStack = new Stack<int>();
             IEnumerable<int> genericQueue = new Queue<int>();
             ISet<int> set = new HashSet<int>();
             ISet<double> set2 = new SortedSet<double>();
             IDictionary<string, string> dictionary = new Dictionary<string, string>();
             IDictionary<int, string> genericSortedList = new SortedList<int, string>();
             IDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>();
             IList<string> list2 = new List<string>();
             list2.Add("hbfhfhhf");
             list2.Add("bgkuyv");

            //operations with collections
            IList<double> genericList = new List<double>();
            genericList.Add(10.5);
             bool result = genericList.Contains(5.3);
             genericList.Clear();
             genericList.Remove(10.5);
             genericList.RemoveAt(0);
             double result2 = genericList.Max();
             double result3 = genericList.Min();
             double summ = genericList.Sum();
        }
    }
}
