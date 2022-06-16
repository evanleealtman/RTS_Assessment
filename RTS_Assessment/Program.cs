public class Program
{
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
        if (rotationAmount <= original.Length)
        {
            return original.Substring(original.Length - rotationAmount) + original.Substring(0, original.Length - rotationAmount);
        }
        else
        {
            return original;
        }
    }
}   