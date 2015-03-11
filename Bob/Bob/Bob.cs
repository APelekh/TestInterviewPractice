using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are, what, like 15?".Contains("?"));
        Bob bob = new Bob();
        bob.Hey("ABCD!");

        Console.ReadKey();
    }

}

class Bob
{
    public string Hey(string bobsWords)
    {
        List<string> words = new List<string>(bobsWords.Split(' ').ToList());
        //for (int i = 0; i < words.Count; i++)
        //{
        //    if (words[i].Length > 1)
        //    {
        //        for (int j = 1; j < words[i].Length; j++)
        //        {
        //            if (words[i][j] >= 'A' && words[i][j] <= 'Z')
        //            {
        //                return "Whoa, chill out!";
        //            }
        //        }
        //    }
        //}

        if (bobsWords.Trim() == string.Empty)
        {
            return "Fine. Be that way!";
        }
        else if (words.Where(x => x.Length > 1).Any(x => x.Skip(1).Any(y => y >= 'A' && y <= 'Z')) && !words.Any(x => x.ToLower() == "ok"))
        {
            return "Whoa, chill out!";
        }
        else if (bobsWords.Trim().Last() == '?' && !bobsWords.Trim().Contains("."))
        {
            return "Sure.";
        }


        return "Whatever."; // Replace this
    }

}
