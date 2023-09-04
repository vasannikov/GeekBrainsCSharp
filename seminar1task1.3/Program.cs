System.Console.WriteLine("Введите номер");
int a = Convert.ToInt32 (Console.ReadLine());
switch (a)
{
   case 1: Console.WriteLine ("Пн");
   break;

   case 2: Console.WriteLine ("Вт");
   break;

   case 3: Console.WriteLine ("Ср");
   break;

   case 4: Console.WriteLine ("Чт");
   break;

   case 5: Console.WriteLine ("Пт");
   break;

   case 6: Console.WriteLine ("Сб");
   break;

   case 7: Console.WriteLine ("Вс");
   break;
}