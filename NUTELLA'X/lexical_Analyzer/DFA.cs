using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace lexical_Analyzer
{

    class DFA
    {

        public int[,] TT;
        public int IS;
        public int[] FS;
        public string[] chars;

        public DFA()
        {
        }


        public DFA(int[,] TT, int IS, int[] FS, string[] chars)
        {

            this.FS = FS;
            this.IS = IS;
            this.TT = TT;
            this.chars = chars;

        }


        public bool validate(string input)  //while loop
        {
            int st = IS;
            int i = 0;
            while (i < input.Length)
            {
                st = transition1(st, input[i++]);
                if (st == -1)
                {

                    return false;
                }
            }
            int j = 0;

            {
                while (j < FS.Length)
                {
                    if (st == FS[j])
                    {
                        return true;
                    }
                    j++;
                }
            }
            return false;
        }


        private int transition1(int st, char ch)
        {


            Regex[] R = new Regex[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {

                R[i] = new Regex(chars[i]);
            }

            for (int j = 0; j < chars.Length; j++)
            {

                if (R[j].Match(ch.ToString()).Success)
                {
                    return TT[st, j];
                }
            }


            return -1;


        }

    }
}


