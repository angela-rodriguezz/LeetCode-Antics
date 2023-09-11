public class Solution {
    public int Reverse(int x) {
        int new_num = 0;
        int digit = 0;
        int checker = 0;
        if (x < 0) {
            x *= 1;
        }
        while (x != 0) { 
            digit = x % 10;
            new_num = (new_num * 10) + digit;
            if ((new_num - digit) / 10 != checker) {
                return 0;
            }
            x = x / 10;
            checker = new_num;
        }
        return new_num;
    }
}
