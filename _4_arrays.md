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

| Operation | Static Array | Dynamic Array |
| --------- | ------------ | ------------- |
| Access    | O(1)         | O(1)          |
| Search    | O(n)         | O(n)          |
| Insertion | N/A          | O(n)          |
| Appending | N/A          | O(1)          |
| Deletion  | N/A          | O(n)          |
