using System.Collections.Generic;
using System;

public class Anagrams
{
    public static List<string> GetAnagrams(string word)
    {
        Dictionary<char,int> countsByChars = parseStringToCharDictionary(word);
        var ah = new AnagramHelper();
        ah.addNextCharacterOrAddFinalAnagram("", countsByChars);
        
        return ah.Anagrams;
    }
    
    private static Dictionary<char,int> parseStringToCharDictionary(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        
        return charCount;
    }
}
