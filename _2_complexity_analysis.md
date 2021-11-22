# Computational Complexity Analysis

As programmers, we often find ourselves asking the same two questions over an onver again:

- How much time does this algorithm need to finish?
- How much space does this algorithm need for its computation?

## Big-O Notation

There are other notations (Big-Omega, Big-Theta) too, but we are only interested in the Big-O notation.

**Big-O Notation** gives an upper bound of the complexity in the worst case, helping to quantify performance as the input size becomes arbitrarily large.

Let's n - The size of the input complexities ordered in from smallest to largest.

| Name              | Big-O Notation |
| ----------------- | -------------- |
| Constant Time     | O(1)           |
| Logarithmic Time  | O(log(n))      |
| Linear Time       | O(n)           |
| Linearithmic Time | O(nlog(n))     |
| Quadric Time      | O(n^2)         |
| Cubic Time        | O(n^3)         |
| Exponential Time  | O(b^n), b > 1  |
| Factorial Time    | O(n!)          |

## Big-O Properties

- O(n + c) = O(n)
- O(cn) = O(n), c > 0

Let f be a function that describes the running time of a particular algorithm for an input of size n:

Lets say, f(n) = 7log(n^3) + 15n^2 + 2n^3 + 8

=> O(f(n)) = O(n^3)

### Some more examples

- The following run in constant time: O(1). This is because both of the below code is independent of the number of input n

```test
a := 1
b := 2
c := a + 5*b
```

```test
i := 0
while  i < 11 Do
    i = i + 1
```

- The following run in linear time: O(n)

```test
i := 0
while i < n do
    i = i + 1

// f(n) = n , i.e. how many times the loop is going to run? untill the value of i becomes n, so the loop will run n times
// O(f(n)) = O(n)
```

```test
i := 0
while  i < n Do
    i = i + 3

// f(n) = n/3 , i.e. how many times the loop is going to run? untill the value of i becomes n, so the loop will run n times
// n = nth number of the arithmetic progression with first element being i = 0, difference d = 3, nth number = first number + (number of times - 1)*d => n = 0 + (t-1)*3 => t = (n/3) + 1
// hence, f(n) = (n/3) + 1 , or n/3 for simplicity
// That's why, O(f(n)) = O(n)
```
