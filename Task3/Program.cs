bool exit = new bool();
int num = new int();
while (true)
{
  Console.Write("Введите целое число: ");
  exit = true;
  try
  { num = Convert.ToInt32(Console.ReadLine()); }
  catch
  {
    Console.WriteLine("Неверный формат ввода данных!");
    exit = false;
    num = 0;
  }
  if (num >= 10 && num <= 99)
  { exit = true; }
  else
  {
    if (exit == true)
    { Console.WriteLine($"Нужно ввести число в диапазоне от 10 до 99! Вы ввели {num}."); }
    exit = false;
  }
  if (exit == true)
  { break; }
}
if (num % 10 > num / 10)
{ Console.WriteLine($"Наибольшая цифра числа {num}: {num % 10}"); }
else
{ Console.WriteLine($"Наибольшая цифра числа {num}: {num / 10}"); }