using System;
using System.Text.RegularExpressions;
namespace Isogram
{
    public class IsIsogram
    {
        public static bool IsIso(string input)
        {
            if (input == "")
            {
                return true;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!(input[i].Equals(' ') || input[i].Equals('-')))
                    {
                        for (int j = i+1; j < input.Length; j++)
                        {
                            if (input[i] == input[j])
                                return false;
                        }
                    }

                }
            }
            return true;
        }
    }
}