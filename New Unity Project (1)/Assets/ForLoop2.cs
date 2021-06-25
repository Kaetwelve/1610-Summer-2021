using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop2 : MonoBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
