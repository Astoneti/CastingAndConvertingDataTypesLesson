using System;

namespace CastingAndConvertingDataTypesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Написание кода, пытающегося сложить значения типов int и string, 
            //а затем сохранить результат в переменной типа int

            //int first = 2;
            //string second = "4";
            //string result = first + second;     Создаем переменную result меняем  int на string 
            //Console.WriteLine(result);


            //2- Изменение кода в редакторе .NET для выполнения неявного преобразования

            //int myInt = 3;
            //Console.WriteLine($"int: {myInt}");

            //decimal myDecimal = myInt; // здесь происходит неявное преобразования с decimal на int (Точность данных может быть утеренна)
            //Console.WriteLine($"decimal: {myDecimal}");

            //3- Чтобы выполнить приведение, заключите тип данных в оператор приведения (),
            //а затем поместите его рядом с переменной, которую необходимо преобразовать.

            //decimal myDecimal = 3.14m;
            //Console.WriteLine($"decimal: {myDecimal}");

            /* int myInt = (int)myDecimal;*/ //Переменная myDecimal содержит значение с точностью в два разряда.
                                             //Добавляя инструкцию приведения (int), мы сообщаем компилятору C#, 
                                             //что осознаем возможность потери точности и в этом случае она приемлема.
                                             //Console.WriteLine($"int: {myInt}");


            //4- Преобразование числа в строку с помощью метода ToString()

            //int first = 5;
            //int second = 7;
            //string message = first.ToString() + second.ToString(); // вызов метода ToString() для преобразования!!!
            //Console.WriteLine(message);


            //5- Изменение кода в редакторе .NET для преобразования строки в тип int 
            //с помощью вспомогательного метода Parse()

            //string first = "5";
            //string second = "7";
            //int intSum = int.Parse(first) + int.Parse(second);  //преобразования строки в тип int с помощью метода Parse()
            //Console.WriteLine(intSum);


            //6- Преобразования строки в число с помощью класса Convert
            // В этом случае мы использовали метод Convert.ToInt32() для строки, 
            //однако в подобных ситуациях по возможности следует использовать TryParse().

            //string value1 = "5";
            //string value2 = "7";
            //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            //Console.WriteLine(result);

            //7- два способа изменения дробного числа на целое (приведение и преобразование)

            //int value = (int)1.5m; // casting truncates
            //Console.WriteLine(value);

            //int value2 = Convert.ToInt32(1.5m); // converting rounds up
            //Console.WriteLine(value2);

            // При приведении число с плавающей запятой усекается, то есть часть значения после десятичной 
            //запятой полностью игнорируется.Мы могли бы изменить литеральное значение с плавающей запятой на 1.999m, 
            //и результат приведения был бы таким же.

            //При преобразовании с помощью Convert.ToInt32() литеральное значение с плавающей запятой
            //правильно округляется до 2. Если бы мы изменили литеральное значение на 1.499m, оно бы округлилось
            //в меньшую сторону до 1.
        }

    }
}
