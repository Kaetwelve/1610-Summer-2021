using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop2 : MonoBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
    }
}
