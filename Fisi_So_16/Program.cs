using System;

class Program
{
    static void Main(string[] args)
    {

        string[] file = File.ReadAllLines("..\\..\\..\\skilift.txt");

        int result = 0;
        int cnt = 0;

        foreach (string line in file)
        {
            if (line.Contains("30201"))
            {
                int lastOccurrenceOfPipe = line.LastIndexOf('|');

                int subStr = Int32.Parse(line[(lastOccurrenceOfPipe + 1)..]);

                result += subStr;

                cnt++;

            }

        }

        Console.WriteLine(result + (cnt * 30201));
    }
}

