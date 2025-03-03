using System.Collections;



namespace Assignment01_C__Advanced
{
    internal class Program
    {
        #region Q2
        //public static void ReverseArrayList(ArrayList arrayList)
        //{
        //    int left = 0;
        //    int right = arrayList.Count - 1;

        //    while(left < right)
        //    {
        //        object temp = arrayList[left];
        //        arrayList[left] = arrayList[right];
        //        arrayList[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}
        #endregion

        #region Q3
        //public static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new List<int>();

        //    foreach (var number in numbers)
        //    {
        //        if(number % 2 == 0)
        //        {
        //            evenNumbers.Add(number);
        //        }
        //    }

        //    return evenNumbers;

        #endregion

        #region Q5
        //public static int FirstNonRepeatCharacter(string input)
        //{
        //    Dictionary<char, int> charCount = new Dictionary<char, int>();


        //    foreach (char c in input)
        //    {
        //        if (charCount.ContainsKey(c))
        //        {
        //            charCount[c]++;
        //        }
        //        else
        //        {
        //            charCount[c] = 1;
        //        }
        //    }

        //    for(int i =0; i< input.Length; i++)
        //    {
        //        if (charCount[input[i]] == 1)
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}



        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //var intRange = new Range<int>(1, 10);
            //Console.WriteLine(intRange.ISInRange(3)); //True
            //Console.WriteLine(intRange.Length()); //9
            #endregion

            #region Follow Q2
            //ArrayList myList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original ArrayList:" + string.Join(", ", myList.ToArray()));

            //ReverseArrayList(myList);
            //Console.WriteLine("Reversed ArrayList: " + string.Join(", ", myList.ToArray()));
            #endregion

            #region Q3
            //List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> evenNumbers = GetEvenNumbers(myNumbers);

            //Console.WriteLine("Even Numbers: " + string.Join(",", evenNumbers));

            #endregion

            #region Q4
            //try
            //{
            //    FixedSizeList<int> myList = new FixedSizeList<int>(5);

            //    myList.Add(1);
            //    myList.Add(2);
            //    myList.Add(3);
            //    myList.Add(4);
            //    myList.Add(5);


            //    Console.WriteLine("Element in FixedSizeList:");
            //    for (int i = 0; i < myList.count; i++)
            //    {
            //        Console.WriteLine(myList.Get(i));
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}


            #endregion

            #region Follow Q5

            //string input = "seiss";
            //int index = FirstNonRepeatCharacter(input);

            //if(index != -1)
            //{
            //    Console.WriteLine($"The first non-repeated character is at index: {index}");
            //}
            //else
            //{
            //    Console.WriteLine("There is no non-repeates characte.");
            //}
            #endregion
        }
    }
}