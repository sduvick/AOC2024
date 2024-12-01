using System.Collections.Generic;
using System.Linq;
using System;

public static class Day1
{
    public static void Main(string[] args)
    {
        string input = @"<input trimmed>";

        string[] lines = input.Split(Environment.NewLine);
        List<int> inputA = new List<int>();
        List<int> inputB = new List<int>();
        foreach(var line in lines)
        {
            var parts = line.Split("   ");
            inputA.Add(int.Parse(parts[0].Trim()));
            inputB.Add(int.Parse(parts[1].Trim()));
            
        }
        
        //var result = CalcDistanceTotals(inputA, inputB);
        var result = CalcSimilarityScore(inputA, inputB);

        Console.WriteLine(result);
    }
    public static int CalcDistanceTotals(List<int> listA, List<int> listB)
    {
        var sortedA = listA.OrderBy(a=>a).ToList();
        var sortedB = listB.OrderBy(b=>b).ToList();

        int totalDistance = 0;
        for(int i = 0; i< sortedA.Count; i++)
        {
            int aEntry = sortedA[i];
            int bEntry = sortedB[i];
            int diff = Math.Abs(aEntry - bEntry);
            totalDistance += diff;
        }
        
        return totalDistance;
    }
    
    public static int CalcSimilarityScore(List<int> listA, List<int> listB)
    {
        int score = 0;
        for(int i = 0; i < listA.Count; i++)
        {
            int occurances = listB.Count(a=>a == listA[i]);
            occurances *= listA[i];
            score += occurances;
        }
        
        return score;
    }
}