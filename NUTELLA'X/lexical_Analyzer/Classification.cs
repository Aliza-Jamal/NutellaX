using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lexical_Analyzer
{
    class Classification
    {
        public string[] DataTypes = { "int_num", "float_num", "sym", "sting","bool","deci_num","duplex"};   // All DT
        public string[] AccessModifier = { "universal", "special", "shield" };   // All AM
        public string[] MixKeyWords = { "echelon", "MAIN", "END","for","while",
        "if","end_if","CASUAL_I","end_CI","CASUAL_D","end_CD",
        "end_while","end_for","swish","case","shatter","otherwise","leads",
        "neo","interface","void","hide","enact","stable","final","delete",
        "delete_Multiple","Multiplex","delete_All","null","object","this","false",
         "true","overturn","try","grab","throw","exception","continue","in",
         "return","virtual","packed","else","Read","Write","foreach","range","Stack","else",
         "Queue","Push","Pop","Enqueue","Dequeue","Clear","Count","Peek","Struct","List","Add","Remove"
                                      };  // All keywords come here with seperate class name
       
        public string[] ArthmeticOperators = { "*", "/", "%", "=", "+", "-"};
        public string[] MEMBER_ACESS = { "~" };
        public string[] LogicalOperator = { "&", "|" };

        public string[] AO = { "+=", "-=", "*=", "/=", "%=", "&=", "|=" };  
        public string[] EqualityOperator = { "==" , "!=" };
        public string[] ConditionalOperator = { "&&", "||" };
        public string[] RelationalOperator = {  ">=", "<=","<", ">",};
        public string[] INCDECOperator = { "++","--" };
       // public string[] DECOperator = { "--" };
        
        public string Keyword(string Word)
        {
            if (DataTypes.Contains(Word))
            {
                return "Data Type";

            }
            else if (AccessModifier.Contains(Word))
            {
                return "Acess Modifier";
            }
            else if (MixKeyWords.Contains(Word))
            {
                return Word;
            }
            else
            {
                return "Null";
            }

        }
        public string Seperator(char Sym)
        {
            string Symbol = Sym.ToString();

           
                if (ArthmeticOperators.Contains(Symbol))
                {
                    Console.WriteLine("Arithmetic Operators{0}", Symbol);
                    return "Arithmetic Operators";
                }
                else
                    if (LogicalOperator.Contains(Symbol))
                    {
                        Console.WriteLine("Logical Operator {0}", Symbol);
                        return "Logical Operator";
                    }
                    else if (MEMBER_ACESS.Contains(Symbol))
                    {
                        Console.WriteLine("Member acess {0}", Symbol);
                        return "Memeber acess";
                    }
             
            else if (Symbol == ":" || Symbol == ")" || Symbol == "(" || Symbol == "}" || Symbol == "{" || Symbol == "[" || Symbol == "]" || Symbol == ";" || Symbol == ",")
            {
                Console.WriteLine("Other optr {0}", Symbol);
                return Symbol;
            }

            else return "Null";



        }

        public string Double_operators(string Symbol)
        {
            if (INCOperator.Contains(Symbol))
            {
                Console.WriteLine("Increment Operator {0}", Symbol);
                return "Increment Operator";
            }
                        else if (DECOperator.Contains(Symbol))
                        {
                            Console.WriteLine("Decrement Operator {0}", Symbol);
                            return "Decrement Operator";
                        }

            
            
                else
            if (AO.Contains(Symbol))
            {
                Console.WriteLine("Assignment Operator {0}", Symbol);
                return "Assignment Operator";
            }
             
            else
                    if (EqualityOperator.Contains(Symbol))
            {
                Console.WriteLine("Equality Operator {0}", Symbol);
                return "Equality Operator";
            }
                    else
                        if (ConditionalOperator.Contains(Symbol))
                        {
                            Console.WriteLine("Conditional Operator {0}", Symbol);
                            return "Conditional Operator";
                        } 
            else if (RelationalOperator.Contains(Symbol))
            {
                Console.WriteLine("Relational Operator {0}", Symbol);
                return "Relational Operator";
            }
                        else return "Null";          
                      
        }


    }
}
