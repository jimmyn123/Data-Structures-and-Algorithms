# Binary Search
A search that halves the needed amount to search each time
## Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
Big O time: O(logn)
Since we will iterate through the array but only search half each time, it will be log n
Big O space: O(1)
We will just search the array so we don't create any new items that will take up space

## Solution
![ArrayShift whiteboard picture](../../assets/binary_search.jpg).