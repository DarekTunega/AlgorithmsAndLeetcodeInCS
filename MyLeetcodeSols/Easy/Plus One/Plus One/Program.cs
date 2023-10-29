public class Solution {
    public int[] PlusOne(int[] digits) {
        int len =  digits.Length;
        int num;
        int add = 1;

        for(int i = len-1;i>=0;i--)
        {
            num = digits[i]+add;
            if(num == 10)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] = num;
                return digits;
            }
        }

        int[] newDigits = new int[digits.Length + 1];

        newDigits[0] = 1;
        Array.Copy(digits, 0, newDigits, 1, digits.Length);

        return newDigits;
    }
}