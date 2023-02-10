//var arr = new int[] { 1, 2, 3, 4, 3, 2, 1 };

//int lonelyInteger = 0;


////Codev2
//Dictionary<int, int> freq = new Dictionary<int, int>();
//foreach (int i in arr)
//{
//    if (freq.ContainsKey(i))
//        freq[i]++;
//    else
//        freq.Add(i, 1);
//}

//foreach (var item in freq)
//{
//    if (item.Value == 1)
//    {
//        lonelyInteger = item.Key;
//    }
//}

////Code v1
////int lonelyInteger = 0;
////bool alreadyTested = false;
////var arrDuplicateIntegeger = new List<int>(arr.Length);
////for (int i = 0; i < arr.Length; i++)
////{
////    for (int j = 0; j < arrDuplicateIntegeger.Count; j++)
////    {
////        if (arr[i] == arrDuplicateIntegeger[j])
////        {
////            alreadyTested = true;
////        }
////    }

////    if (alreadyTested)
////    {
////        continue;
////    }

////    for (int y = 0; y < arr.Length; y++)
////    {
////        if (i != y && arr[i] == arr[y])
////        {
////            lonelyInteger = 0;
////            arrDuplicateIntegeger.Add(arr[i]);
////            break;
////        }

////        lonelyInteger = arr[i];
////    }
////}

//Console.WriteLine(lonelyInteger);