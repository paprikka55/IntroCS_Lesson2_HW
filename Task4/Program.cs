static string IntToDigStr(int num, int length)
{
  string result = "";
  int index = 1;
  int circle_num = new int();
  while (index <= (length))
  {
    circle_num = (num / Convert.ToInt32(Math.Pow(10, length - index))) % 10;
    if (index == (length))
    {
      result = result + Convert.ToString(circle_num);
    }
    else
    {
      result = result + Convert.ToString(circle_num) + ", ";
    }
    index++;
  }
  return result;
}
bool exit = new bool();
int num = new int();
string str_num;
while (true)
{
  exit = true;
  Console.Write("Введите натуральное число: ");
  str_num = Console.ReadLine();
  try
  { num = Convert.ToInt32(str_num); }
  catch
  {
    Console.WriteLine("Неверный формат ввода данных!");
    exit = false;
  }
  if (exit == true && num > 0)
  { break; }
  else if (exit == true && num == 0)
  {
    Console.WriteLine($"0 - не натуральное число!");
  }
  else if (exit == true)
  {
    Console.WriteLine($"Нужно ввести натуральное число! Вы ввели {num}");
  }
}
Console.WriteLine(IntToDigStr(num, str_num.Length));