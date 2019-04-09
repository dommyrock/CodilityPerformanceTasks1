using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa1
{
    public class SolutionV2
    {
        public int Solution8_2(int K, int[] C, int N, int[] D, int M)
        {
            //IEnumerable<int> distinctClean = C.Distinct(); // O(n) -----Dist.. so we only check Contains once per num
            //IEnumerable<int> distinctDirty = D.Distinct();
            int result = 0;

            Dictionary<int, int> cleanQuery = C.GroupBy(x => x) //key =num , Value = repeated
                .Where(g => g.Count() > 0)
                .ToDictionary(x => x.Key, y => y.Count());

            Dictionary<int, int> dirtyQuery = D.GroupBy(x => x) //key =num , Value = repeated
                 .Where(g => g.Count() > 0)
                 .ToDictionary(x => x.Key, y => y.Count());

            List<int> tempList = new List<int>();

            bool anyExist = cleanQuery.Any(x => dirtyQuery.ContainsKey(x.Key));
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
            else if (anyExist == true && K > 0)
            {
                foreach (var cItem in cleanQuery.ToList()) //(provjera po Dict. Keys) ....ToList( so we can modify collection while we iterate it )
                {
                    foreach (var dItem in dirtyQuery.ToList())
                    {
                        if (cItem.Key == dItem.Key)
                        {
                            for (int i = 1; i <= K; i++)
                            {
                                cleanQuery[cItem.Key]++; //TODO remove uvijet koji mice iz dirty prebacene brojeve da ne iteriramo vec prodjene !!!
                                K--;
                            }
                        }
                    }
                }
                foreach (var item in cleanQuery)
                {
                    result += item.Value / 2;
                }
            }
            else if (anyExist == false && K > 0)
            {
                foreach (var item in dirtyQuery)
                {
                    if (item.Value > 1)
                    {
                        cleanQuery.Add(item.Key, item.Value);
                    }
                }
                foreach (var item in cleanQuery)
                {
                    result += item.Value / 2;
                }
            }

            return result;
        }
    }
}