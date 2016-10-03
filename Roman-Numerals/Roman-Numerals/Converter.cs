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
        private List<int> _number = new List<int>();
        private char[] _chars = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};

        public string IntToRomanNumerals(int n)
        {
            while (n > 0)
            {
                _number.Add(n % 10);
                n /= 10;
            }

            while (_number.Count < 4)
            {
                _number.Add(0);
            }
            
            _number.Reverse();

            Thousands();
            Hundreds();
            Tenths();
            Ones();

            return _output;
        }

        private void Thousands()
        {
            for (int i = 0; i < _number[0]; i++)
            {
                _output += _chars[6];
            }
        }

        private void Hundreds()
        {
            if (_number[1] == 0) return;
            if (_number[1] <= 3)
                for (int i = 0; i < _number[1]; i++)
                {
                    _output += _chars[4];
                }
            else if (_number[1] == 4)
                _output += (_chars[4].ToString() + _chars[5]);
            else if (_number[1] <= 8)
            {
                _output += _chars[5];
                for (int i = 0; i < _number[1] - 5; i++)
                {
                    _output += _chars[4];
                }
            }
            else
                _output += (_chars[4].ToString() + _chars[6]);
        }

        private void Tenths()
        {
            if (_number[2] == 0) return;
            if (_number[2] <= 3)
                for (int i = 0; i < _number[3]; i++)
                {
                    _output += _chars[2];
                }
            else if (_number[2] == 4)
                _output += (_chars[2].ToString() + _chars[3]);
            else if (_number[2] <= 8)
            {
                _output += _chars[3];
                for (int i = 0; i < _number[2] - 5; i++)
                {
                    _output += _chars[2];
                }
            }
            else
                _output += (_chars[2].ToString() + _chars[4]);
        }

        private void Ones()
        {
            if (_number[3] == 0) return;
            if (_number[3] <= 3)
                for (int i = 0; i < _number[3]; i++)
                {
                    _output += _chars[0];
                }
            else if (_number[3] == 4)
                _output += (_chars[0].ToString() + _chars[1]);
            else if (_number[3] <= 8)
            {
                _output += _chars[1];
                for (int i = 0; i < _number[3] - 5; i++)
                {
                    _output += _chars[0];
                }
            }
            else
                _output += (_chars[0].ToString() + _chars[2]);
        }
    }
}
