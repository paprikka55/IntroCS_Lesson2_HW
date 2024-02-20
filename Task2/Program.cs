int xpoint = new int();
int ypoint = new int();
bool exit = new bool();
Console.WriteLine("Введите координаты точек X и Y. Координаты не должны быть равны 0!");
while (true)
{
  exit = true;
  Console.Write("Введите X (целое число): ");
  try
  {
    xpoint = Convert.ToInt32(Console.ReadLine());
  }
  catch
  {
    Console.WriteLine("Неверный формат ввода данных!");
    exit = false;
  }
  if (exit == true)
  { break; }
}

while (true)
{
  exit = true;
  Console.Write("Введите Y (целое число): ");
  try
  {
    ypoint = Convert.ToInt32(Console.ReadLine());
  }
  catch
  {
    Console.WriteLine("Неверный формат ввода данных!");
    exit = false;
  }
  if (exit == true)
  { break; }
}

if (xpoint == 0 || ypoint == 0)
{
  Console.WriteLine($"Введенные координаты точек не должны быть равны 0! Вы ввели X: {xpoint}, Y: {ypoint}.");
}
else
{
  if (xpoint > 0 && ypoint > 0)
  {
    Console.WriteLine($"Координаты X: {xpoint} и Y: {ypoint} принадлежат 1 четверти.");
  }
  else if (xpoint < 0 && ypoint > 0)
  {
    Console.WriteLine($"Координаты X: {xpoint} и Y: {ypoint} принадлежат 2 четверти.");
  }
  else if (xpoint < 0 && ypoint < 0)
  {
    Console.WriteLine($"Координаты X: {xpoint} и Y: {ypoint} принадлежат 3 четверти.");
  }
  else
  {
    Console.WriteLine($"Координаты X: {xpoint} и Y: {ypoint} принадлежат 4 четверти.");
  }
}


