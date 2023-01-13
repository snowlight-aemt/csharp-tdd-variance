using System;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0) 
        {
            Console.WriteLine("데이터가 입력되지 않았습니다.");
            return;
        }

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