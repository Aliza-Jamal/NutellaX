using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lexical_Analyzer
{
    class Lexical_Analyzer
    {

        public Lexical_Analyzer()
        {

        BUILD_DFA B_dfa = new BUILD_DFA();
        }

        public string double_operators(string D_OPR)
        {
            string opr;
            switch (D_OPR)
            {
                case "&&"||"||":
                    opr = "CONDITIONAL OPERATOR";
                    return opr;
                    break;
                case "&"||"|":
                    opr = "LOGICAL OPERATOR";
                    return opr;
                    break;
                case "="  || "+=" || "-=" || "*=" || "/=" || "%=" || "&="||"|=":
                    opr = "ASSINGMENT OPERATOR";
                    return opr;
                    break;
                case "==" || "!=":
                    opr = "EQUALITY OPERATOR";
                    return opr;
                    break;
                case "<" || ">"||"<="||">=":
                    opr = "EQUALITY OPERATOR";
                    return opr;
                    break;
                case "+" || "-" :
                    opr = "ADDITIVE OPERATOR";
                    return opr;
                    break;
                case "*" || "/" ||"%":
                    opr = "MULTIPLICATIVE OPERATOR";
                    return opr;
                    break;
                case "++" :
                    opr = "INCREMENT OPERATOR";
                    return opr;
                    break;
                case "--":
                    opr = "DECREMENT OPERATOR";
                    return opr;
                    break;
                case "~":
                    opr = "MEMBER ACESS";
                    return opr;
                    break;
                default:
            } 
        }
    }
}

