﻿using System;
using System.Runtime.InteropServices;

namespace NConstrictor
{
    public class PyUnicode
    {
        [DllImport(@"Python3.dll", EntryPoint = "PyUnicode_DecodeFSDefault", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr DecodeFSDefault(string s);
    }
}
