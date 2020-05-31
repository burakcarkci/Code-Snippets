/*The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, calculate the Hamming distance.

Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different. */

public class Solution {
    public int HammingDistance(int x, int y) {
        int result = 0;
        while( x > 0 || y > 0 ){
			//The ^ operator computes the bitwise logical exclusive OR, also known as the bitwise logical XOR
            result += ( x % 2 ) ^ ( y % 2 );
			//The >> operator shifts its left-hand operand right by the number of bits defined by its right-hand operand.
            x >>= 1;
            y >>= 1;
        }
        return result;
    }
}
