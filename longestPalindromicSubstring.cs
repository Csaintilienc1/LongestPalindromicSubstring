using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    public class longestPalindromicSubstring
    {
        public string longestPalSubstring(string a)
        {

            char[] charArray = a.ToCharArray();

            int begin = 0;
            
            int end = charArray.Length-1;

            String longestPalSubstr = " ";
            while(begin < end)
            {
                if (charArray[begin] == charArray[end])
                {
                    string currentPalSubstr = a.Substring(begin, end);
                    if(currentPalSubstr.Length > longestPalSubstr.Length) 
                    {
                        longestPalSubstr = currentPalSubstr;
                        begin++;
                        end--;
                    
                    }
                    else
                    {
                        begin++;
                        end--;

                    }
                   // return longestPalSubstr;
                   // begin++;
                   // end--;
                }
              //   return longestPalSubstr;
              //  begin++;
              //  end--;
            }
            return longestPalSubstr;
        }
    }
}
