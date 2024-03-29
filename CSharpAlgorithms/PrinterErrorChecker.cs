﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public static class PrinterErrorChecker
    {
        //The colors used by the printer are recorded in a control string. For example a "good" control string would be aaabbbbhaijjjm
        //meaning that the printer used three times color a, four times color b, one time color h then one time color a...
        //Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced e.g.aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
        //You have to write a function printer_error which given a string will return the error rate of the printer as a string representing a rational whose numerator is the
        //number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.
        //The string has a length greater or equal to one and contains only letters from a - z
        //
        //Test Cases
        //s="aaabbbbhaijjjm"
        //printer_error(s) => "0/14"
                
        //s="aaaxbbbbyyhwawiwjjjwwm"
        //printer_error(s) => "8/22"

        public static string PrinterError(String s)
        {
            int i = 0;
            string str = "abcdefghijklm";
            foreach (var a in s)
            {
                if (!str.Contains(a))
                    i++;
            }
            return $"{i.ToString()}/{s.Length.ToString()}";
        }
    }
}
