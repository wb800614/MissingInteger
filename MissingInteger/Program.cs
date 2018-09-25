using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution {
    public int solution(int[] A) {
        int smallest = 1;
        if (A == null || A.Length <= 0)
        {
            return smallest;
        }
        Array.Sort(A);
        for(int i = 0; i < A.Length; i++)
        {
            if (A[i] == smallest)
                smallest++;
        }
        return smallest;
    }
}