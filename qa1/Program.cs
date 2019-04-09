using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //practice tasks form Codility
            Solution sol = new Solution();
            int[] test = new int[2] { -1, -3 };
            //sol.solution2(5); comented because of console output
            sol.Solution3(new int[7] { 9, 3, 9, 3, 9, 7, 9 });
            sol.Solution4(new int[4] { 2, 3, 1, 5 });
            sol.Solution5(1, 5, 2);
            sol.Solution6(new int[5] { 3, 1, 2, 4, 3 });
            sol.Solution7(new int[2] { 1, 1 });
            sol.Solution8(1, new int[3] { 1, 1, 3 }, 3, new int[3] { 3, 3, 2 }, 3); //2, new int[1] { 1 }, 1, new int[4] { 3, 2, 5, 5 }, 4    2, new int[4] { 1, 2, 1, 1 }, 4, new int[5] { 1, 4, 3, 2, 4 }, 5
            SolutionV2 solV2 = new SolutionV2();
            solV2.Solution8_2(5, new int[3] { 1, 1, 2 }, 3, new int[3] { 2, 2, 3 }, 3);//1, new int[3] { 1, 1, 3 }, 3, new int[3] { 3, 3, 2 }, 3 ___
            sol.Solution9(3, new int[7] { 1, 3, 1, 3, 2, 1, 3 }); //5, new int[8] { 1, 3, 1, 4, 2, 3, 5, 4 }
            sol.Solution10(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            sol.Solution11(new int[2] { -1, -3 });//new int[6] { 1, 3, 6, 4, 1, 2 }
            sol.Solution12(new int[5] { 0, 1, 0, 1, 1 });
            sol.Solution13("CAGCCTA", new int[3] { 2, 5, 0 }, new int[3] { 4, 5, 6 });
            //sol.Solution14(new int[7] { 4, 2, 2, 5, 1, 5, 8 });
            sol.Solution15(6, 11, 2);
            sol.Solution6_1(new int[6] { 2, 1, 1, 2, 3, 1 });
            //sol.Solution6_2(new int[6] { 10, 2, 5, 1, 8, 20 });
            sol.Solution6_3(new int[7] { 4, 7, 3, 2, 1, -3, -5 });//new int[6] { -3, 1, 2, -2, 5, 6 }---new int[5] { -4, -6, 3, 4, 5 }
            sol.Solution6_4(new int[] { 1, 5, 2, 1, 4, 0 });
            sol.Solution7_1("({{({}[]{})}}[]{})");//"{[()()]}"  ---"([)()]"
            sol.Solution7_3("(()(())())");
            sol.Solution7_4(new int[9] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });//new int[9] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }
            sol.Solution7_2(new int[8] { 1, 5, 4, 3, 7, 8, 6, 2 }, new int[8] { 1, 0, 0, 1, 1, 0, 0, 1 });//new int[8] { 4, 3, 2, 1, 5, 8, 7, 6 }, new int[8] { 0, 1, 0, 0, 0, 1, 0, 0 }----new int[8] { 1, 5, 4, 3, 7, 8, 6, 2 }, new int[8] { 1, 0, 0, 1, 1, 0, 0, 1 }
            sol.Solution8_1(new int[6] { 1, 2, 1, 1, 2, 1 });
            sol.Solution8_2(new int[8] { 3, 4, 3, 2, 3, -1, 3, 3 });//new int[8] { 3, 4, 3, 2, 3, -1, 3, 3 }
            sol.Solution9_1(new int[3] { -2, 1, 1 });//new int[5] { 3, 2, -6, 4, 0 }
            sol.Solution9_2(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 });
            sol.Solution9_3(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 });
            sol.Solution10_1(1);
            sol.Solution10_2(30);
            sol.Solution10_3(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2, 11, 2, 3, 4, 5, 11, 4, 5, 5, 5, 12, 1 });// 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2
            sol.Solution10_4(new int[] { 1, 2, 3, 3, 3, 4, 1, 2, 3, 4, 6, 2 });
            sol.Solution13_1(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 });
            //---------------------------------------------------------------------Redo
            SolutionRepeat repeat = new SolutionRepeat();
            repeat.BinaryGap(1041);
            repeat.CyclicRotation(new int[] { 3, 8, 9, 7, 6 }, 3);
            repeat.OddOccurrencesInArray(new int[] { 9, 3, 9, 3, 9, 7, 9 });
            repeat.PermMissingElem(new int[] { 2, 3, 1, 5 });
            repeat.FrogJmp(1, 1, 3); //1,1,3
            repeat.TapeEquilibrium(new int[] { 3, 1, 2, 4, 3 });
            repeat.PermCheck(new int[] { 4, 1, 3, 3, 5 });
            repeat.MissingInteger(new int[] { 1, 3, 6, 4, 1, 2 }); //-1,-3
            repeat.Distinct(new int[] { 2, 1, 1, 2, 3, 1 });
            //repeat.Brackets("{[()()]}"); //"([)()]" todo
            //repeat.Nesting("(()(())())");//"())"
            //repeat.StoneWall(new int[] { 0, 8, 5, 7, 9, 8, 7, 4, 8 });//maybe skip if to long
            //repeat.Dominator(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 });
            //repeat.MinPerimeterRectangle(30);
            //-------------------------------------------------------------------------Extra
            Extra extra = new Extra();
            extra.MirroredArray(new int[] { 2, 3, 4, 5, 6 });//infobip interview
            extra.OutputTrianglePattern(5);
            extra.OutputIncrementedNumbers(5);
            extra.OutputSquarePattern(6);
            extra.Palindrome("RADAR");
            extra.Palindrome("Nope");
            extra.OutputToConsole(5);
            extra.MoveNumbersInArrrayToEnd(new int[] { 1, 2, 3, 4, 5 }, 0);//Cubic interview prep
            extra.PascalsTriangle(6);
            extra.RowNumberTriangle(5);

            Console.ReadKey();
        }
    }

    internal class SolutionRepeat
    {
        public int BinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);//convert num to binary represention for base =2
            List<int> ones = new List<int>();
            int maxL = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    ones.Add(i);//add index if num =1
                }
            }
            if (ones.Count > 1)
            {
                for (int i = 0; i < ones.Count; i++)
                {
                    if (i > 0)
                    {
                        int length = ones[i] - ones[i - 1] - 1;
                        if (length > maxL)
                            maxL = length;
                    }
                }
            }
            return maxL;
        }

        public int[] CyclicRotation(int[] A, int K)
        {
            //Array.Copy(A, result, A.Length - K); 2nd solution  3rd     Array.Reverse(A, 0, A.Length - 1);
            //copy K numbers in new array , and paste after K items
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i + K < A.Length)
                {
                    int storedNum = A[i + K];
                    B[i + K] = A[i];
                }
                else
                {
                    B[(i + K) % A.Length] = A[i];
                }
            }
            return B;

            //int[] B = new int[A.Length];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int modulo = (i + K) % A.Length;
            //    B[(i + K) % A.Length] = A[i];
            //}

            //return B;
        }

        public int OddOccurrencesInArray(int[] A)
        {
            #region First try

            //Dictionary<int, int> pairs = new Dictionary<int, int>(); //num/repeated  66% 80% correct
            int solo = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (!pairs.ContainsKey(A[i]))
            //    {
            //        pairs.Add(A[i], 1);
            //    }
            //    else
            //    {
            //        pairs[A[i]] +=1;
            //    }
            //}

            //foreach (var item in pairs)
            //{
            //    if (item.Value ==1)
            //    {
            //        solo = item.Key;
            //    }
            //}

            #endregion First try

            //return solo;
            HashSet<int> onlyOne = new HashSet<int>(); //2nd solution 10%
            for (int i = 0; i < A.Length; i++)
            {
                if (!onlyOne.Contains(A[i]))
                {
                    onlyOne.Add(A[i]);
                }
                else
                {
                    onlyOne.Remove(A[i]);
                }
            }
            if (onlyOne.Count > 0)
            {
                solo = onlyOne.First();
            }
            return solo;
        }

        public int PermMissingElem(int[] A)
        {
            int missing = 0; //1st try 100%

            List<int> sortedList = A.OrderBy(item => item).ToList();
            IEnumerable<int> missingInList = Enumerable.Range(1, sortedList.Count + 1).Except(sortedList); //+1 because sequence is missing 1 alement and we need to compare it to complete sequence
            //Range ->kreira niz brojeva u range-u , Except usporedi 2 niza i doda koji fale u listu

            missing = missingInList.First();

            return missing;
            //2nd solution

            //int missing = 1;

            //if (A.Length >0)
            //{
            //    int max = A.Max();
            //    int min = A.Min();
            //    var B = Enumerable.Range(min, max).Except(A);
            //    if (B.Count() > 0)
            //    {
            //        missing = B.First();
            //    }
            //}

            //return missing;
        }

        public int FrogJmp(int X, int Y, int D)
        {
            //for 100% without loop
            int numberOfJumps = 0;
            while (X < Y)
            {
                X += D;
                numberOfJumps++;
            }
            return numberOfJumps;
            //if (D+X < Y) todo
            //{
            //    decimal dist = Math.Ceiling(Y / (X + (decimal)D));
            //    numberOfJumps = (int)dist;
            //}
            //return numberOfJumps;
        }

        public int TapeEquilibrium(int[] A)
        {
            List<int> passed = new List<int>();//redo performannce 0
            int result = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                passed.Add(A[i]);
                A[i] = 0;
                int diff = Math.Abs(passed.Sum() - A.Sum());
                if (diff < result)
                {
                    result = diff;
                }
            }
            return result;
        }

        public int PermCheck(int[] A)
        {
            //53%
            //HashSet<int> set = new HashSet<int>(A); //hashset only gets unique numbers(deletes repeated ones)
            //for (int i = 1; i < A.Length; i++)
            //{
            //    if (!set.Contains(i))
            //    {
            //        return 0;
            //    }
            //}
            //return 1;

            //83%
            int result = 1;

            var range = Enumerable.Range(A.Min(), A.Max()).Except(A);
            if (range.Count() > 0 || A.GroupBy(x => x).Any(i => i.Count() > 1))
            {
                result = 0;
            }

            return result;
        }

        public int MissingInteger(int[] A)
        {
            return 0;
        }

        //6
        public int Distinct(int[] A)
        {
            HashSet<int> distinct = new HashSet<int>(A);

            int result = distinct.Count;
            return result;
        }

        //7 TODO
        //public int Brackets(string S)
        //{
        //}
        //public int Nesting(string S)
        //{
        //}
        //public int StoneWall(int[] H)
        //{
        //}
        ////8
        //public int Dominator(int[] A)
        //{
        //}
        ////
        //public int MinPerimeterRectangle(int N)//perimiter is A*(A+B) -->return it
        //{
        //}
    }

    internal class Solution
    {
        public int solution1(int[] A)
        {
            //A = new int[3] { 1, 2, 3 };
            for (int i = 0; i < A.Length; i++)
            {
                if (!A.Contains(i) && i >= 1 && i <= 100000 && i < A.Max())
                {
                    return i;
                }
                else if (!A.Contains(i) && i >= 1 && i >= -100000 && i > A.Min())
                {
                    return i;
                }
            }
            return A.Max() + 1;
        }//demo zad (isti kao 11. zad -->tu je 100% performance)

        //public int[] solution2(int K)
        //{
        //    int[] A = new int[1] { 1000 };

        //    Dictionary<int, int> reOrdered = new Dictionary<int, int>();
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        int index = Array.IndexOf(A, A[i]);

        //        if (A[i] >= -1000 && A[i] <= 1000 && K >= 0 && K <= 100 && A.Length != 1)
        //        {
        //            index = i + K;
        //            if (index <= A.GetUpperBound(0))
        //            {
        //                Console.WriteLine(A[i] + " new index " + index);
        //                reOrdered.Add(index, A[i]);
        //            }
        //            else
        //            {
        //                int indexMoved = index - A.Length;
        //                reOrdered.Add(indexMoved, A[i]);
        //                Console.WriteLine(A[i] + " new index " + indexMoved);
        //            }
        //        }
        //        else
        //        {
        //            reOrdered.Add(index, A[i]);
        //        }
        //    }
        //    int[] B = new int[reOrdered.Count];
        //    Console.WriteLine();
        //    Console.Write("[");

        //    foreach (var item in reOrdered.Keys.OrderBy(item => item))
        //    {
        //        B[item] = reOrdered[item];
        //        Console.Write(B[item] + ",");
        //    }
        //    Console.Write("]");
        //    return B;
        //}

        public int Solution3(int[] A) //TODOD za svaki int in arrayu provjeri dal postoji isti(par) , ako ne (single je ) return it !
        {
            int unpairedValue = 0;

            foreach (int item in A)
            {
                unpairedValue ^= item; //^= je xor (exclusive OR)(ili je jedno ili nije nijedno tj. 0) (binarna operacija ,upareni brojevi se ponistavaju , ostaje 7)
            }
            return unpairedValue;
            // 2. preko hashseta , if it contains num ,delete it else save to hashset
        }

        public int Solution4(int[] A)
        {
            //var sorted = Enumerable.Range(0, sortedArray.Count() + 1).Except(sortedArray);

            int missing = 0;

            List<int> sortedList = A.OrderBy(item => item).ToList();
            var missingInList = Enumerable.Range(1, sortedList.Count + 1).Except(sortedList);
            //Range ->kreira niz brojeva u range-u , Except usporedi 2 niza i doda koji fale u listu

            missing = missingInList.ElementAtOrDefault(0);

            return missing;
        }

        public int Solution5(int X, int Y, int D)
        {
            int jumps = 0;

            #region for petlja

            for (int i = X; i < Y; i += D)
            {
                jumps++;
            }

            #endregion for petlja

            //if (X < Y)
            //{
            //    decimal dec = Math.Ceiling((decimal)Y / (D + X));
            //    jumps = (int)dec;
            //}
            return jumps;
        }

        public int Solution6(int[] A) //skip() ....take ()
        {
            int result = 0;
            int sumLeft = 0;
            int sumRight = 0;
            int sum = 0;
            HashSet<int> sums = new HashSet<int>();

            for (int i = 0; i < A.Count() - 1; i++)
            {
                sumRight = A.Skip(i + 1).Take(A.Count()).Sum();//sum je petlja pa ispada da je slozenost O (n^2)
                sumLeft += A[i];
                sum = Math.Abs(sumRight - sumLeft);
                sums.Add(sum);
            }
            result = sums.OrderByDescending(item => item).Last();
            return result;
        }

        public int Solution7(int[] A)
        {
            int result = 1;
            int lastValue = A.Last();

            var range = Enumerable.Range(1, lastValue).Except(A);
            if (range.Count() > 0 || A.GroupBy(x => x).Any(i => i.Count() > 1))
            {
                result = 0;
            }

            return result;
        }

        public int Solution8(int K, int[] C, int N, int[] D, int M) //92.ZAD --TODO (got 1 expected 2).-----(3, [1, 2], [8, 8, 8, 8, 9]) the solution returned a wrong answer (got 2 expected 1).
        {
            int result = 0;

            Dictionary<int, int> cleanQuery = C.GroupBy(x => x) //key =num , Value = repeated
                .Where(g => g.Count() > 0)
                .ToDictionary(x => x.Key, y => y.Count());

            List<int> tempList = new List<int>();
            IEnumerable<int> distinctClean = C.Distinct(); // O(n)
            int[] merge = new int[] { };

            if (K == 0)
            {
                foreach (int item in cleanQuery.Values)
                {
                    if (item > 1)
                    {
                        result += item / 2;
                    }
                }
            }
            else
            {
                for (int i = 0; i < distinctClean.Count(); i++)
                {
                    for (int j = 0; j < D.Length; j++)
                    {
                        if (D[j] == C[i])
                        {
                            tempList.Add(D[j]);
                            K--;
                        }
                    }
                }

                foreach (int item in cleanQuery.Keys.ToList()) //ToList so i can update dict(copy if dictionary) , while iterating
                {
                    if (tempList.Contains(item))
                    {
                        cleanQuery[item]++; //increment value in dictionary
                        K--;
                    }
                }
                foreach (int item in cleanQuery.Values)
                {
                    if (item > 1)
                    {
                        result += item / 2;
                    }
                }
                if (K > 0)
                {
                    Dictionary<int, int> dirtyQuery = D.GroupBy(x => x) //key =num , Value = repeated
                                          .Where(g => g.Count() > 0)
                                          .ToDictionary(x => x.Key, y => y.Count());

                    foreach (var item in dirtyQuery)
                    {
                        if (item.Value > 1)
                        {
                            result += item.Value / 2;
                        }
                    }
                }
            }
            return result;

            #region 1st,2ndTRY

            //int[] commonItems = C.Intersect(D).ToArray();
            //int[] merge = new int[C.Length + commonItems.Length];

            //if (commonItems.Count() > 1)
            //{
            //    Array.Copy(C, merge, C.Length);
            //    Array.Copy(commonItems, 0, merge, C.Length, commonItems.Length); //cleanArray + intersected
            //    result = merge.Count() / 2;
            //}

            //int result = 0;
            //int[] commonItems = C.Intersect(D).ToArray();

            //Dictionary<int, int> cleanQuery = C.GroupBy(x => x) //key =num , Value = repeated
            //    .Where(g => g.Count() > 0)
            //    .ToDictionary(x => x.Key, y => y.Count());

            //Dictionary<int, int> dirtyQuery = D.GroupBy(x => x) //key =num , Value = repeated
            //    .Where(g => g.Count() > 0)
            //    .ToDictionary(x => x.Key, y => y.Count());

            //if (K > 0)
            //{
            //    if (D.Length > 0)
            //    {
            //        int cleanArrOrgLength = C.Length;
            //        Array.Resize(ref C, cleanArrOrgLength + K);
            //        Array.Copy(commonItems, 0, C, cleanArrOrgLength, K); //problem , puca kod source arr lenghth ....zamjenit s necim drugim !!!
            //    }

            //    Dictionary<int, int> commonQuery = C.GroupBy(x => x)
            //    .Where(g => g.Count() > 0)
            //    .ToDictionary(x => x.Key, y => y.Count());

            //    foreach (var item in commonQuery.Values)
            //    {
            //        if (item > 1)
            //        {
            //            result += item / 2;
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (int item in cleanQuery.Values)
            //    {
            //        if (item > 1)
            //        {
            //            result += item / 2;
            //        }
            //    }
            //}

            //return result;

            #endregion 1st,2ndTRY
        }

        public int Solution9(int X, int[] A)
        {
            #region 1StTry---IEnum..low performance

            //var range = Enumerable.Range(1, X);
            //for (int i = 0; i < A.Count(); i++)
            //{
            //    values.Add(A[i]);
            //    IEnumerable<int> isInList = range.Except(values);//if none missing elements are found == index found
            //    if (isInList.Count() == 0)
            //    {
            //        result = i;
            //        break;
            //    }
            //}

            #endregion 1StTry---IEnum..low performance

            int result = -1;

            HashSet<int> values = new HashSet<int>(); //Hashset ---> provjera dok se svi brojevi do X ne popune u hashset

            for (int i = 0; i < A.Count(); i++)
            {
                if (!values.Contains(A[i])) //Contains --> O(n) if collection is also O(N) .
                {
                    values.Add(A[i]);
                    if (values.Count == X)
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }

        public int[] Solution10(int N, int[] A) //TODO ...Performanse ???
        {
            int[] startArray = new int[N];
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] > N)
                {
                    int maxVal = startArray.Max();
                    for (int j = 0; j < startArray.Count(); j++)
                    {
                        startArray[j] = maxVal;
                    }
                }
                else
                {
                    startArray[A[i] - 1]++;//-1 because counter in Arr starts at 0(we get val at ind 3 , and need one at 2)
                }
            }
            return startArray;
        }

        public int Solution11(int[] A)
        {
            int result = 0;

            int maxVal = A.Max();
            if (maxVal < 0)
            {
                maxVal = 1;
            }
            int[] range = Enumerable.Range(1, maxVal + 1).Except(A).ToArray();

            result = range[0];
            return result;
        }

        public int Solution12(int[] A)
        {
            #region 1StTry

            //    for (int i = 0; i < A.Count(); i++)
            //    {
            //        if (A[i] == 0)
            //        {
            //            for (int j = i + 1; j < A.Count(); j++)//2x loop makes for O(N**2 ) complexity
            //            {
            //                if (A[j] == 1)
            //                {
            //                    result++;
            //                }
            //            }
            //        }
            //    }

            #endregion 1StTry

            int result = 0;
            int zeroes = 0;
            int ones = 0;

            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] == 1)
                    ones++;
            }
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] == 0)
                {
                    zeroes++;
                }
                else
                {
                    result += zeroes; //multiply num of 0 by 1 when u encounter it in array
                    ones--;
                }
            }
            if (result > 1000000000 || result < 0)
            {
                return -1;
            }

            return result;
        }

        public int[] Solution13(String S, int[] P, int[] Q)//range between P-Q indexes
        {
            Dictionary<char, int> charValues = new Dictionary<char, int>();
            charValues.Add('A', 1);
            charValues.Add('C', 2);
            charValues.Add('G', 3);
            charValues.Add('T', 4);

            List<int> arrayPrep = new List<int>();
            int arrLength = P.Length;
            for (int i = 0; i < arrLength; i++)
            {
                int lenght = Q[i] - P[i] + 1;
                char sliced = S.Substring(P[i], lenght).OrderBy(letter => letter).FirstOrDefault(); //alphabet order ==value of item order
                arrayPrep.Add(charValues[sliced]);
            }
            int[] result = arrayPrep.ToArray();
            return result;
        }

        //public int Solution14(int[] A)// ???
        //{
        //}
        public int Solution15(int A, int B, int K)
        {
            #region 1STTry

            //var range = Enumerable.Range(A, count);
            //foreach (int item in range)
            //{
            //    if (item % K == 0)
            //    {
            //        devideable.Add(item);
            //    }
            //}

            #endregion 1STTry

            #region 2NDTry

            //int count = B - A + 1;
            //var devideableRange = Enumerable.Range(A, count).Where(item => item % K == 0);
            //int result = devideableRange.Count();

            #endregion 2NDTry

            HashSet<int> devideable = new HashSet<int>();

            for (int i = A; i <= B; i++) //Performance ??
            {
                if (i % K == 0)
                {
                    devideable.Add(i);
                }
            }
            int result = devideable.Count;

            return result;
        }

        public int Solution6_1(int[] A)
        {
            int result = A.Distinct().Count();
            return result;
        }

        //public int Solution6_2(int[] A) ??
        //{
        //}

        public int Solution6_3(int[] A)
        {
            int sum = 1;
            int sumAbs = 1;
            int[] sorted = A.OrderByDescending(item => item).ToArray();
            int[] sortedAbs = A.OrderByDescending(item => Math.Abs(item)).ToArray();

            for (int i = 0; i < 3; i++)
            {
                sum *= sorted[i];
                sumAbs *= sortedAbs[i];
            }
            if (sum > sumAbs)
                return sum;
            else
                return sumAbs;

            #region 1stTry

            //int sum = 1;
            //int[] sorted = A.OrderByDescending(item => item).ToArray();
            //int[] sortedAbs = A.OrderByDescending(item => Math.Abs(item)).ToArray();
            //for (int i = 0; i < 3; i++)
            //{
            //    if (sortedAbs[0] > 0)
            //    {
            //        sum *= sorted[i];
            //    }
            //    else
            //    {
            //        sum *= sortedAbs[i];
            //    }
            //}
            //return sum;

            #endregion 1stTry
        }

        public int Solution6_4(int[] A) //TODO ..kruznice
        {
            int result = 0;
            //Dictionary<int, int[]> centerAndRanges = new Dictionary<int, int[]>();
            List<int> maxValuesList = new List<int>();
            List<int> minValueList = new List<int>();
            for (int i = 0; i < A.Count(); i++)
            {
                //centerAndRanges.Add(i, new int[2] { i + A[i], i - A[i] });
                maxValuesList.Add(i + A[i]);
                minValueList.Add(i - A[i]);
            }
            int max = maxValuesList.Max();
            int min = minValueList.Min();
            result = maxValuesList.Count + minValueList.Count - 1;
            if (result > 10000000)
            {
                return -1;
            }
            return result;
        }

        public int Solution7_1(String S) //Also can solve with Dictionary <char,char> (check if list.count==0 ,return 1 else 0 )
        {
            char[] openBrackets = new char[3] { '(', '{', '[' };

            Stack<char> characters = new Stack<char>();//We add items to the top
            if (S.Length == 0)
                return 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (openBrackets.Contains(S[i]))
                {
                    characters.Push(S[i]);
                }
                else if (characters.Count == 0)
                {
                    return 0;
                }
                else if ((S[i] == ')' && characters.Peek() == '(') || (S[i] == '}' && characters.Peek() == '{') || (S[i] == ']' && characters.Peek() == '['))
                {
                    characters.Pop();
                }
            }
            if (characters.Count != 0)
                return 0;
            else
                return 1;
        }

        public int Solution7_3(String S)
        {
            Stack<char> characters = new Stack<char>();//We add items to the top

            if (S.Length == 0)
                return 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    characters.Push(S[i]);
                }
                else if (characters.Count == 0)
                {
                    return 0;
                }
                else if (S[i] == ')' && characters.Peek() == '(')
                {
                    characters.Pop();
                }
            }
            if (characters.Count != 0)
                return 0;
            else
                return 1;
        }

        public int Solution7_4(int[] H) //wall blocks
        {
            #region 1ST Try

            //Dictionary<int, HashSet<int>> hightIndexes = new Dictionary<int, HashSet<int>>();
            //for (int i = 0; i < H.Count(); i++)
            //{
            //    if (!hightIndexes.ContainsKey(H[i]))
            //    {
            //        hightIndexes.Add(H[i], new HashSet<int> { i });
            //    }
            //    else
            //    {
            //        hightIndexes[H[i]].Add(i); //if key exist add index to list
            //    }
            //}

            #endregion 1ST Try

            int numOfBlocks = 0;

            Stack<int> blockHights = new Stack<int>();//check if next block is > < than current one , if its < remove last one and blockCount ++,

            for (int i = 0; i < H.Count(); i++)
            {
                if (blockHights.Count() == 0)
                {
                    blockHights.Push(H[i]);

                    numOfBlocks++;
                }
                else if (H[i] < blockHights.Peek())
                {
                    while (blockHights.Count > 0 && H[i] < blockHights.Peek())
                    {
                        blockHights.Pop();
                    }
                    blockHights.Push(H[i]); //problem is H[6] 7 => because after we insert it , we count it again as block even tho 7 is already on top of stack (already counted Block)

                    numOfBlocks++;
                }
                else if (H[i] > blockHights.Peek())
                {
                    blockHights.Push(H[i]);

                    numOfBlocks++;
                }
            }
            return numOfBlocks;
        }

        //-------------->Bit Shifting (POSMAK) value << 1 is the same as multyplication by 2 , or value >> 1 same as devided by 2<-------------------

        public int Solution7_2(int[] A, int[] B)//TODO intersecting Fish
        {
            int currentDirection = 0;
            int currentFish = 0;

            #region 1stTry reverseStack

            //Stack<int> fishVolumes = new Stack<int>();
            //Stack<int> fishDirection = new Stack<int>();
            //for (int i = A.Count() - 1; i >= 0; --i) //added backwards because it's a Stack
            //{
            //    fishVolumes.Push(A[i]);
            //    fishDirection.Push(B[i]);
            //}

            //for (int i = 0; i < fishVolumes.Count; i++)
            //{
            //    currentFish = fishVolumes.Peek();
            //    currentDirection = fishDirection.Peek();

            //    if (fishVolumes.ElementAt(i) > currentFish && fishDirection.ElementAt(i) != currentDirection)
            //    {
            //        fishVolumes.Pop();
            //        fishDirection.Pop();
            //        i--;
            //    }
            //    else if (currentFish > fishVolumes.ElementAt(i) && currentDirection != fishDirection.ElementAt(i))
            //    {
            //        //remove that fish from list
            //    }
            //}
            //return fishVolumes.Count;

            #endregion 1stTry reverseStack

            //KeyValuePair<int, int> currentFish;
            Dictionary<int, int> fish = new Dictionary<int, int>();//TODO : Get 1st item with Value =1 ----> delete all < bellow it , get max key with value =0 -->delete all above ____Also can sort dict by keys and select top keys
            for (int i = 0; i < A.Count(); i++)
            {
                fish.Add(A[i], B[i]);
            }
            var sortedDict = fish.OrderByDescending(item => item.Key);
            int maxKey = fish.Keys.Max();
            var max = fish.Select(x => x.Value > 0);
            KeyValuePair<int, int> keyValueMax = new KeyValuePair<int, int>(maxKey, fish[maxKey]);

            foreach (var item in fish.ToList())
            {
                if (item.Value > 0)
                {
                }
            }

            //result = fish.Count;
            return 0;
        }

        public int Solution8_1(int[] A)//leader is the value that occurs in more than half of the array
        {
            int equiLeaderCount = 0;
            Stack<int> numbersStack = new Stack<int>();
            if (A.Count() == 1)
            {
                return 0;
            }
            for (int i = 0; i < A.Count(); i++)
            {
                if (numbersStack.Count > 0 && A[i] != numbersStack.Peek())
                {
                    numbersStack.Pop();
                }
                else
                {
                    if (numbersStack.Count == 0 || A[i - 1] != A[i])
                    {
                        equiLeaderCount++;
                    }
                    numbersStack.Push(A[i]);
                }
            }

            if (numbersStack.Count() > 0)
            {
                int leader = numbersStack.Peek();
                int leaderCount = A.Count(x => x == leader);
                if (leaderCount < A.Count() / 2)
                {
                    return 0;
                }
                else if (leaderCount == A.Count())
                {
                    equiLeaderCount = leaderCount - 1;
                }
            }
            else
            {
                return 0;
            }

            return equiLeaderCount;
        }

        public int Solution8_2(int[] A)
        {
            Stack<int> dominatorStack = new Stack<int>();
            for (int i = 0; i < A.Count(); i++)
            {
                if (dominatorStack.Count > 0 && A[i] != dominatorStack.Peek()) //Important to use Count (number of elements in stack)  !! not Count()( !!
                {
                    dominatorStack.Pop();
                }
                else
                {
                    dominatorStack.Push(A[i]);
                }
            }
            if (dominatorStack.Count > 0)
            {
                int dominator = dominatorStack.Peek();
                int dominatorCount = A.Count(X => X == dominator);
                if (dominatorCount < A.Count() / 2 + 1) //has to occur in more than half of the array
                {
                    return -1;
                }
                int[] indexes = A.Select((x, i) => x == dominator ? i : -1).Where(i => i != -1).ToArray();
                //IEnumerable<int> indexxes = Enumerable.Range(0, A.Length).Where(i => A[i] == dominator); //same thing
                Random random = new Random();
                int rndIndex = random.Next(indexes.Count());
                int indexValue = indexes[rndIndex];

                return indexValue;
            }
            else
            {
                return -1;
            }
        }

        public int Solution9_1(int[] A)
        {
            int maxSum = 0;
            int currentSum = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                currentSum += A[i];

                if (i > 0)
                {
                    //int slice = RecursionSlice(A[i]); //todo with recursion .. overflow atm //todo
                }
                //if (currentSum > maxSum)
                //{
                //    if (A[i] > currentSum)
                //    {
                //        maxSum = A[i];
                //        continue;
                //    }
                //    maxSum = currentSum;
                //}
                //else if (maxSum == 0 && currentSum != 0)
                //{
                //    maxSum = currentSum;
                //}
            }
            return maxSum;
        }

        //public static int RecursionSlice(int n)//todo
        //{
        //    return RecursionSlice(n) + RecursionSlice(n - 1);
        //}

        public int Solution9_2(int[] A)
        {
            int minValue = int.MaxValue;
            int profit = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] < minValue)
                {
                    minValue = A[i];
                }
                else
                {
                    if (A[i] - minValue > profit)
                    {
                        profit = A[i] - minValue;
                    }
                }
            }
            if (profit <= 0)
            {
                return 0;
            }
            return profit;
        }

        public int Solution9_3(int[] A) //TODO ???
        {
            return 0;
        }

        public int Solution10_1(int N)//efficient way TODO
        {
            int factorsCount = 0;
            double sqrt = Math.Sqrt(N);
            for (int i = 1; i <= sqrt; i++)
            {
                if (i * i == N)
                {
                    factorsCount++; //we get same nukber with / (division) so we count it once
                }
                else if (N % i == 0)
                    factorsCount += 2; //if number a is a divisor of n, then n/a is also a divisor (reason for +2)
            }
            return factorsCount;
        }

        public int Solution10_2(int N)
        {
            List<int> factors = new List<int>();
            int smallestPerimiter = int.MaxValue;

            double sqrt = Math.Sqrt(N);
            for (int i = 1; i <= sqrt; i++)
            {
                if (N % i == 0)
                {
                    factors.Add(i);
                }
            }
            for (int i = 0; i < factors.Count; i++)
            {
                int B = N / factors[i];
                int perimiter = 2 * (factors[i] + B);

                if (perimiter < smallestPerimiter)
                {
                    smallestPerimiter = perimiter;
                }
            }
            return smallestPerimiter;
        }

        public int Solution10_3(int[] A)//Flags
        {
            List<int> peaks = new List<int>();

            for (int i = 0; i < A.Count(); i++)
            {
                if (i > 0 && i != A.Length - 1 && A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);//take only indexes(distances of peeks) because we care about distance for flags
                }
            }
            if (peaks.Count == 0)
            {
                return 0;
            }
            int K = peaks.Count; /// K ???
            int maxFlags = 1;
            for (int i = 1; i < peaks.Count; i++)
            {
                int distance = Math.Abs(peaks[i] - peaks[i - 1]);
                if (distance >= K)
                {
                    maxFlags++;
                }
                else
                {
                    peaks.Remove(peaks[i]);
                    i--;
                }
            }
            return maxFlags;
        }

        public int Solution10_4(int[] A)//Peaks
        {
            List<int> peaks = new List<int>();
            int possibleBlocks = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if (i > 0 && i != A.Length - 1 && A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);//take only indexes(distances of peeks) because we care about distance for flags
                }
            }
            if (peaks.Count == 0)
            {
                return 0;
            }

            int divideParts = A.Length / peaks.Count;

            foreach (int index in peaks)
            {
                if (index <= divideParts)
                {
                    possibleBlocks++;
                    divideParts += divideParts;
                }
            }
            return possibleBlocks;
        }

        public int Solution13_1(int[] A)
        {
            //int frogStart = -1;
            int jumps = 0;
            List<int> fibNumbers = new List<int>();
            List<int> positionsWithLeaf = new List<int>();
            for (int i = 0; i < A.Count(); i++)
            {
                fibNumbers.Add(FibFrog(i));
                if (A[i] == 1)
                {
                    positionsWithLeaf.Add(i);
                }
            }

            for (int i = positionsWithLeaf.Count; i < fibNumbers.Count(); i++)
            {
                int c = FibFrog(i + 1);
                if (i + FibFrog(i) < FibFrog(i + 1)) //TODO ---provjera dal je udaljenost dovoljna za doc do iduceg lista ... i+ fib(i) >= fib(i+1) ...else...
                {
                    jumps++;
                }
                //int jumpLengt = FibFrog(positionsWithLeaf[i]);
            }
            return jumps;
        }

        public static int FibFrog(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibFrog(n - 1) + FibFrog(n - 2); // Fibb(2) => 2  =  Fibb(1) =>1 ---> Fibb(0) =>1
            }
        }
    }

    internal class Extra
    {
        public int[] MirroredArray(int[] A)
        {
            //switch places in pairs of 2 numbers (reason for A.length/2)
            int tempStore = 0;
            int counter = 0;
            for (int i = 0; i < A.Length / 2; i++)
            {
                counter++; // or instead "i+1"
                tempStore = A[i];
                A[i] = A[A.Length - counter];
                A[A.Length - counter] = tempStore;
            }
            return A;
        }

        public void OutputTrianglePattern(int N)
        {
            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <= i; j++)//execute whole loop than go back to next itteration of i
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = N-1; i >=1; i--)//n-1 so we skip duplication
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //2nd pattern
            //for (int i = N; i >=1; i--)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <=N ; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //3rd patern Continous numbers
            //int counter = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        counter++;
            //        Console.Write(counter);
            //    }
            //    Console.WriteLine();
            //}
        }

        public void OutputSquarePattern(int N)
        {
            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <= 3; j++) //in 3 rows
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }

        public void OutputIncrementedNumbers(int N)
        {
            for (int i = 0; i < N; i++)
            {
                //Console.Write(i *2 + ",");
            }
            //more performant
            for (int i = 0; i < N; i += 2)
            {
                //Console.WriteLine(i);
            }
        }

        public int Palindrome(string S)
        {
            if (S.Length % 2 != 0) //check if number is odd first -else its not palindrome
            {
                char[] characters = S.ToCharArray();
                Array.Reverse(characters);

                string reversed = new String(characters);
                if (S == reversed)
                {
                    return 1;
                }
            }
            return 0;
            //2nd way shorter
            //return myString.SequenceEqual(myString.Reverse());
        }

        public int[] MoveNumbersInArrrayToEnd(int[] A, int N)//in second rounf 3,1
        {
            int[] rotatedArray = new int[A.Length];
            //start: [1,2,3,4,5] result: [4,5,1,2,3] example

            int counter = 0;//triggers for remaining numbers
            for (int i = 0; i < A.Length; i++)
            {
                if (i < N)
                {
                    rotatedArray[rotatedArray.Length - N + i] = A[i];//move first ,than print rest to end
                }
                else
                {
                    rotatedArray[counter] = A[i];//put remaining numbers in front (same thing as before but reverse)
                    counter++;
                }
            }

            return rotatedArray;
        }

        public void OutputToConsole(int N)
        {
            //int counter = 1;
            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <=N; j++)
            //    {
            //        Console.Write("+");
            //    }
            //    Console.WriteLine();
            //}
        }

        //TODO practice
        /*1
         *121
         *12321
         *1234321
         *123454321
         *12345654321*/

        public void RowNumberTriangle(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                int[] nums = new int[i];

                for (int j = 1; j <= i; j++)
                {
                    nums[j - 1] = j; //add each to arr
                    Console.Write(j);
                }
                //revere already printed nums and skip miiddle one
                int[] reversed = nums.Reverse().Skip(1).ToArray();
                for (int k = 0; k < reversed.Length; k++)
                {
                    Console.Write(reversed[k]);
                }
                Console.WriteLine();
            }
        }

        /* pascal
         * 1
         *1 1
         1 2 1
        1 3 3 1
       1 4 6 4 1 */

        public void PascalsTriangle(int N) //todo
        {
            //    for (int i = 1; i <= N; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            if (i > 2)
            //            {
            //                if (true)
            //                {
            //                }
            //            }
            //            else
            //            {
            //                Console.Write(1);
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}