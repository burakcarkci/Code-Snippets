
public class RotateArray
{
    public void Rotate(int[] array, int k)
    {
        k = k % array.Length;

        int len = array.Length;

        Reverse(array, 0, len - 1);
        Reverse(array, 0, k - 1);
        Reverse(array, k, len - 1);
    }

    public void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }

    public void Print(int[] array, int k)
    {
        int len = array.Length;

        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + ",");
        }
    }
}