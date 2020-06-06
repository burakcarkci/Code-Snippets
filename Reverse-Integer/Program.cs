/* 
reverse given integer
e.g 562
e.g -365

if given integer greater or smaller than int32 return 0
*/
public class ReverseInteger
{
    public int Reverse(long input)
    {
        Stack stack = new Stack();

        StringBuilder stringBuilder = new StringBuilder();

        string newInput = input.ToString();

        int len = newInput.Length;

        if (newInput[0] == '-')
        {
            stringBuilder.Append(newInput[0]);

            for (int i = 1; i < len; i++)
            {
                stack.Push(newInput[i]);
            }
            for (int j = 1; j < len; j++)
            {
                stringBuilder.Append(stack.Pop());
            }
        }
        else
        {
            for (int i = 0; i < len; i++)
            {
                stack.Push(newInput[i]);
            }
            for (int j = 0; j < len; j++)
            {
                stringBuilder.Append(stack.Pop());
            }
        }

        string result = stringBuilder.ToString();

        long intResult = long.Parse(result);

        if (intResult < int.MinValue || intResult > int.MaxValue)
        {
            return 0;
        }
        else
        {
            return (int)intResult;
        }
    }
}