using System;

public static class Program
{
    public static void Main(string[] args)
    {
        double[] s = new double[args.Length];
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = double.Parse(args[i]);
        }

        double sum = 0.0;
        for (int i = 0; i < s.Length; i++)
        {
            sum += s[i];
        }

        double mean = sum / s.Length;
        double sumOfSquares = 0.0;
        for (int i = 0; i < s.Length; i++)
        {
            sumOfSquares += (s[i] - mean) * (s[i] - mean);
        }

        double variance = sumOfSquares / (s.Length - 1);

        Console.WriteLine($"분산: {variance}");

    }
}