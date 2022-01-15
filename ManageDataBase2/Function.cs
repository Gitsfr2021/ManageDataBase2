using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManageDataBase2
{
  public static   class Function
    {
        private static readonly Regex _regex = new Regex("[A-Za-z0-9]"); //regex that matches disallowed text
        public static string IsTextAllowed(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "Please enter the name of the database";
               if(!_regex.IsMatch(text))
                return "Only numbers and letters are allowed for the database name ";
               
            return "";
        }

    }
}
