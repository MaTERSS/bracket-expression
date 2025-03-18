/*
 Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением. Определить максимальную глубину вложенности скобок.
Текущая глубина равняется разности открывающихся и закрывающихся скобок в момент подсчета каждого символа.
К символу в строке можно обратиться по индексу
Пример “(()(()))” - строка корректная и максимум глубины равняется 3.
Пример некорректных строк: ";(()";, ";())";, ";)(";, ";(()))(()";
 */
using System;
using System.Text;

namespace SCharplight
{
    internal class Programm
    {   
        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 10; 
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = random.Next(2) == 0 ? '(' : ')'; 
            }

            string expression = new string(chars);
            Console.WriteLine($"Сгенерированное выражение: {expression}");

            int currentDepth = 0;
            int maxDepth = 0; 

            foreach (char c in expression)
            {
                if (c == '(') 
                {
                    currentDepth++; 
                    if (currentDepth > maxDepth) 
                    {
                        maxDepth = currentDepth; 
                    }
                }

                else if (c == ')') 
                {
                    currentDepth--; 
                    if (currentDepth < 0) 
                    {
                        Console.WriteLine($"Строка '{expression}' некорректна, максимальная глубина: {maxDepth}");
                        return;
                    }
                }
            }

            bool isCorrect = currentDepth == 0; 
            Console.WriteLine($"Строка '{expression}' корректна, максимальная глубина: {maxDepth}");
        }
    }
}