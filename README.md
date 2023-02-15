Задача :

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


Описание алгоритма решения:
Сначала объявляем 3 массива, согласно заданию. 
Потом метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ), 
если да, то элемент первого массива заносится в count элемент второго массива. 
Переменная count чтобы поочередно закидывать из первого массива во второй и чтобы потом не было пробелов. 
После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. 
И так проверяется до конца и третий массив.
Графическое представление метода в папке  .
Реализация алгоритма по пути Program.cs
