using System;
using System.Collections.Generic;
using System.Text;

namespace PasswortGenerator
{
    public class Passwort
    {
        //Declare Charsets
        private int _length;
        private string _charSetHC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _charSetLC = "abcdefghijklmnopqrstuvwxyz";
        private string _charSetD = "1234567890";
        private string _charSetSC = "!§$%&/()=?'*_-.:,;+#~^°<>|"+'"';
        private string _charSet;

        //Standardconstructor
        public Passwort()
        {
            _length = 16;
            _charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ12344567890!§$%&/()=?'*_-.:,;+#~^°<>|"+'"'+"abcdefghijklmnopqrstuvwxyz";
        }
        //Userspecific Constructor
        public Passwort(bool hasLC, bool hasHC, bool hasD, bool hasSC, int length)
        {
            if (hasLC)
            {
                _charSet = _charSet + _charSetLC;
            }
            if (hasHC)
            {
                _charSet = _charSet + _charSetHC;
            }
            if (hasD)
            {
                _charSet = _charSet + _charSetD;
            }
            if (hasSC)
            {
                _charSet = _charSet + _charSetSC;
            }

            _length = length;
        }
        public int length
        {
            get
            {
                return _length;
            }
        }

        public string charSet
        {
            get
            {
                return _charSet;
            }
        }

        public string GeneratePassword()
        {
            string keyword = "";
            //Generate Random Password
            Random dice = new Random();
            int dicefall;
            for (int i = 0; i<length; i++)
            {
                dicefall = dice.Next(charSet.Length);
                    
                keyword = keyword + charSet[dicefall];
            }
            
            return keyword;
        }
    }
}
