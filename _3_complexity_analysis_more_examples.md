# Complexity Analysis [Some more examples]

## Finding all the subsets of a set

For a given set S = {a, b, c}, the power **P(S)** set is a set which contains all possible subsets of S.

P(S) = {{}, {a}, {b}, {c}, {a, b}, {a, c}, {b, c}, {a, b, c}}

General rule is that for a given Set with n distinct element, the power set contains 2<sup>n</sup> elements. Hence, total numbers of elements in S = 3, Total numbers of elements in P(S) = 8 (including the empty elements)

The formula for Power Set of a Set S with n distinct elements is something like the below:

P(S) = <sup>n</sup>C<sub>0</sub> + <sup>n</sup>C<sub>1</sub> + <sup>n</sup>C<sub>2</sub> + .... + <sup>n</sup>C<sub>n</sub>

Hence, for S = {a, b, c},

P(S) = <sup>3</sup>C<sub>0</sub> + <sup>3</sup>C<sub>1</sub> + <sup>3</sup>C<sub>2</sub> + <sup>3</sup>C<sub>3</sub>
= 1 + 3 + 3 + 1
= 8

There are two approaches to find the find the total number of elements in the power set of a set S

- Iterative Approach

  -

  ```Algorithm
  Input: Set[], set_size
    1. Get the size of power set
    powet_set_size = pow(2, set_size)
    2. Loop for counter from 0 to pow_set_size
     (a) Loop for i = 0 to set_size
          (i) If ith bit in counter is set
               Print ith element from set for this subset
     (b) Print separator for subsets i.e., newline

  ```

- Backtracking Approach
