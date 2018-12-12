using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lexical_Analyzer
{
    class LexicalAnalyzer
    {
        string DfaStatus;
        int Index = 0;
        static int LineNo = 1;
        string TempString = "";
        StreamReader Sr = new StreamReader(@"Input Code.txt");
        ConstructDfa Construct = new ConstructDfa();
        Classification Class = new Classification();
        TOKEN Tokens = new TOKEN();

        public void Analysis()
        {
            string CodeFile = Sr.ReadToEnd();
            while (Index != CodeFile.Length)
            {
                TempString = null;
                if (CodeFile[Index] == 10 || CodeFile[Index] == 13)
                {
                    LineNo++;
                    Index++;
                    Index++;
                }

               
                if (CodeFile[Index] == '`')
                {
                    TempString += CodeFile[Index];
                    Index++;
                    if (CodeFile[Index] == 92)
                    {
                        TempString += CodeFile[Index];
                        Index++;
                        TempString += CodeFile[Index];
                        Index++;
                        TempString += CodeFile[Index];
                    }
                    else
                    {
                        TempString += CodeFile[Index];
                        Index++;
                        TempString += CodeFile[Index];
                       
                    }
                    
                }
                else
                    if (CodeFile[Index] == '#')
                    {

                        TempString += CodeFile[Index];
                        Index++;
                        while (((CodeFile[Index] != '#')))
                        {
                            if ((CodeFile[Index] == '\\') && CodeFile[Index + 1] == '#')
                            {
                                TempString += CodeFile[Index].ToString() + CodeFile[Index + 1].ToString();
                                Index = Index + 2;
                            }
                            else
                            {
                                TempString += CodeFile[Index];
                                Index++;
                            }
                        }
                        TempString += CodeFile[Index];
                        Index++;

                    }
                else
                    if (CodeFile[Index] == '&')
                    {
                        Index++;
                        if (CodeFile[Index] == '&' || CodeFile[Index] == '=')
                        {
                            TempString += CodeFile[Index - 1];
                            TempString += CodeFile[Index];
                        }
                        else
                        {
                            Index--;
                        }
                    }
                    else
                        if (CodeFile[Index] == '|')
                        {
                            Index++;
                            if (CodeFile[Index] == '|' || CodeFile[Index] == '=')
                            {
                                TempString += CodeFile[Index - 1];
                                TempString += CodeFile[Index];
                            }
                            else
                            {
                                Index--;
                            }
                        }
                        else
                            if (CodeFile[Index] == '=')
                            {
                                Index++;
                                if (CodeFile[Index] == '=')
                                {
                                    TempString += CodeFile[Index - 1];
                                    TempString += CodeFile[Index];
                                }
                                else
                                {
                                    Index--;
                                }
                            }
                            else
                                if (CodeFile[Index] == '+')
                                {
                                    Index++;
                                    if (CodeFile[Index] == '+' || CodeFile[Index] == '=')
                                    {
                                        TempString += CodeFile[Index - 1];
                                        TempString += CodeFile[Index];
                                    }
                                    else
                                    {
                                        Index--;
                                    }
                                }
                                else
                                    if (CodeFile[Index] == '-')
                                    {
                                        Index++;
                                        if (CodeFile[Index] == '-' || CodeFile[Index] == '=')
                                        {
                                            TempString += CodeFile[Index - 1];
                                            TempString += CodeFile[Index];
                                        }
                                        else
                                        {
                                            Index++;
                                        }
                                    }
                                    else
                                        if (CodeFile[Index] == '<')
                                        {
                                            Index++;
                                            if (CodeFile[Index] == '=')
                                            {
                                                TempString += CodeFile[Index - 1];
                                                TempString += CodeFile[Index];
                                            }
                                            else
                                            {
                                                 Index--;
                                            }
                                        }
                                        else
                                            if (CodeFile[Index] == '>')
                                            {
                                                Index++;
                                                if (CodeFile[Index] == '=')
                                                {
                                                    TempString += CodeFile[Index];
                                                }
                                                else
                                                {
                                                    Index--;
                                                }
                                            }
                                            else
                                                if (CodeFile[Index] == '!')
                                                {
                                                    Index++;
                                                    if (CodeFile[Index] == '=')
                                                    {
                                                        TempString += CodeFile[Index - 1];
                                                        TempString += CodeFile[Index];
                                                    }
                                                    else
                                                    {
                                                        Index--;
                                                    }
                                                }
                                                else
                                                    if (CodeFile[Index] == '*')
                                                    {
                                                        Index++;
                                                        if (CodeFile[Index] == '=')
                                                        {
                                                            TempString += CodeFile[Index - 1];
                                                            TempString += CodeFile[Index];
                                                        }
                                                        else
                                                        {
                                                            Index--;
                                                        }
                                                    }
                                                    else
                                                        if (CodeFile[Index] == '/')
                                                        {
                                                            Index++;
                                                            if (CodeFile[Index] == '=')
                                                            {
                                                                TempString += CodeFile[Index - 1];
                                                                TempString += CodeFile[Index];
                                                            }
                                                            else
                                                            {
                                                                Index--;
                                                            }
                                                        }
                                                        else
                                                            if (CodeFile[Index] == '%')
                                                            {
                                                                Index++;
                                                                if (CodeFile[Index] == '=')
                                                                {
                                                                    TempString += CodeFile[Index - 1];
                                                                    TempString += CodeFile[Index];
                                                                }
                                                                else
                                                                {
                                                                    Index--;
                                                                }
                                                            }
                                                            else
                                                                if(CodeFile[Index] == '?')
                                                                {

                                                                        Index++;
                                                                        if (CodeFile[Index] == '?')
                                                                        {
                                                                            while (CodeFile[Index] != 13)
                                                                            {

                                                                                Index++;

                                                                            }
                                                                            Index++;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (CodeFile[Index] != '?')
                                                                            {
                                                                                Index++;
                                                                                while (CodeFile[Index] != '?')
                                                                                {

                                                                                    Index++;
                                                                                }
                                                                            }
                                                                        }
                                                                    
                                                                  
                                                                       
                                                                }
                                                                    
                                                            else
                                                            {

                                                                while (CodeFile[Index] != '$' && CodeFile[Index] != '~' && CodeFile[Index] != ' ' && CodeFile[Index] != 32 && CodeFile[Index] != ';' && CodeFile[Index] != '(' && CodeFile[Index] != ')' && CodeFile[Index] != '{' && CodeFile[Index] != '}' && CodeFile[Index] != ':' && CodeFile[Index] != '[' && CodeFile[Index] != ']' && CodeFile[Index] != ',' && CodeFile[Index] != 09 && CodeFile[Index] != '=' && CodeFile[Index] != '&' && CodeFile[Index] != '|' && CodeFile[Index] != '^' && CodeFile[Index] != '*' && CodeFile[Index] != '/' && CodeFile[Index] != '%' && CodeFile[Index] != '+' && CodeFile[Index] != '-' && CodeFile[Index] != '<' && CodeFile[Index] != '>')
                                                                    {


                                                                        TempString += CodeFile[Index];
                                                                        Index++;
                                                                    }
                                                                    if (TempString != null)
                                                                    {
                                                                        Index--;
                                                                    }
                                                                
                                                            }
               
                if (TempString != null)
                {
                    DfaStatus = Construct.BuildDFa(TempString);

                    if (DfaStatus != "None")
                    {
                        if (DfaStatus == "sym Constant")
                        {
                            TempString.Remove(0);
                            TempString.Remove(TempString.Length - 1);
                            Tokens.GenerateTokens(DfaStatus, TempString.Trim('`'), LineNo);
                        }
                        else
                            if (DfaStatus == "sting Constant")
                            {
                                TempString.Remove(0);
                                TempString.Remove(TempString.Length - 1);
                                Tokens.GenerateTokens(DfaStatus, TempString, LineNo);
                            }
                            else
                            {
                                Tokens.GenerateTokens(DfaStatus, TempString, LineNo);
                            }
                    }
                    else
                    if (DfaStatus == "None")
                    {
                        string KwywrodStatus = Class.Keyword(TempString);
                        string DoubleOperator = Class.Double_operators(TempString);
                        if (KwywrodStatus != "Null")
                        {
                            Tokens.GenerateTokens(KwywrodStatus, TempString, LineNo);
                        }
                        else
                        
                            
                            if (DoubleOperator != "Null")
                            {
                                Tokens.GenerateTokens(DoubleOperator, TempString, LineNo);
                            }
                        
                        else
                        {
                            Tokens.GenerateTokens( "Invalid Token", TempString, LineNo);
                           
                        }
                     
                    }
                    




                }
                else
                {
                    string SeperatorStatus = Class.Seperator(CodeFile[Index]);
                    if (SeperatorStatus != "Null")
                    {
                        Tokens.GenerateTokens(SeperatorStatus, CodeFile[Index].ToString(), LineNo);
                    }
                }

                    Index++;
                
                
            }
            Console.ReadLine();


        }




    }
}
