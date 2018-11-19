# Unique Characters
Returns if a string is made up of unique characters
## Challenge
Given a string input, return whether the string contains a set of unique characters or not.

## Approach & Efficiency

Big O time: O(N)
We traverse through the whole string for N characters. The time is O(N).
Big space: O(N)
We are adding a new hashtable with key and values equivalent to the number of characters in the string if the string is unique.

## Solution
![Unique Characters](../../assets/unique_characters.jpg).