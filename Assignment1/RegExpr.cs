using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var item in lines)
            {
                foreach (var word in item.Split(' ')) {
                    yield return word;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
           var pattern = @"((?<resX>\d+)x(?<resY>\d+))+"; 
         
           foreach (var line in resolutions) {
               foreach (Match match in Regex.Matches(line, pattern))
               {
                   yield return (Int32.Parse(match.Groups["resX"].Value), Int32.Parse(match.Groups["resY"].Value));
               }
           }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
           var pattern = $@"(<{tag}.*?>(?<innerText>.+?)<\/{tag}>)+";

            foreach (Match match in Regex.Matches(html, pattern))
            {
                yield return Regex.Replace(match.Groups["innerText"].Value, @"(<.+?>)|(<\/.+?>)", "");
            }
        }
    }
}
