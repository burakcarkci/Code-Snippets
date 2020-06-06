/*
given {()} true
given {) false
given {([])} true
given ] false	
*/

public class BalancedParanthesis
{
    public bool IsValid(string input)
    {
        int len = input.Length;

        Stack<char> myStack = new Stack<char>();

        for (int i = 0; i < len; i++)
        {
            if (input[i] == '(' || input[i] == '{' || input[i] == '[')
            {
                myStack.Push(input[i]);
            }
            else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
            {
                if (myStack.Count == 0)
                {
                    return false;
                }

                var top = myStack.Peek();

                if (top == '(' && input[i] == ')' || top == '{' && input[i] == '}' || top == '[' && input[i] == ']')
                {
                    myStack.Pop();
                }
                else
                {
                    myStack.Push(input[i]);
                }
            }
        }
        if (myStack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}