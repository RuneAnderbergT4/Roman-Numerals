﻿using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    public class Converter
    {
        public Converter()
        {

        }

        private string _output;
        private string _number;
        private string _invertedNumber;
        private char[] _chars = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

        public string IntToRomanNumerals(int n)
        {
            _number = n.ToString();

            return _output;

            
        }
    }
}
