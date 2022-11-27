using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static void Main(string[] args)
    {
        IEnumerable<int> listOfIntegers = GetIntegersFromList(new List<object> { 1, 2, 3, 'a', 'b' });
        foreach (int i in listOfIntegers)
        {
            Console.WriteLine(i);
        }
    }
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> listOfIntegers = new List<int>();
        foreach (object item in listOfItems)
        {
            if (item is int)
            {
                listOfIntegers.Add((int)item);
            }
        }
        return listOfIntegers;
    }
}