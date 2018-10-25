using System;
using Stack_and_Queue.Classes;
using static System.Console;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // testing normal case
            WriteLine(@"Testing: [[]]");
            WriteLine("Balanced: " + MultiBracketValidation("[[]]"));

            // testing letters
            WriteLine(@"Testing: aaa({})");
            WriteLine("Balanced: " + MultiBracketValidation("aaa({})"));

            // testing edge case
            WriteLine(@"Testing: [(");
            WriteLine("Balanced: " + MultiBracketValidation("[("));
        }
        public static bool MultiBracketValidation(string input)
        {
            // create a new stack to contain opening braces
            Stack brackets = new Stack();
            
            for(int i = 0; i < input.Length; i++)
            {
                // push in open braces
                char c = input[i];
                if(c == '[' || c == '{' || c =='(')
                {
                    brackets.Push(new Node(c));
                }
                else
                {
                    // matches to each case
                    switch (c)
                    {
                        case ']':
                            // make sure its not an empty stack
                            if(brackets.Size == 0)
                            {
                                // return false because of empty stack
                                return false;
                            }

                            // compare the characters otherwise
                            if ((char)brackets.Pop().Value != '[')
                            {
                                return false;
                            }
                            break;
                        case '}':
                            // same as above
                            if (brackets.Size == 0)
                            {
                                return false;
                            }
                            if ((char)brackets.Pop().Value != '{')
                            {
                                return false;
                            }
                            break;
                        case ')':
                            // same as above
                            if (brackets.Size == 0)
                            {
                                return false;
                            }
                            if ((char)brackets.Pop().Value != '(')
                            {
                                return false;
                            }
                            break;
                        default:
                            // do nothing, it's a character other than braces!
                            break;
                    }
                }
            }
            // make sure you didn't open braces by itself and not close
            return brackets.Size == 0;
        }
    }
}
