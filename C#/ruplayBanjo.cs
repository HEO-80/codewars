
// Create a function which answers the question "Are you playing banjo?".
// If your name starts with the letter "R" or lower case "r", you are playing banjo!

// The function takes a name as its only argument, and returns one of the following strings:
using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    //If your name starts with the letter "R" or lower case "r", you are playing banjo!
  //  if (name.substring(0,1).equals("r") || name.subtring(0,1).equals("R"))
  //  {
  //    return name + " plays banjo";
  //   }else
  //   {
  //     return name + " does not play banjo";
  //   }
  
  //Correct answer
      //return name.StartsWith("R") || name.StartsWith("r") ? name + " plays banjo" : name + " does not play banjo";
    return name[0] == 'r' || name[0] == 'R' ? name + " plays banjo" : name + " does not play banjo";
  }
}