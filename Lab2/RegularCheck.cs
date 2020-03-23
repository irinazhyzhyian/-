using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_2
{
    class RegularCheck
    {
        public string optimiseMask(string mask)
        {
            string newMask = "";
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == '^')
                {
                    newMask += '^';
                    while (i < mask.Length && mask[i] == '^')
                        i++;
                    if (i == mask.Length)
                        return newMask;
                }
                newMask += mask[i];
            }
            return newMask;
        }

        public string getNewMask(string mask)
        {
            string pattern = "\\^";
            string replacement = "[aoiuey]*";
            Regex rgx = new Regex(pattern);
            mask = rgx.Replace(mask, replacement);
            return mask;
        }
    }
}
