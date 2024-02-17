//Question 1
// Write a pliprogram, which creates an array of 20 elements of type 
// integer and initializes each of the elements with a value equals to the 
// index of the element multied by 5. Print the elements to the console.


// int[] array = InitializeArray(20);
// PrintArray(array);

// int[] InitializeArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = i*5;
//     }
//     return arr;
// }

// void  PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine("element at index " + i + ": "+ arr[i]);
//     }
// }



// Write a program, which reads two arrays from the console and checks 
// whether they are equal (two arrays are equal when they are of equal 
// length and all of their elements, which have the same index, are equal).



// Console.WriteLine("Enter the size of the arrays:");
// int size = int.Parse(Console.ReadLine());

// int[] array1 = ReadArray(size);
// int[] array2 = ReadArray(size);

// bool isEqual = AreArraysEqual(array1, array2);

// if (isEqual)
// {
//     Console.WriteLine("The arrays are equal.");
// }
// else
// {
//     Console.WriteLine("The arrays are not equal.");
// }


// static int[] ReadArray(int size)
// {
//     int[] array = new int[size];

//     Console.WriteLine($"Enter {size} elements:");

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = int.Parse(Console.ReadLine());
//     }

//     return array;
// }

// static bool AreArraysEqual(int[] array1, int[] array2)
// {
//     if (array1.Length != array2.Length)
//     {
//         return false;
//     }

//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i] != array2[i])
//         {
//             return false;
//         }
//     }

//     return true;
// }


// Write a program, which compares two arrays of type char
// lexicographically (character by character) and checks, which one is first 
// in the lexicographical order.



// char[] firstArray = { 'a', 'b', 'c' };
// char[] secondArray = { 'a', 'd', 'd' };
// int minLength = Math.Min(firstArray.Length, secondArray.Length);

// bool arraysEqual = true;
// for (int i = 0; i < minLength; i++)
// {
//     if (firstArray[i] < secondArray[i])
//     {
//         Console.WriteLine("firstArray is first in lexicographical order.");
//         arraysEqual = false;
//         break;
//     }
//     else if (firstArray[i] > secondArray[i])
//     {
//         System.Console.WriteLine("SecondArray is first in lexicographical order.");
//         arraysEqual = false;
//         break;
//     }
//     if (arraysEqual)
//     {
//         if (firstArray.Length < secondArray.Length)
//         {
//             System.Console.WriteLine("firstArray is first in lexicographical order.");
//         }
//         else if (firstArray.Length > secondArray.Length)
//         {
//             System.Console.WriteLine("secondArray is first in lexicographical order.");
//         }
//         else
//         {
//             System.Console.WriteLine("Arrays are eqaul");
//         }

//     }
// }



// Write a program, which finds the maximal sequence of consecutive 
// equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.


// int[] arr = { 1, 1, 2, 3, 2, 2, 1 };
// List<int> maxSequence = FindMaximalSequence(arr);

// Console.WriteLine("Maximal sequence of consecutive equal elements:");
// foreach (int num in maxSequence)
// {
//     Console.Write(num + " ");
// }

//  List<int> FindMaximalSequence(int[] arr)
// {
//     List<int> maxSequence = new List<int>();
//     List<int> currentSequence = new List<int>();

//     foreach (int num in arr)
//     {
//         if (currentSequence.Count == 0 || num == currentSequence[currentSequence.Count - 1])
//         {
//             currentSequence.Add(num);
//         }
//         else
//         {
//             if (currentSequence.Count > maxSequence.Count)
//             {
//                 maxSequence.Clear();
//                 maxSequence.AddRange(currentSequence);
//             }
//             currentSequence.Clear();
//             currentSequence.Add(num);
//         }
//     }

//     if (currentSequence.Count > maxSequence.Count)
//     {
//         maxSequence.Clear();
//         maxSequence.AddRange(currentSequence);
//     }

//     return maxSequence;
// }




//Write a program, which finds the maximal sequence of consecutively 
// placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

// int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
// List<int> maxSequence = FindMaximalSequence(arr);

// Console.WriteLine("Maximal sequence of consecutively placed increasing integers:");
// foreach (int num in maxSequence)
// {
//     Console.Write(num + " ");
// }


// static List<int> FindMaximalSequence(int[] arr)
// {
//     List<int> maxSequence = new List<int>();
//     List<int> currentSequence = new List<int>();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (currentSequence.Count == 0 || arr[i] == currentSequence[currentSequence.Count - 1] + 1)
//         {
//             currentSequence.Add(arr[i]);
//         }
//         else
//         {
//             if (currentSequence.Count > maxSequence.Count)
//             {
//                 maxSequence.Clear();
//                 maxSequence.AddRange(currentSequence);
//             }
//             currentSequence.Clear();
//             currentSequence.Add(arr[i]);
//         }
//     }

//     if (currentSequence.Count > maxSequence.Count)
//     {
//         maxSequence.Clear();
//         maxSequence.AddRange(currentSequence);
//     }

//     return maxSequence;
// }


//Write a program, which finds the maximal sequence of increasing 
// elements in an array arr[n]. It is not necessary the elements to be 
// consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.


// int [] arr = {2, 4, 4, 7, 4, 7, 6, 5, 8, 4};
// List<int> maximalSequence = FindMaximalSequence(arr);

// Console.WriteLine("Maximal sequence of increasing elements: ");
// foreach (int item in maximalSequence)
// {
//     Console.WriteLine(item + " ");
// }

// List<int> FindMaximalSequence(int[] arr)
// {
//     List<int> currentSequence = new List<int>();
//     List<int> maximalSequence = new List<int>();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0 || arr[i] > arr[i - 1])
//         {
//             currentSequence.Add(arr[i]);
//         }
//         else
//         {
//             if (currentSequence.Count > maximalSequence.Count)
//             {
//                 maximalSequence = new List<int>(currentSequence);
//             }
//             currentSequence.Clear();
//             currentSequence.Add(arr[i]);
//         }
//     }
//     if (currentSequence.Count > maximalSequence.Count)
//     {
//         maximalSequence = new List<int>(currentSequence);
//     }
//     return maximalSequence;
// }


// Write a program, which reads from the console two integer numbers N
// and K (K<N) and array of N integers. Find those K consecutive 
// elements in the array, which have maximal sum.


// int[] k = {2, 3, 5, 7, 22, 3, 6};
// int[] N = {1, 3, 4, 6, 9, 33, 44};


// List<int> ConscutiveElements(int[] K, int[] N)
// {
//   for (int i = 0; i < K.Length; i++)
//   {

//   }   
// }




// Sorting an array means to arrange its elements in an increasing (or 
// decreasing) order. Write a program, which sorts an array using the 
// algorithm "selection sort".


// int[] arr = { 1, 3, 2, 2, 1 };
// int n = arr.Length;

// printDistinct(arr, n);
// void printDistinct(int[] arr, int n)
// {

//     Array.Sort(arr);

//     // Traverse the sorted array
//     for (int i = 0; i < n; i++)
//     {
//         // If the current element is not equal to the previous element, print it
//         if (i == 0 || arr[i] != arr[i - 1])
//             Console.Write(arr[i] + " ");
//     }
// }


// Write a program, which finds a subsequence of numbers with 
// maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11


// int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
// Console.WriteLine("Maximal sum of subsequence: " + MaxSubSequence(arr));

// int MaxSubSequence(int[] arr)
// {
//     int maxEndingHere = arr[0];
//     int maxSoFar = arr[0];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
//         maxSoFar = Math.Max(maxSoFar, maxEndingHere);
//     }
//     return maxSoFar;
// }


// Write a program, which finds the most frequently occurring element in 
// an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).

// int[] arr = { 1, 2, 3, 4, 5, 1, 2, 2, 3, 3, 3 };
// MostOccurringElements(arr);

// static void MostOccurringElements(int[] arr)
// {
//     int[] counts = new int[arr.Max() + 1]; // lets array elements are non-negative

//     foreach (var num in arr)
//     {
//         counts[num]++;
//     }

//     int maxCount = counts.Max();

//     Console.WriteLine("Most occurring elements in the array:");
//     for (int i = 0; i < counts.Length; i++)
//     {
//         if (counts[i] == maxCount)
//         {
//             Console.WriteLine($"Element: {i}, Count: {maxCount}");
//         }
//     }
// }


// Write a program to find a sequence of neighbor numbers in an array, 
// which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
// S=11  {4, 2, 5}.


// int[] arr = { 4, 3, 1, 4, 2, 4, 8 };
// int S = 11;

// List<int> sequence = FindSequenceWithSum(arr, S);

// if (sequence.Count > 0)
// {
//     Console.WriteLine("Sequence with sum " + S + ": {" + string.Join(", ", sequence) + "}");
// }
// else
// {
//     Console.WriteLine("No sequence found with sum " + S);
// }


// List<int> FindSequenceWithSum(int[] arr, int S)
// {
//     List<int> sequence = new List<int>();
//     int currentSum = 0;
//     int start = 0;

//     for (int end = 0; end < arr.Length; end++)
//     {
//         currentSum += arr[end];

//         while (currentSum > S && start <= end)
//         {
//             currentSum -= arr[start];
//             start++;
//         }

//         if (currentSum == S)
//         {
//             for (int i = start; i <= end; i++)
//             {
//                 sequence.Add(arr[i]);
//             }
//             break;
//         }
//     }

//     return sequence;
// }


//write a program to create square matrices

// int size = 4; 
// int[,] matrix = CreateSquareMatrix(size);

// Console.WriteLine("Square Matrix:");
// PrintMatrix(matrix);


// int[,] CreateSquareMatrix(int size)
// {
//     int[,] matrix = new int[size, size];
//     Random random = new Random(); // Used to generate random values

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             // For demonstration, using random values between 1 and 10
//             matrix[i, j] = random.Next(1, 11);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     int size = (int)Math.Sqrt(matrix.Length);

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Write a program, which creates an array containing all Latin letters. 
// The user inputs a word from the console and as result the program 
// prints to the console the indices of the letters from the word.

// char[] latinLetters = GenerateLatinLettersArray();
// PrintIndicesOfLetters(latinLetters);


// static void PrintIndicesOfLetters(char[] latinLetters)
// {
//     Console.Write("Enter a word: ");
//     string word = Console.ReadLine().ToUpper(); // Convert the word to uppercase for case-insensitivity

//     Console.WriteLine("Indices of letters in the word:");
//     foreach (char letter in word)
//     {
//         int index = Array.IndexOf(latinLetters, letter);
//         if (index != -1)
//         {
//             Console.WriteLine($"{letter}: {index}");
//         }
//     }
// }

// static char[] GenerateLatinLettersArray()
// {
//     char[] latinLetters = new char[26];
//     int index = 0;
//     for (char letter = 'A'; letter <= 'Z'; letter++)
//     {
//         latinLetters[index++] = letter;
//     }
//     return latinLetters;
// }

// Write a program, which finds the longest sequence of equal string
// elements in a matrix. A sequence in a matrix we define as a set of 
// neighbor elements on the same row, column or diagonal.




// string[,] matrix = {
//             {"A", "B", "C", "D"},
//             {"E", "F", "F", "H"},
//             {"I", "F", "K", "L"},
//             {"M", "F", "O", "P"}
//         };

// // Find the longest sequence length
// int longestSequenceLength = FindLongestSequenceLength(matrix);
// Console.WriteLine("Longest sequence length: " + longestSequenceLength);


// int FindLongestSequenceLength(string[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     int maxSequenceLength = 0;

//     // Check horizontal sequences
//     for (int row = 0; row < rows; row++)
//     {
//         int sequenceLength = 1;
//         for (int col = 1; col < cols; col++)
//         {
//             // If the current element is equal to the previous element in the row
//             if (matrix[row, col] == matrix[row, col - 1])
//             {
//                 sequenceLength++;
//                 maxSequenceLength = Math.Max(maxSequenceLength, sequenceLength);
//             }
//             else
//             {
//                 // Reset the sequence length
//                 sequenceLength = 1;
//             }
//         }
//     }

//     // Check vertical sequences
//     for (int col = 0; col < cols; col++)
//     {
//         int sequenceLength = 1;
//         for (int row = 1; row < rows; row++)
//         {
//             // If the current element is equal to the previous element in the column
//             if (matrix[row, col] == matrix[row - 1, col])
//             {
//                 sequenceLength++;
//                 // Update the maximum sequence length if needed
//                 maxSequenceLength = Math.Max(maxSequenceLength, sequenceLength);
//             }
//             else
//             {
//                 // Reset the sequence length
//                 sequenceLength = 1;
//             }
//         }
//     }

//     // Check diagonal sequences
//     for (int startRow = 0; startRow < rows; startRow++)
//     {
//         for (int startCol = 0; startCol < cols; startCol++)
//         {
//             int currentRow = startRow;
//             int currentCol = startCol;
//             int sequenceLength = 1;
//             while (currentRow < rows - 1 && currentCol < cols - 1)
//             {
//                 currentRow++;
//                 currentCol++;
//                 // If the current element is equal to the previous element in the diagonal
//                 if (matrix[currentRow, currentCol] == matrix[currentRow - 1, currentCol - 1])
//                 {
//                     sequenceLength++;
//                     maxSequenceLength = Math.Max(maxSequenceLength, sequenceLength);
//                 }
//                 else
//                 {
//                     // Break the loop if the elements are not equal
//                     break;
//                 }
//             }
//         }
//     }

//     return maxSequenceLength;
// }


// Write a program, which uses a binary search in a sorted array of 
// integer numbers to find a certain element.

// int[] arr = { 2, 3, 4, 10, 40 };
// int x = 10;
// int result = BinarySearch(arr, x);
// if (result == -1)
//     Console.WriteLine("Element not present in array");
// else
//     Console.WriteLine("Element found at index " + result);

// int BinarySearch(int[] arr, int x)
// {
//     int left = 0;
//     int right = arr.Length - 1;

//     while (left <= right)
//     {
//         int mid = left + (right - left) / 2;


//         if (arr[mid] == x)
//             return mid;


//         if (arr[mid] < x)
//             left = mid + 1;

//         else
//             right = mid - 1;
//     }


//     return -1;
// }


// int[] arr = { 10, 7, 8, 9, 1, 5 };
// int n = arr.Length;
// QuickSort(arr, 0, n - 1);
// Console.WriteLine("Sorted array:");
// PrintArray(arr);


// void QuickSort(int[] arr, int low, int high)
// {
//     if (low < high)
//     {
//         // pi is partitioning index, arr[pi] is now at right place
//         int pi = Partition(arr, low, high);

//         // Recursively sort elements before partition and after partition
//         QuickSort(arr, low, pi - 1);
//         QuickSort(arr, pi + 1, high);
//     }
// }

// int Partition(int[] arr, int low, int high)
// {
//     int pivot = arr[high];  // pivot
//     int i = (low - 1);  // Index of smaller element

//     for (int j = low; j < high; j++)
//     {
//         // If current element is smaller than or equal to pivot
//         if (arr[j] <= pivot)
//         {
//             i++;

//             // Swap arr[i] and arr[j]
//             int temp = arr[i];
//             arr[i] = arr[j];
//             arr[j] = temp;
//         }
//     }

//     // Swap arr[i+1] and arr[high] (or pivot)
//     int temp1 = arr[i + 1];
//     arr[i + 1] = arr[high];
//     arr[high] = temp1;

//     return i + 1;
// }

// void PrintArray(int[] arr)
// {
//     int n = arr.Length;
//     for (int i = 0; i < n; ++i)
//         Console.Write(arr[i] + " ");
//     Console.WriteLine();
// }


// Write a program, which finds all prime numbers in the range 
// [1…10,000,000].


// int start = 1;
// int end = 1000;

// Console.WriteLine($"Prime numbers in the range [{start}...{end}]:");
// List<int> primes = FindPrimesInRange(start, end);
// foreach (int prime in primes)
// {
//     Console.Write(prime + " ");
// }

// List<int> FindPrimesInRange(int start, int end)
// {
//     List<int> primes = new List<int>();
//     bool[] isPrime = new bool[end + 1];

//     for (int i = 2; i <= end; i++)
//     {
//         isPrime[i] = true;
//     }

//     for (int p = 2; p * p <= end; p++)
//     {

//         if (isPrime[p] == true)
//         {
//             for (int i = p * p; i <= end; i += p)
//                 isPrime[i] = false;
//         }
//     }

//     for (int i = start; i <= end; i++)
//     {
//         if (isPrime[i])
//             primes.Add(i);
//     }

//     return primes;
// }


//  Write a program, which checks whether there is a subset of given 
// array of N elements, which has a sum S. The numbers N, S and the array 
// values are read from the console. Same number can be used many times.
// Example: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6 = 14)

// bool IsSubsetSum(int[] arr, int n, int sum)
// {
//     // Create a DP array to store the subset sum information
//     bool[] dp = new bool[sum + 1];

//     // Base case: subset sum of 0 is always possible
//     dp[0] = true;

//     // Fill the DP array
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = arr[i]; j <= sum; j++)
//         {
//             dp[j] |= dp[j - arr[i]];
//         }
//     }

//     return dp[sum];
// }

// Console.WriteLine("Enter the size of the array:");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the array elements separated by space:");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// Console.WriteLine("Enter the desired sum:");
// int sum = int.Parse(Console.ReadLine());

// if (IsSubsetSum(arr, n, sum))
//     Console.WriteLine("Yes, there is a subset with the sum " + sum);
// else
//     Console.WriteLine("No, there is no subset with the sum " + sum);


// Write a program, which reads an array of integer numbers from the 
// console and removes a minimal number of elements in such a way 
// that the remaining array is sorted in an increasing order.
// Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}


// List<int> LongestIncreasingSubsequence(int[] nums)
// {
//     int n = nums.Length;
//     List<int>[] sequences = new List<int>[n];
//     List<int> longestSequence = new List<int>();

//     for (int i = 0; i < n; i++)
//     {
//         sequences[i] = new List<int>();
//         sequences[i].Add(nums[i]);

//         for (int j = 0; j < i; j++)
//         {
//             if (nums[i] > nums[j] && sequences[i].Count < sequences[j].Count + 1)
//             {
//                 sequences[i] = new List<int>(sequences[j]);
//                 sequences[i].Add(nums[i]);
//             }
//         }

//         if (sequences[i].Count > longestSequence.Count)
//             longestSequence = sequences[i];
//     }

//     return longestSequence;
// }

//     Console.WriteLine("Enter the array elements separated by space:");
// int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

//     List<int> longestIncreasingSubsequence = LongestIncreasingSubsequence(nums);

//     Console.WriteLine("The longest increasing subsequence is:");
//     foreach (var num in longestIncreasingSubsequence)
//     {
//         Console.Write(num + " ");
//     }


// Write a program, which reads the integer numbers N and K from the 
// console and prints all variations of K elements of the numbers in the 
// interval [1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, 
// {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.


// Console.WriteLine("Enter the value of N:");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the value of K:");
// int K = int.Parse(Console.ReadLine());

// int[] numbers = new int[N];
// for (int i = 0; i < N; i++)
// {
//     numbers[i] = i + 1;
// }

// int[] variation = new int[K];
// Variations(variation, numbers, 0);

// void Variations(int[] variation, int[] numbers, int index)
// {
//     if (index == variation.Length)
//     {
//         Console.Write("{ ");
//         foreach (var num in variation)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine("}");
//         return;
//     }

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         variation[index] = numbers[i];
//         Variations(variation, numbers, index + 1);
//     }
// }



// Write a program, which reads an integer number N from the console and 
// prints all combinations of K elements of numbers in range [1 … N].
// Example:N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, 
// {2, 5}, {3, 4}, {3, 5}, {4, 5}.


// void Combinations(int[] combination, int[] numbers, int start, int index)
// {
//     if (index == combination.Length)
//     {
//         Console.Write("{ ");
//         foreach (var num in combination)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine("}");
//         return;
//     }

//     for (int i = start; i < numbers.Length; i++)
//     {
//         combination[index] = numbers[i];
//         Combinations(combination, numbers, i + 1, index + 1);
//     }
// }


// Console.WriteLine("Enter the value of N:");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter the value of K:");
// int K = int.Parse(Console.ReadLine());

// int[] numbers = new int[N];
// for (int i = 0; i < N; i++)
// {
//     numbers[i] = i + 1;
// }

// int[] combination = new int[K];
// Combinations(combination, numbers, 0, 0);


// Write a program, which finds in a given matrix the largest area of 
// equal numbers. We define an area in the matrix as a set of neighbor 
// cells (by row and column). Here is one example with an area containing 
// 13 elements with equal value of 3:



// int[] rowDirections = { -1, 0, 1, 0 };
// int[] colDirections = { 0, 1, 0, -1 };

// int FindLargestArea(int[,] matrix, int rows, int cols)
// {
//     int maxArea = 0;

//     bool[,] visited = new bool[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             if (!visited[i, j])
//             {
//                 int currentArea = DFS(matrix, rows, cols, i, j, matrix[i, j], visited);
//                 maxArea = Math.Max(maxArea, currentArea);
//             }
//         }
//     }

//     return maxArea;
// }

// int DFS(int[,] matrix, int rows, int cols, int row, int col, int target, bool[,] visited)
// {
//     if (row < 0 || row >= rows || col < 0 || col >= cols || visited[row, col] || matrix[row, col] != target)
//         return 0;

//     visited[row, col] = true;
//     int area = 1;

//     for (int d = 0; d < 4; d++)
//     {
//         int newRow = row + rowDirections[d];
//         int newCol = col + colDirections[d];
//         area += DFS(matrix, rows, cols, newRow, newCol, target, visited);
//     }

//     return area;
// }

// int[,] matrix = {
//             { 1, 3, 2, 2, 2, 4 },
//             { 3, 3, 3, 2, 4, 4 },
//             { 4, 3, 1, 2, 3, 3 },
//             { 4, 3, 1, 3, 3, 1 },
//             { 4, 3, 3, 3, 1, 1 }
//         };

// int rows = matrix.GetLength(0);
// int cols = matrix.GetLength(1);

// int largestArea = FindLargestArea(matrix, rows, cols);

// Console.WriteLine("The largest area of equal numbers in the matrix is: " + largestArea);



