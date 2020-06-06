/*
For example, given array A such that:

  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the function should return 7, as explained in the example above.

Write an efficient algorithm for the following assumptions:

-N is an odd integer within the range [1..1,000,000]
-Each element of array A is an integer within the range [1..1,000,000,000]
-All but one of the values in A occur an even number of times.
*/

public class OddOccurencesInArray
{
    public int Solution(int[] array)
    {
        Array.Sort(array);

        int i, j, count = 0, len = array.Length;

        for (i = 0; i < len; i++)
        {
            for (j = i + 1; j < len; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count % 2 == 0)
            {
                return array[i];
            }
            else
            {
                count = 0;
                i = j - 1;
            }
        }
        return 0;
    }
}