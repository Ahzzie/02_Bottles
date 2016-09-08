using System;

namespace _02_Bottles
{
    internal class Song
    {
        internal static string CountBottles(int v)
        {
            if (v == 0)
               return " No more bottles of beer on the wall.";
            else if (v == 1)
                return "1 bottle of beer on the wall."
                    + " 1 bottle of beer."
                    + " Take one down and pass it around."
                    + " No more bottles of beer on the wall.";
            else if (v == 2)
                return "2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
            else if (v == 3)
                return "3 bottles of beer on the wall."
                + " 3 bottles of beer."
                + " Take one down and pass it around."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
            else
            {
                return null;
            }
        }
    }
}