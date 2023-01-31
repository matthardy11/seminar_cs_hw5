// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillRandomArray(int arrSize)
{
  Random rand = new Random();
  int[] array = new int[arrSize];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(100, 1000);
  }
  return array;
}

void FindPositive(int[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] % 2 == 0)
    {
      count++;
    }
  }
  System.Console.WriteLine("Колличество положительных чисел в массиве: " + count);
}

FindPositive(FillRandomArray(30));
