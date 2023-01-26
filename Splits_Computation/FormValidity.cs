using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Splits_Computation
{
    internal class FormValidity
    {
        public static bool CheckFilePath(string filepath)
        {
            return filepath != "";
        }

        public static bool CheckTargetTime(string targetTime)
        {
            Match match = Regex.Match(targetTime, @"^\d\d:\d\d:\d\d$");
            return match.Success;
        }
    }
}
