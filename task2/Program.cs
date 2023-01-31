// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillRandomArray(int arrSize, int leftRange, int rightRange)
{
  Random rand = new Random();
  int[] array = new int[arrSize];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange + 1);
  }
  return array;
}

int SumNegativeIndex(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i+=2)
  {
    sum+=array[i];
  }
  return sum;
}
System.Console.WriteLine("Сумма элементов на нечетных позициях в массиве равна: " + SumNegativeIndex(FillRandomArray(40, 0, 150)));
