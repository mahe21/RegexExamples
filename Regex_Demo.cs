﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public void CheckPattern(string name)
        {
            string myName = "^[A-Z][a-z]{3,}?";
            
            if (Regex.IsMatch(name,myName))
            {
                Console.WriteLine("its a match");
            }
            else
            {
                Console.WriteLine("its different");
            }
        }

        public void CheckLastName(string name)
        {
            string myName = "^[A-Z][a-z]{3,}?";

            if (Regex.IsMatch(name, myName))
            {
                Console.WriteLine("its a match");
            }
            else
            {
                Console.WriteLine("its different");
            }
        }

        public void PhoneNumber(string number)
        {
            string myNumber = "^[0-9]{2}[][0-9]{10}$";

            if (Regex.IsMatch(number, myNumber))
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
