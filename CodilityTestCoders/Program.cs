/* 
Given N integer, 
print 'Codility' if N is divisible by 2
print 'Test' if N is divisible by 3
print 'Coders' if N is divisible by 5
print 'CodilityTest' if N is divisible by 2 and 3
print 'CodilityCoders' if N is divisible by 2 and 5
print 'TestCoders' if N is divisible by 3 and 5
print 'CodilityTestCoders' if N is divisible by 2, 3, and 5
*/

public class CodilityTestCoders
{
    public void Solution(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("CodilityTestCoders");
            }
            else if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine("CodilityTest");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("TestCoders");
            }
            else if (i % 2 == 0 && i % 5 == 0)
            {
                Console.WriteLine("CodilityCoders");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("Codility");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Test");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Coders");
            }
            else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}