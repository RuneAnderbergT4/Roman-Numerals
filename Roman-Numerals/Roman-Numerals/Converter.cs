using System;
using System.Collections.Generic;

namespace Roman_Numerals
{
    public class Converter
    {
        public Converter()
        {

        }

        private string _output;
        private List<int> _number;
        private char[] _chars = {'I', 'V', 'X', 'L', 'C', 'D', 'M', 'F', 'F'};

        public string IntToRomanNumerals(int n)
        {
            _number = new List<int>();
            _output = string.Empty;

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

            //Thousands();
            //Hundreds();
            //Tenths();
            //Ones();

            
            Digit(_number[0], _chars[6], _chars[7], _chars[8]);
            Digit(_number[1], _chars[4], _chars[5], _chars[6]);
            Digit(_number[2], _chars[2], _chars[3], _chars[4]);
            Digit(_number[3], _chars[0], _chars[1], _chars[2]);


            return _output;
        }

        //private void Thousands()
        //{
        //    for (int i = 0; i < _number[0]; i++)
        //    {
        //        _output += _chars[6];
        //    }
        //}

        //private void Hundreds()
        //{
        //    if (_number[1] == 0) return;
        //    if (_number[1] <= 3)
        //        for (int i = 0; i < _number[1]; i++)
        //        {
        //            _output += _chars[4];
        //        }
        //    else if (_number[1] == 4)
        //        _output += (_chars[4].ToString() + _chars[5]);
        //    else if (_number[1] <= 8)
        //    {
        //        _output += _chars[5];
        //        for (int i = 0; i < _number[1] - 5; i++)
        //        {
        //            _output += _chars[4];
        //        }
        //    }
        //    else
        //        _output += (_chars[4].ToString() + _chars[6]);
        //}

        //private void Tenths()
        //{
        //    if (_number[2] == 0) return;
        //    if (_number[2] <= 3)
        //        for (int i = 0; i < _number[2]; i++)
        //        {
        //            _output += _chars[2];
        //        }
        //    else if (_number[2] == 4)
        //        _output += (_chars[2].ToString() + _chars[3]);
        //    else if (_number[2] <= 8)
        //    {
        //        _output += _chars[3];
        //        for (int i = 0; i < _number[2] - 5; i++)
        //        {
        //            _output += _chars[2];
        //        }
        //    }
        //    else
        //        _output += (_chars[2].ToString() + _chars[4]);
        //}

        //private void Ones()
        //{
        //    if (_number[3] == 0) return;
        //    if (_number[3] <= 3)
        //        for (int i = 0; i < _number[3]; i++)
        //        {
        //            _output += _chars[0];
        //        }
        //    else if (_number[3] == 4)
        //        _output += (_chars[0].ToString() + _chars[1]);
        //    else if (_number[3] <= 8)
        //    {
        //        _output += _chars[1];
        //        for (int i = 0; i < _number[3] - 5; i++)
        //        {
        //            _output += _chars[0];
        //        }
        //    }
        //    else
        //        _output += (_chars[0].ToString() + _chars[2]);
        //}

        private void Digit(int n, char c1, char c2, char c3)
        {
            if (n == 0) return;
            if (n <= 3)
                for (int i = 0; i < n; i++)
                {
                    _output += c1;
                }
            else if (n == 4)
                _output += (c1.ToString() + c2);
            else if (n <= 8)
            {
                _output += c2;
                for (int i = 0; i < n - 5; i++)
                {
                    _output += c1;
                }
            }
            else
                _output += (c1.ToString() + c3);
        }
    }
}
