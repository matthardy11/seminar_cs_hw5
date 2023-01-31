// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillRandomDoubleArray(int arrSize, int leftRange, int rightRange)
{
  Random rand = new Random();
  double[] array = new double[arrSize];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
  }
  return array;
}

double FindMax(double[] array)
{
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if(array[i] > max)
    {
      max = array[i];
    }
  }
  return max;
}

double FindMin(double[] array)
{
  double min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if(array[i] < min)
    {
      min = array[i];
    }
  }
  return min;
}

double MaxMinDiff(double[] array)
{
  return FindMax(array) - FindMin(array);
}

double[] arr = FillRandomDoubleArray(40, 1, 100);

// System.Console.WriteLine("Максимальный элемент массива: " + FindMax(arr));
// System.Console.WriteLine("Минимальный элемент массива: " + FindMin(arr));
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + MaxMinDiff(arr));