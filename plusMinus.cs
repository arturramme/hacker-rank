
//List<int> arr = "-4 3 -9 0 4 1".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//Result.plusMinus(arr);

//class Result
//{
//    public static void plusMinus(List<int> arr)
//    {
//        int n = arr.Count;
//        int positives, negatives, zeros;
//        positives = negatives = zeros = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] == 0)
//            {
//                zeros++;
//            }
//            else if (arr[i] > 0)
//            {
//                positives++;
//            }
//            else
//            {
//                negatives++;
//            }
//        }

//        Console.WriteLine($"{(double)positives / n:0.000000}");
//        Console.WriteLine($"{(double)negatives / n:0.000000}");
//        Console.WriteLine($"{(double)zeros / n:0.000000}");
//    }
//}