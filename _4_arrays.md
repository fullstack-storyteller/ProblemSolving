# Static & Dynamic Arrays

A static array is a fixed length container containing n elements indexable from the range [0, n-1].

> Indexable - this means that each slot/index in the array
> can be referenced with a number

They have contiguous chunks of memory addresses. Some usage examples include:

- Storing and accessing sequential data
- Temporarily storing objects
- Used by IO routines as buffers
- Lookup tables and invers lookup tables
- Can be used to return multiple values from a function
- Used in dynamic programming to cache answers to subproblems

| Operations | Static Array | Dynamic Array |
| ---------- | ------------ | ------------- |
| Access     | O(1)         | O(1)          |
| Search     | O(n)         | O(n)          |
| Insertion  | N/A          | O(n)          |
| Appending  | N/A          | O(1)          |
| Deletion   | N/A          | O(n)          |

## Static Array Operations

A = [44, 12, -5, 17, 6, 0, 3, 9, 100]

Indexes = 0, 1, 2, 3, 4, 5, 6, 7, 8

A[0] = 44, A[1] = 12 and A[7] = 100

But, A[9] = index out of bounds

## Dynamic Array Operations

A =[34, 4]

A.add(-7) => A = [34, 4, -7]

A.add(34) => A = [34, 4, -7, 34]

A.remove(4) => A = [34, -7, 34]
