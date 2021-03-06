﻿using System.Linq;

namespace MyLibrary
{
    public static class MySubStringExtension
    {
        public static string MySubString(this string value, int startIndex, int length)
        {
            return new string((value?? string.Empty).Skip(startIndex).Take(length).ToArray());
        }
    }
}