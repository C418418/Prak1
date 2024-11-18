namespace evdokimovpractice1
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
            Console.WriteLine("2: Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
            Console.WriteLine("3: Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
            Console.WriteLine("4: Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
            Console.WriteLine("5: Разработайте программу для нахождения самого длинного слова в предложении");
            Console.WriteLine("6: Разработайте программу, которая может перемножить два массива значений");
            Console.WriteLine("7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
            Console.WriteLine("8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
            Console.WriteLine("Часть 2: Напечатать полную таблицу умножения");
            Console.WriteLine("Часть 3: Вариант 5 Разработайте программу, которая на основе выбранного действия выполняет");
            int window = Convert.ToInt32(Console.ReadLine());
            switch (window)
            {
                case 1:
                    double n1, n2, n3, n4;
                    double average, result;
                    Console.WriteLine();
                    Console.WriteLine("1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
                    Console.WriteLine("Введите первое число");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    n3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите четвёртое число");
                    n4 = Convert.ToDouble(Console.ReadLine());
                    average = (n1 + n2 + n3 + n4) / 4;
                    Console.WriteLine("Среднее значение чисел" + n1 + "," + n2 + "," + n3 + "," + n4 + "равно:" + average);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел");
                    Console.WriteLine("Введите первое число:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите выполняемое действие: \n" +
                        "1. Сложение\n" +
                        "2. Вычитание\n" +
                        "3. Умножение\n" +
                        "4. Деление\n" +
                        "5. Нахождение остатка\n");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            result = n1 + n2;
                            Console.WriteLine("Результат " + n1 + " + " + n2 + " = " + result);
                            break;
                        case "2":
                            result = n1 - n2;
                            Console.WriteLine("Результат " + n1 + " - " + n2 + " = " + result);
                            break;
                        case "3":
                            result = n1 * n2;
                            Console.WriteLine("Результат " + n1 + " * " + n2 + " = " + result);
                            break;
                        case "4":
                            result = n1 / n2;
                            Console.WriteLine("Результат " + n1 + " / " + n2 + " = " + result);
                            break;
                        case "5":
                            result = n1 % n2;
                            Console.WriteLine("Результат " + n1 + " % " + n2 + " = " + result);
                            break;
                        default:
                            Console.WriteLine("Ошибка ввода");
                            break;
                    }
                    break;
                case 3:
                    int inputsys, countsys;
                    Console.WriteLine();
                    Console.WriteLine("Выберете шкалу вводимой температуры: \n" +
                    "1: Цельсий \n" +
                    "2: Кельвин \n" +
                    "3: Фаренгейт \n");
                    inputsys = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите показатель температуры(градусы): ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации: \n" +
        "1. Цельсий\n" +
        "2. Кельвин\n" +
        "3. Фаренгейт\n");
                    countsys = Convert.ToInt32(Console.ReadLine());
                    switch (inputsys)
                    {
                        case 1:
                            switch (countsys)
                            {
                                case 1:
                                    Console.WriteLine("Вы зачем-то переводите Цельсий в Цельсий???");
                                    Console.WriteLine("Результат конвертации: " + n1);
                                    break;
                                case 2:
                                    Console.WriteLine("Вы выбрали: Цельсий -> Кельвин");
                                    result = n1 + 273.15;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                case 3:
                                    Console.WriteLine("Вы выбрали: Цельсий -> Фаренгейт");
                                    result = (n1 * 9 / 5) + 32;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода");
                                    break;
                            }
                            break;
                        case 2:
                            switch (countsys)
                            {
                                case 1:
                                    Console.WriteLine("Вы выбрали: Кельвин в Цельсий");
                                    result = n1 - 273.15;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                case 2:
                                    Console.WriteLine("Вы выбрали: Кельвин -> Кельвин");
                                    Console.WriteLine("Результат конвертации: " + n1);
                                    break;
                                case 3:
                                    Console.WriteLine("Вы выбрали: Кельвин -> Фаренгейт");
                                    result = (n1 - 273.15) * 9 / 5 + 32;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода");
                                    break;
                            }
                            break;
                        case 3:
                            switch (countsys)
                            {
                                case 1:
                                    Console.WriteLine("Вы выбрали: Фаренгейт в Цельсий");
                                    result = (n1 - 32) * 5 / 9;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                case 2:
                                    Console.WriteLine("Вы выбрали: Фаренгейт -> Кельвин");
                                    result = (n1 - 32) * 5 / 9 + 273.15;
                                    Console.WriteLine("Результат конвертации: " + result);
                                    break;
                                case 3:
                                    Console.WriteLine("Вы выбрали: Фаренгейт -> Фаренгейт");
                                    Console.WriteLine("Результат конвертации: " + n1);
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Ошибка ввода");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
                case 4:
                    Console.WriteLine("Введите путь до файла: ");
                    string input = Console.ReadLine();
                    string[] subs = input.Split('\\');
                    int a = subs.Length;
                    Console.WriteLine(subs[a - 1]);
                    break;

                    case 5:
                    Console.Write("Введите строку: ");
                    input = Console.ReadLine();
                    string[] str = input.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' });
                    int maxlen = 0;
                    int index = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].Length > maxlen)
                        {
                            maxlen = str[i].Length;
                            index = i;
                        }
                    }
                    Console.Write("Самое длинное слово: {0}", str[index]);
                    Console.ReadLine();
                    break;
                 
                   case 6:
                    Console.WriteLine("6: Введите значения для первого массива через пробел:");
                    string arr1 = Console.ReadLine();
                    string[] firstArrey = arr1.Split(' ');
                    Console.WriteLine("Введите значения для второго массива через пробел:");
                    arr1 = Console.ReadLine();
                    string[] secondArrey = arr1.Split(' ');
                    for (int i = 0; i < firstArrey.Length; i++)
                    {
                        Console.Write($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                    }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 7:
                    Console.Write("7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных\n");
                    Console.WriteLine("Введите пять чисел:");
                    string arr = Console.ReadLine();
                    string[] partse = arr.Split(" ");
                    int suMax = -999999999;
                    int suMin = 999999999;
                    foreach (string i in partse)
                    {
                        if (suMax < Convert.ToInt32(i))
                        {
                            suMax = Convert.ToInt32(i);
                        }
                        if (suMin > Convert.ToInt32(i))
                        {
                            suMin = Convert.ToInt32(i);
                        }
                    }
                    Console.WriteLine("Максимальное число: " + suMax); Console.WriteLine("Минимальное число: " + suMin);
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 8:
                    Console.Write("8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем\n");
                    Console.Write(" Введите уровень пирамиды : ");
                    int levels = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= levels; i++)
                    {
                        for (int j = 0; j < levels - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write(k + " ");
                        }


                        Console.WriteLine();
                    }
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 9:
                    Console.Write("9: Напечатать полную таблицу умножения в виде\n");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.Write($"{1} x {j} = {i * j}\t");
                        }

                        Console.WriteLine();

                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Конвертер температуры");

                        int choicce = 0;
                        while (true)
                        {
                            Console.WriteLine("Выберите единицу измерения для конвертации:");
                            Console.WriteLine("1. Цельсий (C)");
                            Console.WriteLine("2. Кельвин (K)");
                            Console.WriteLine("3. Фаренгейт (F)");

                          
                            Console.Write("Введите номер единицы измерения (1-3): ");
                            if (int.TryParse(Console.ReadLine(), out choicce) && choicce >= 1 && choicce <= 3)
                            {
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Пожалуйста, введите число от 1 до 3.");
                            }
                        }

                        double temperature = 0;
                        while (true)
                        {
                         
                            Console.Write("Введите значение температуры: ");
                            if (double.TryParse(Console.ReadLine(), out temperature))
                            {
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Пожалуйста, введите корректное числовое значение.");
                            }
                        }

                        switch (choicce)
                        {
                            case 1: 
                                ConvertFromCelsius(temperature);
                                break;
                            case 2: 
                                ConvertFromKelvin(temperature);
                                break;
                            case 3: 
                                ConvertFromFahrenheit(temperature);
                                break;
                        }
                    }

                    static void ConvertFromCelsius(double celsius)
                    {
                        double kelvin = celsius + 273.15;
                        double fahrenheit = (celsius * 9 / 5) + 32;

                        Console.WriteLine($"{celsius} °C = {kelvin} K");
                        Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
                    }

                    static void ConvertFromKelvin(double kelvin)
                    {
                        double celsius = kelvin - 273.15;
                        double fahrenheit = (celsius * 9 / 5) + 32;

                        Console.WriteLine($"{kelvin} K = {celsius} °C");
                        Console.WriteLine($"{kelvin} K = {fahrenheit} °F");
                    }

                    static void ConvertFromFahrenheit(double fahrenheit)
                    {
                        double celsius = (fahrenheit - 32) * 5 / 9;
                        double kelvin = celsius + 273.15;

                        Console.WriteLine($"{fahrenheit} °F = {celsius} °C");
                        Console.WriteLine($"{fahrenheit} °F = {kelvin} K");
                    }
            

            break;


            }
        }

    }
}

    

    

