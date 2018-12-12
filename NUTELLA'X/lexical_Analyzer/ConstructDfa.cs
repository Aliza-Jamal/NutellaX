using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lexical_Analyzer
{
    class ConstructDfa
    {
        public string BuildDFa(string Input)
        {
            int[,] ID_TT = { { 2, 1, 2 }, { 3, 2, 2 }, { 2, 2, 2 }, { 3, 2, 4 }, { 2, 2, 2 } };  // Transition Table for Identifier
            string[] ID_RE = { "^([A-Za-z0-9])$", "^(@)$", "^(_)$" };    // RE for Identifier
            int[] ID_FS = { 4 };  // Final state of identifier     
            DFA ID = new DFA(ID_TT, 0, ID_FS, ID_RE);

            int[,] Float_TT = { { 3, 1, 2, 4 }, { 4, 1, 2, 4 }, { 4, 5, 4, 4 }, { 4, 1, 2, 4 }, { 4, 4, 4, 4 }, { 4, 5, 4, 6 }, { 7, 8, 4, 4 }, { 4, 8, 4, 4 }, { 4, 8, 4, 4 } };
            string[] Float_RE = { "^([+]|[-])$", "^([0-9])$", "^(\\.)$", "^(e)$" };
            int[] Float_FS = { 5, 8 };
            DFA FLOAT = new DFA(Float_TT, 0, Float_FS, Float_RE);

            int[,] Int_TT = { { 1, 2 }, { 3, 2 }, { 3, 2 }, { 3, 3 } };
            string[] Int_RE = { "^([+]|[-])$", "^([0-9])$" };
            int[] Int_FS = { 2 };
            DFA INT = new DFA(Int_TT, 0, Int_FS, Int_RE);

            int[,] Char_TT = { { 1, 4, 4, 4, 4, 4, 4, 4, 4 }, { 4, 5, 2, 2, 2, 2, 2, 2, 2 }, { 3, 4, 4, 4, 4, 4, 4, 4, 4 }, { 4, 4, 4, 4, 4, 4, 4, 4, 4 }, { 4, 4, 4, 4, 4, 4, 4, 4, 4 }, { 3, 2, 2, 2, 2, 2, 2, 2, 4 } };

            string[] Char_RE = { "^(`)$", "\\\\", "n", "r", "t", "b", "v", "f", "^.$" };
            int[] Char_FS = { 3 };
            DFA CHAR = new DFA(Char_TT, 0, Char_FS, Char_RE);



            int[,] String_TT = { { 1, 5, 5 }, { 2, 3, 1 }, { 5, 5, 5 }, { 4, 3, 1 }, { 2, 3, 1 }, { 5, 5, 5 } };
            string[] String_RE = { "^(#)$", "\\\\", "^.*$" };
            int[] String_FS = { 2 };
            DFA STRING = new DFA(String_TT, 0, String_FS, String_RE);





            if (ID.validate(Input))
            {
                Console.WriteLine("ID {0}", Input);
                return "IDENTIFIER";

            }

            else if (INT.validate(Input))
            {
                Console.WriteLine("int {0}", Input);
                return "int_num";
            }

            else if (FLOAT.validate(Input))
            {
                Console.WriteLine("float {0}", Input);
                return "frac_num";
            }

            else if (CHAR.validate(Input))
            {
                Console.WriteLine("char {0}", Input);
                return "sym Constant";
            }
            else if (STRING.validate(Input))
            {
                Console.WriteLine("string{0}", Input);
                return "sting Constant";
            }
            else
            {

                return "None";

            }
        }
    }
}
