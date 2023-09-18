using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// stringName могут содержать в себе только буквы и следующие символы: пробел и дефис.
        /// stringName не могут быть длиннее 50 символов.
        /// </summary>
        /// <param name="stringName"></param>
        /// <returns>true/false</returns>
        public bool CheckName(string stringName)
        {
            string regex = @"^(?=.{1,50}$)(([а-я])|(\s)|(\-))+$";
            string regexWhiteSpace = @"^((\s)|(\-))+$";

            if (Regex.Match(stringName, regexWhiteSpace, RegexOptions.IgnoreCase).Success)
            {
                return false;
            }
            else
            {
                if (Regex.Match(stringName, regex, RegexOptions.IgnoreCase).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
