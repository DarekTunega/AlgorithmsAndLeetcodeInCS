public class Solution {
    public void ReverseString(char[] s) {
        char[] reversed = new char[s.Length];
        int i = 0;
        for (int j = s.Length - 1; j >= 0; j--) {
            reversed[i] = s[j];
            i++;
        }
        for (int k = 0; k < s.Length; k++) {
            s[k] = reversed[k];
        }
    }
}

