// sort bubble function
List<int> BubbleSort(List<int> numbers)
{
    int temp;  //O(1)
    for(int i = 0; i < numbers.Count; i++) // O(n)
    {
        for(int j = 0; j < numbers.Count-1; j++) // O(n)
        {
            if(numbers[j] > numbers[j+1]) // O(n)
            {
                temp = numbers[j]; // O(n)
                numbers[j] = numbers[j+1]; // O(n)
                numbers[j+1] = temp; // O(n)
                // example: 5, 2, 6, 8, 4, 3
            }
        }
    }
    return numbers; // O(1)
} //O(2 + n)

int size = 10;
Random random = new Random();
List<int> numbers = new List<int>();

for(int i = 0; i < size; i++)
{
    numbers.Add(random.Next(0, 15));
}

var sort = BubbleSort(numbers);
foreach (int number in sort)
{
    Console.Write(number + " ");
}