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
  }
  if (exit == true)
  { break; }
}

if (num % 7 == 0 && num % 23 == 0)
{
  Console.WriteLine($"Число {num} кратно одновременно 7 и 23.");
}
else
{
  Console.WriteLine($"Число {num} не кратно одновременно 7 и 23.");
}