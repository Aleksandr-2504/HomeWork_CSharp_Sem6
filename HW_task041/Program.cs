/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int NumbersGreaterZero(int[] array)
{
  int count = 0;
  foreach (int el in array) 
    count += el > 0 ? 1 : 0;
  return count;
}

int[] ArrayConverStr(string stringArray)
{
  string[] nums = stringArray.Split(" ");
  int[] result = new int[nums.Length];
  for (int i = 0; i < nums.Length; i++)
    result[i] = int.Parse(nums[i]);
  return result;
}

Console.Clear();
Console.Write("Введите M чисел через пробел: ");
string strM = Console.ReadLine();
int[] arrInt = ArrayConverStr(strM);
Console.Write($"{String.Join(", ", arrInt)} -> {NumbersGreaterZero(arrInt)}");

