# Finding Duplicate Elements in an Array

## Overview

This algorithm searches for duplicate elements in a given array and returns them as a result array.

## Algorithm Steps

1. **Find Maximum Value**: Traverse the array to find the maximum value to determine the size of the frequency array.
2. **Create Frequency Array**: Create an array to calculate the frequency of each element in the input array.
3. **Collect Duplicate Elements**: Collect elements that have a frequency greater than 1 into a temporary array using the frequency array.
4. **Create Result Array**: Create a result array to store the collected duplicate elements.

## Complexity Analysis

- **Time Complexity**: O(n), where n is the number of elements in the input array.
- **Space Complexity**: O(m), where m is the maximum value found in the input array, used for the frequency array.

## Example

int[] array = { 1, 2, 3, 1, 2, 3 };
int[] duplicates = FindDuplicates(array);
// Expected output: duplicates = [1, 2, 3]



