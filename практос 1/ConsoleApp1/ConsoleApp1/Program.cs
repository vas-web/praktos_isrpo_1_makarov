﻿/*
1. Разработать программу, соответствующую варианту индивидуального
задания. Решение реализовать через функцию.
2. Оформить спецификацию модуля по варианту решаемой задачи.
3. Готовый проект с документацией выгрузить в облачный репозиторий.

вариант 9. Дана вещественная матрица размерности n * m. Вывести номера
столбцов, содержащих только отрицательные элементы.

[Начало]
    |
    V
[Задать матрицу]
    |
    V
[Определить n и m]
    |
    V
     |-----------------------------------|
     |                                   |
[Цикл по j от 0 до m-1]                | --- (-> j++)
     |                                   |
     V                                   |
[allNegative = true]                    |
     |                                   |
     V                                   |
[Цикл по i от 0 до n-1] <----------------
     |                                   |
     V                                   |
[Если matrix[i, j] >= 0]                |
     |                                   |
    / \                                   |  
   /   \                                  |
[Да]   [Нет]                              |
   |      |                               |
   V      V                               |
[allNegative = false]                    |
   |                                   [Проверка allNegative]
   |                                         |
   V                                         |
                                   [Да] ----> [Вывод j]
   [Цикл j++]                             |
   |                                       |
   -----------------------> [Конец] --------

*/

using System;

class Program
{

    public static double[,] matrix = {
            { -1, -2, 3 },
            { -4, -5, -6 },
            { 7, -8, -9 }
        };
    public static int n = matrix.GetLength(0); // Количество строк
    public static int m = matrix.GetLength(1); // Количество столбцов

    static void Main()
    {

        // Вывод номеров столбцов с только отрицательными элементами
        Console.WriteLine("Столбцы, содержащие только отрицательные элементы:");
        for (int j = 0; j < m; j++)
        {
            bool allNegative = true;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] >= 0)
                {
                    allNegative = false;
                    break;
                }
            }

            if (allNegative)
            {
                Console.WriteLine(j); // Вывод номера столбца
            }
        }
    }
}
