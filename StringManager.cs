using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Keeton
{
    internal class StringManager : Override
    {
        public string Reverse(string s)
        {
            int a = s.Length;
            string reverse = string.Empty;
            Stack stack = new Stack(a);

            for (int i = 0; i < a; i++)
            {
                stack.Push(s[i]);
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            return reverse;
        }
        public string _reverse(string s, bool PreserveCaseLocation)
        {
            string reverse = "";
            char[] keep = new char[s.Length];
            Stack stack = new Stack(s.Length);
            bool[] UpperCase = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsUpper(c)) 
                { 
                    UpperCase[i] = true; 
                }
                if (char.IsLower(c))
                { 
                    UpperCase[i] = false; 
                }
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            for (int i = 0; i < reverse.Length; i++)
            {
                char a = reverse[i];
                if (UpperCase[i] == true) 
                {
                    keep[i] = char.ToUpper(a); 
                }
                if (UpperCase[i] == false) 
                { 
                    keep[i] = char.ToLower(a);
                }
            }
            string output = new string(keep);


            return output;
        }
        public bool Symmetric(string s)
        {
            string reverse = string.Empty;
            Stack stack = new Stack(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push((char)s[i]);
            }

            while (stack.Count > 0)
            {
                reverse += stack.Pop();
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j < reverse.Length; j++)
                {
                    if (s[i] == reverse[j]) 
                    { 
                        return true; 
                    }

                    else 
                    { 
                        return false;
                    }
                }
            }
            return false;
        }
        public override string ToString(string s)
        {
            char _char = ' ';
            int[] num = new int[s.Length];
            int add = 0;
            string output = string.Empty;

            if (s.Length <= 0)
            { 
                output = "Negative One "; 
                return output; 
            }

            for (int i = 0; i < s.Length; i++)
            {
                _char = s[i];
                add += (int)_char;
            }

            string sum = add.ToString();
            char[] comp = sum.ToCharArray();
            string[] part = new string[sum.Length];
            string[] all = new string[part.Length];

            for (int i = 0; i < part.Length; i++)
            {
                part[i] = char.ToString(comp[i]);

            }

            for (int i = 0; i < part.Length; i++)
            {

                if (part[i] == "1") 
                {
                    all[i] = " One "; 
                }

                if (part[i] == "2")
                { 
                    all[i] = " Two ";
                }

                if (part[i] == "3")
                {
                    all[i] = " Three "; 
                }

                if (part[i] == "4") 
                { 
                    all[i] = " Four ";
                }

                if (part[i] == "5")
                { 
                    all[i] = " Five ";
                }

                if (part[i] == "6")
                { 
                    all[i] = " Six "; 
                }

                if (part[i] == "7") 
                { 
                    all[i] = " Seven "; 
                }

                if (part[i] == "8")
                { 
                    all[i] = " Eight "; 
                }

                if (part[i] == "9") 
                { 
                    all[i] = " Nine "; 
                }

                if (part[i] == "0") 
                { 
                    all[i] = " Zero ";
                }

            }

            foreach (string i in all)
            {
                output += i;
            }

            return output;
        }
        public override bool Equals(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];
                if (char.IsDigit(a)) 
                { 
                    return false; 
                }
            }

            string b = "Hello World";

            if (s.Equals(b)) 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }

            return s.Equals(ToString(s)); ;
        }
    }
}
