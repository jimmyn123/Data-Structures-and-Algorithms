# Insert and Shift an Array
## Challenge
Write a method called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Approach & Efficiency
Big O time: O(n)
Since we have to iterate through the new array to copy and insert the new value, it will be linear time as it depends on the number of elements in the array.
Big O space: O(n)
We will have to use the same amount of space as the items in the array so the space is linear as well.

## Solution
![ArrayShift whiteboard picture](../../assets/array_shift.jpg)