// See https://aka.ms/new-console-template for more information
Solution s = new Solution();
var people = new int[] { 7, 9, 3, 2, 8, 6, 4, 5 };
int limit = 10;
var answer = s.NumRescueBoats(people, limit);
Console.WriteLine(answer);


public class Solution
{
  public int NumRescueBoats(int[] people, int limit)
  {
    /*
    Step - 1 Sort the array of people, will have two pointers, ptr1 from 0th index, ptr2 from last index
    Step - 2 We try to fit one heavy person and one light person, if both are able to fit we will move ptr1 to right and ptr2 to left and increment the boat count, as question said we can max take 2 people in both if their sum of weight is equal or less than limit
    Step - 3 If we can only fit the heavy person, then will move our ptr2 to left only and increment count. 
    */

    Array.Sort(people);
    int i = 0;
    int count = 0;
    int j = people.Length - 1;
    while (i <= j)
    {
      int sum = people[i] + people[j];
      if (sum <= limit)
      {
        i++;
      }
      j--;
      count++;
    }

    return count;
  }
}