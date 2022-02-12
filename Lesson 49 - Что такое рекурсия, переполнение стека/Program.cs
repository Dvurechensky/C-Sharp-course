﻿using System;

/*
 * Рекурсия
 * 
 * Методы и стек
 * 
 * Переполнение стека
 */

 /*
  * ДЗ 1
  * Реализовать вывод массива с помощью рекурсии
  * 
  * ДЗ 2
  * Найти сумму элементов массива с помощью рекурсии
  * 
  * ДЗ 3
  * Найти сумму цифр числа с помощью рекурсии Например - 561(число) = 12(сумма его чисел)
  */

namespace Lesson_49___Что_такое_рекурсия__переполнение_стека
{
    class Program
    {
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }


        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 5,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }

        static void Print(Item item)
        {
            if(item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }

        //Когда метод вызывает сам себя - рекурсия
        //Обязательно нужно предусматривать условие выхода из рекурсии
        //Недостаток - использовать можно только для коротких операций с малым числом переменных
        private static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
                return;
            i++;
            Foo(i);
        }

        //DZ_1
        private static void PrintArray<T>(T[] array, int index = 0)
        {
            Console.WriteLine(array[index]);
            if (index + 1 == array.Length)
                return;
            index++;

            PrintArray(array, index);
        }

        //DZ_2
        private static void SumArray(int[] array, int index = 0, int Sum = 0)
        {
            Sum += array[index];
            if (index + 1 == array.Length)
            {
                Console.WriteLine("Summa: " + Sum);
                return;
            }
            index++;

            SumArray(array, index, Sum);
        }

        //DZ_3
        private static void SumNumber(int number, int indexSymphol = 0, int Summa = 0)
        {
            int sym = 0;
            int.TryParse((number.ToString()[indexSymphol]).ToString(), out sym);
            Summa += sym;
            if (indexSymphol + 1 == number.ToString().Length)
            {
                Console.WriteLine("Summa_Number: " + Summa);
                return;
            }
            indexSymphol++;

            SumNumber(number, indexSymphol, Summa);
        }

        static void Main(string[] args)
        {
            Foo(0);

            Item item = InitItem();

            Print(item);
            //или
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }

            //DZ 1
            string[] dz_1 = { "33", "22", "11" };
            PrintArray(dz_1);

            //DZ 2
            int[] dz_2 = { 1, 3, 4 };
            SumArray(dz_2);

            //DZ 3
            int num = 564;
            SumNumber(num);
        }
    }
}
