using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    // Regex is a pattern that is used to check whether a given string matches matches that pattern
    public class Regex_Demo
    {
        static string pattern = "^cen$";
        // ^ indicates the start
        // $ indicates the end

        public void RegexEx()
        {
            Regex regex = new Regex(pattern);
            if(regex.IsMatch("cen") )
            {
                Console.WriteLine("its a match");
            }
            else
            {
                Console.WriteLine("its different");
            }
        }
    }
}
