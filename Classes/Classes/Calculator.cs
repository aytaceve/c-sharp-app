namespace Classes;

public class Calculator
{
    public int Add(params int[] numbers)
    {
        var sum = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }
}