using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgo_sharecode.CSGOSharecode.Extensions
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            var temp = str.ToCharArray().Reverse();
            return string.Join("", temp);
        }
    }
}
