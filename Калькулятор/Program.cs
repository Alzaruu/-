Console.WriteLine("Для выполнения дейсвий над двумя числами укажите номер действия, где ");
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");


bool n = true;
do
{ 
    Console.WriteLine("Введите действие,которое хотите совершить над этими числами");
    string k = Console.ReadLine();
    int l = Convert.ToInt32(k); 


   while (l != 9)
     {
            Console.WriteLine("Введите первое число");
            string o = Console.ReadLine();
            int num1 = Convert.ToInt32(o);
            Console.WriteLine("Введите второе число(если оно не нужно, то введите 1)");
            string f = Console.ReadLine();
            int num2 = Convert.ToInt32(f);

            if (l == 1)
            {
                Console.WriteLine(num1 + num2);
            }
            else if (l == 2)
            {
                Console.WriteLine(num1 - num2);
            }
            else if (l == 3)
            {
                Console.WriteLine(num1 * num2);
            }
            else if (l == 4)
            {
                Console.WriteLine(num1 / num2);
            }
            else if (l == 5)
            {
                Console.WriteLine("Введите степень");
                string q = Console.ReadLine();
                int step = Convert.ToInt32(q);
                Console.WriteLine(num1 ^ step);
            }
            else if (l == 6)
            {
                Console.WriteLine(Math.Sqrt(num1));
            }
            else if (l == 7)
            {
                Console.WriteLine((num1 * 1 )/ 100);
            }
            else if (l == 8)
            {
                int factorial = 1;
                for (int i = 2; i <= num1; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine(factorial);
            }
            else if (l == 9)
            { 
                n = false;
                Console.WriteLine("До свидания");
            }
            else
            {
                Console.WriteLine("Вы введи несуществующую функцию");
            }
        }
}while (n = false);