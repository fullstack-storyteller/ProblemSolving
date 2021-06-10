# Problem: 7

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

**Assume the environment does not allow you to store 64-bit integers (signed or unsigned).**

## Constraints

-2^31 <= x <= (2^31) - 1

```C#

public class Solution {
    public int Reverse(int x) {


        int reversed_num=0;
        while(x!=0){

            int last_element=x%10;
            x/=10;
            if(reversed_num>int.MaxValue/10 || (reversed_num==int.MaxValue/10 && last_element>7)) return 0;
            if(reversed_num<int.MinValue/10 || (reversed_num==int.MinValue/10 && last_element<-8)) return 0;
            reversed_num=reversed_num*10+last_element;
        }

        return reversed_num;
    }
}
```
