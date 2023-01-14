using System;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(args.Length switch
        {
            0 => "데이터가 입력되지 않았습니다.",
            1 => "2개 이상의 데이터를 입력하세요.",
            _ => GetVerianceOutput(args),
        });
    }

    private static string GetVerianceOutput(string[] args)
    {
        double[] source = ParseArguments(args);
        double mean = CalculateMean(source);
        double sumOfSquares = CalcuateSumOfSquares(source, mean);

        double variance = sumOfSquares / (source.Length - 1);
        string output = $"분산: {variance}";
        return output;
    }

    private static double CalcuateSumOfSquares(double[] source, double mean)
    {
        double sumOfSquares = 0.0;
        for (int i = 0; i < source.Length; i++)
        {
            sumOfSquares += (source[i] - mean) * (source[i] - mean);
        }

        return sumOfSquares;
    }

    private static double CalculateMean(double[] source)
    {
        double sum = 0.0;
        for (int i = 0; i < source.Length; i++)
        {
            sum += source[i];
        }

        double mean = sum / source.Length;
        return mean;
    }

    private static double[] ParseArguments(string[] args)
    {
        double[] s = new double[args.Length];
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = double.Parse(args[i]);
        }

        return s;
    }
}