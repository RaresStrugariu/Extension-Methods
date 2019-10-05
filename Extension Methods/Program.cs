using System;
using System.Text;

namespace Extension_Methods
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Our String is :");
         string myString = "ana are mere";
         Console.Write("The string starts with cappital letter? : ");
         Console.WriteLine(myString.StartWithCapitalLetter());
         Console.Write("Append letter to the string : ");
         Console.WriteLine(myString.AppendLetter());
         Console.Write("Capitalize the first letter : ");
         Console.WriteLine(myString.CapitalizeFirstLetter());
         Console.Write("Pluralize And Capitalize : ");
         Console.WriteLine(myString.PluralizeAndCapitalize());
         Console.Write("Count the characters : ");
         Console.WriteLine(myString.Counter());
         Console.WriteLine();        
         Console.Write("Our number is : ");
         decimal number = 666M;
         Console.WriteLine(number.VAT());
      }



   }
   static class ExtensionMethods
   {

      //Problema1
      public static bool StartWithCapitalLetter(this string myString)
      {
         if (myString != string.Empty)
         {
            if (myString[0] == char.ToUpper(myString[0]))
            {
               return true;
            }
            else
            {
               return false;
            }
         }
         return true;
      }

      //Problema2
      public static string AppendLetter(this String myString)
      {
         if (myString.Length > 0)
         {
            StringBuilder sb = new StringBuilder();
            sb.Append(myString);
            sb.Append('s');
            return sb.ToString();
         }
         else
         {
            return myString;
         }

      }
      //Problema3
      public static string CapitalizeFirstLetter(this String myString)
      {        
         
            return char.ToUpper(myString[0]) + myString.Substring(1);
                 
      }
      //problema4
      public static string PluralizeAndCapitalize(this string myString)
      {
         return myString.AppendLetter().CapitalizeFirstLetter();
      }


      //Problema5
      public static string Counter(this String myString)
      {
         //myString.Split("");
         return myString.Length.ToString();

      }
      //Problema6
      public static decimal VAT(this decimal input)
      {
         return 0.24M * input;
      }
   }
}
