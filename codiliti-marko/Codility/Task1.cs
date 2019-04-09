using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Task1
    {
        public string solution(string S)
        {
            //all extensions not specified here are for other files
            Dictionary<string, string> extensionToFileTypeDictionary = new Dictionary<string, string>()
            {
                {"mp3", "music"},
                {"aac", "music"},
                {"flac", "music"},
                {"jpg", "images"},
                {"bmp", "images"},
                {"gif", "images"},
                {"mp4", "movies"},
                {"avi", "movies"},
                {"mkv", "movies"}
            };

            //500 lines, 1,000,000 bytes => no need for long, int is ok
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>()
            {
                { "music", 0 },
                { "images", 0 },
                { "movies", 0 },
                { "other", 0 }
            };

            //StringSplitOptions.RemoveEmptyEntries handles empty input string
            string[] lines = S.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string filename = parts[0];
                string sizeString = parts[1].Substring(0, parts[1].Length - 1);
                int size = int.Parse(sizeString);

                int lastDotIndex = filename.LastIndexOf(".");

                //extensions are all lower-case in the input string, so there is no need for .ToLower()
                string extension = filename.Substring(lastDotIndex + 1, filename.Length - lastDotIndex - 1);

                string fileType = "other";
                if (extensionToFileTypeDictionary.ContainsKey(extension)) fileType = extensionToFileTypeDictionary[extension];
                resultDictionary[fileType] += size;
            }

            string result = "music " + resultDictionary["music"] + "b" + Environment.NewLine +
                "images " + resultDictionary["images"] + "b" + Environment.NewLine +
                "movies " + resultDictionary["movies"] + "b" + Environment.NewLine +
                "other " + resultDictionary["other"] + "b" + Environment.NewLine;

            return result;
        }
    }
}