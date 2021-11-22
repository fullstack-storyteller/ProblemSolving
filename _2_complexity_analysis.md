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
| Quadratic Time    | O(n^2)         |
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

- **The following run in constant time: O(1).** This is because both of the below code is independent of the number of input n

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

- **The following run in linear time: O(n)**

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
// n = nth number of the arithmetic progression with first element being i = 0, difference d = 3, nth number = first number + (number of times, t - 1)*d
// => n = 0 + (t-1)*3 => t = (n/3) + 1
// hence, f(n) = (n/3) + 1 , or n/3 for simplicity
// That's why, O(f(n)) = O(n)
```

- **The following run in quadratic time: O(n^2)**

```test
for(i := 0 ; i < n ; i := i + 1)
    for(j := 0 ; j < n; j := j + 1)
        //some statements s

// f(n) = total number of time s will execute or the time complexity
//      = n * n
//      = n^2
// Hence, f(n) = n^2
// that's why O(f(n))=O(n^2)

```

```test
for(i := 0 ; i < n ; i := i + 1)
    for(j := i ; j < n; j := j + 1)
        //some statements s

// Here the statement s will execute as follows
// f(n) = n + (n-1) + (n-2) + (n-3) + ....... + 3 + 2 + 1
//      = n*(n+1)/2
// f(n) = n^2/2 + n/2
// That means O(f(n)) = O(n^2)
```

````test
i := 0
while i < n do
    j = 0
    while j < 3n do
        j = j + 1
    j = 0
    while j < 2n do
        j = j + 1
    i = i + 1

// f(n) = n * (3n + 2n) = 5n^2
// this means O(f(n)) = O(n^2)
```

- **The following run in logarithmic time: O(log(n))**

  > Suppose we have a sorted array and we want to find the index of a particular value in the array, if it exists. What is the time complexity of the following algorithm?

  ```test
  low := 0
  high := n-1
  while( low <= high) do
    mid :=(low + high) / 2

    if array[mid] == value: return mid
    if array[mid] < value: low := mid + 1
    else high := mid - 1
  return -1 // value not found

  // What happens here: For every iteration, we are reducing the number of elements in question by half.
  1st iteration ---- n elements
  2nd iteration ---- n/2 elements
  3rd iteration ---- n/4 elements
  4rth iteration ---- n/8 elements
  .
  .
  .
  kth iteration ---- n/2^(k-1) elements

  Now we know that the algorithm will stop when the element is found, that exactly one elements remains

  Hence, n/2^(k-1) = 1 => log(n/2^(k-1)) = log(1)
                       => log(n) - log(2^(k-1)) = 0
                       => log(n) = (k-1)log(2)
                       => k = (log(n)/log(2)) +1
                       since, log(2) = 1 as base of log is 2
                       => k = log(n) + 1
                       Total number of iteration, i.e. the time complexity = k = log(n) which is O(log(n))
````
