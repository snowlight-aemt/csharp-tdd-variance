using System;

public static class Program
{
    public static void Main(string[] args) => Console.WriteLine(args.Length switch
    {
        0 => "데이터가 입력되지 않았습니다.",
        1 => "2개 이상의 데이터를 입력하세요.",
        _ => GetVerianceOutput(args),
    });

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
        return source
                    .Select(x => x - mean)
                    .Select(x => x * x)
                    .Sum();
    }

    private static double CalculateMean(double[] source) => source.Average();

    private static double[] ParseArguments(string[] args) => args.Select(double.Parse).ToArray();
}