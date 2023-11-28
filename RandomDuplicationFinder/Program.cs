// See https://aka.ms/new-console-template for more information

// Generate a list of integers with one duplicate in the range from 1 to 1000
List<int> numbers = GenerateRandomListWithDuplicate(1, 1000);

// Print the message indicating the generated list
Console.WriteLine("Generated List:");

// Print the generated list separated by commas
Console.WriteLine(string.Join(", ", numbers));

// Find and print the duplicate number in the list
int duplicate = FindDuplicate(numbers); 
Console.WriteLine($"Duplicate Number: {duplicate}");



   // Method to generate a random list of integers with one duplicate
  static List<int> GenerateRandomListWithDuplicate(int minValue, int maxValue)
{
    //Initialize a Random object for generating random numbers
    Random random = new Random();

    // Generate a list of integers in the specified range, shuffle it randomly
    List<int> numbers = Enumerable.Range(minValue, maxValue - minValue + 1).OrderBy(x => random.Next()).ToList();


    // Add a duplicate number within the specified range
    int duplicateNumber = random.Next(minValue, maxValue + 1);
    numbers.Add(duplicateNumber);

    // Return the generated list with a duplicate
    return numbers;
}
    // Method to find the duplicate number in a list
    static int FindDuplicate(List<int> numbers)
    {
    // HashSet to store seen numbers
    HashSet<int> seenNumbers = new HashSet<int>();

    // Iterate through the list
    foreach (int num in numbers)
        {
        // If the number is already in the HashSet, it's a duplicate, return it
        if (!seenNumbers.Add(num))
            {
                return num;
            }
        }
        // No duplicate found
        return -1;
    }
