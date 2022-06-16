public class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine(p.StringRotation("MyString", 2));
    }

    public Dictionary<string,int> AboveBelow(List<int> integers, int comparisonValue)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        int aboveCount = 0;
        int belowCount = 0;
        
        foreach (int i in integers)
        {
            if (i > comparisonValue) { 
                aboveCount++;
            }
            else if (i < comparisonValue)
            {
                belowCount++;
            }
        }

        result.Add("Above", aboveCount);
        result.Add("Below", belowCount);

        return result;
    }

    public string StringRotation(string original, int rotationAmount)
    {
        if (rotationAmount >= 0)
        {
            int adjustedRotationAmount = rotationAmount % original.Length; //Account for rotationAmount being greater than string length

            return original.Substring(original.Length - adjustedRotationAmount) + original.Substring(0, original.Length - adjustedRotationAmount);
        } else
        {
            return original;
        }
    }
}   