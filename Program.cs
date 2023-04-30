//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
            /*
             Console.WriteLine("Inpute first number: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inpute second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            if (num_1 > num_2)
            {
                Console.WriteLine("Первое число " + num_1 + " больше чем второе " + num_2);
            }
            else
            {
                Console.WriteLine("Второе число " + num_2 + " больше чем первое " + num_1);
            }
            */

//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


            /*
            Console.WriteLine("Enter three numbers:");
            int num_a = Convert.ToInt32(Console.ReadLine());
            int num_b = Convert.ToInt32(Console.ReadLine());
            int num_c = Convert.ToInt32(Console.ReadLine());

            int max = num_a;

            if (num_b > max)
            {
                max = num_b;
            }

            if (num_c > max)
            {
                max = num_c;
            }

            Console.WriteLine("The largest of the entered numbers -> " + max);
            
            */

//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            /*
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.WriteLine("Число " + number + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + number + "является: ЧЁТНЫМ");
            }
            */

            //Задача 8
            //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            //5 -> 2, 4
            //8 -> 2, 4, 6, 8

            int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + number);
            while (i <= number)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            
            

        