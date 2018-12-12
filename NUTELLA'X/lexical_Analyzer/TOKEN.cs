using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lexical_Analyzer
{
    class TOKEN
    {
        public string ClassPart;
        public string ValuePart;
        public int LineNum;


        public void GenerateTokens(string CP, string VP, int LN)
        {
            TextWriter tsw = new StreamWriter(@"Tokens.txt", true);
            this.ClassPart = CP;
            this.ValuePart = VP;
            this.LineNum = LN;
            tsw.WriteLine("({0},{1},{2})", ClassPart, ValuePart, LineNum);
            tsw.Close();

        }
    }
}
