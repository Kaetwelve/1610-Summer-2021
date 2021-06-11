using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTwo : MonoBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // integer (whole number)
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
        }
    }
}
