using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class SocksLaundering
    {
        //100%
        public int solution(int K, int[] C, int[] D)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < C.Length; i++)
            {
                if (!dictionary.ContainsKey(C[i])) dictionary.Add(C[i], 1);
                else dictionary[C[i]]++;
            }

            //sparene i čiste
            int count = dictionary.Values.Select(item => item / 2).Sum();

            int[] unpairedClean = dictionary.Keys.Where(item => dictionary[item] % 2 == 1).ToArray();

            if (K > 0)
            {
                Dictionary<int, int> dirtyDict = new Dictionary<int, int>();
                for (int i = 0; i < D.Length; i++)
                {
                    if (!dirtyDict.ContainsKey(D[i])) dirtyDict.Add(D[i], 1);
                    else dirtyDict[D[i]]++;
                }

                HashSet<int> unpairedDirty = new HashSet<int>(dirtyDict.Keys.Where(item => dirtyDict[item] % 2 == 1).ToArray());

                //prvo probaj spariti nesparenu čistu sa nesparenom prljavom
                for (int i = 0; i < unpairedClean.Length; i++)
                {
                    if (unpairedDirty.Contains(unpairedClean[i]))
                    {
                        count++;
                        dirtyDict[unpairedClean[i]]--;
                        dictionary[unpairedClean[i]]--;
                        K--;
                        if (K == 0) break;
                    }
                }

                if (K > 0)
                {
                    unpairedClean = dictionary.Keys.Where(item => dictionary[item] % 2 == 1).ToArray();
                    HashSet<int> dirty = new HashSet<int>(dirtyDict.Keys.Where(item => dirtyDict[item] > 0).ToArray());
                    //zatim probaj spariti nesparenu čistu sa bilo kojom prljavom
                    for (int i = 0; i < unpairedClean.Length; i++)
                    {
                        if (dirty.Contains(unpairedClean[i]))
                        {
                            count++;
                            dirtyDict[unpairedClean[i]]--;
                            K--;
                            if (K == 0) break;
                        }
                    }
                }

                //nakon toga, ako još ima mjesta, uzmi sparene prljave
                int leftDirtyPairsCount = dirtyDict.Values.Select(item => item / 2).Sum();
                count += Math.Min(K / 2, leftDirtyPairsCount);
            }

            return count;
        }
    }
}