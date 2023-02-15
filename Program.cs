// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
		
int max_word_length = 3;
		
	string[] GetShortWordsArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
		for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= max_word_length)
				{
					result[count] = array[i];
					count++;
				}
			}
		Array.Resize(ref result, count);
			
			return result;
		}
		
	void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
	Console.WriteLine("[]");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
	void PrintTask(string[] array)
		{
	Console.WriteLine("Введенный массив:");
	PrintArray(array);
	string[] shortArray = GetShortWordsArray(array);
	Console.WriteLine($"Полученный массив: ");
	PrintArray(shortArray);
	Console.WriteLine();
		}
		
	PrintTask(arr1);
	PrintTask(arr2);
	PrintTask(arr3);
	

// Console.WriteLine("Введите количество элементов массива: ");
// int size = int.Parse(Console.Readline());
// string[] arr1 = new string[size];
// int count = 0;
// int maxSymbols = 3;
// for (int i = 0; i < size; i++)
// {
//     Console.Write("Введите элемент массива: ");
//     string result = Console.ReadLine();
//     arr1[i] = result;
// }
// Console.WriteLine();
// Console.Write("Введенный массив: [");
// Console.Write(string.Join(",", arr1));
// Console.Write("]");

// int count = 0;
// int maxSymbols = 3;
// for (int i = 0; i < arr1.Length; i++)
// {
//     if (arr1[i].Length <= maxSymbols)
//     {
//         count++;

//     }
// }
// Console.WriteLine();
// Console.Write("Полученный массив: [");
// string[] arr2 = new string[count];
// int j = 0;
// for (int i = 0; i < arr1.Length; i++)
// {
//     if (arr1[i].Length <= maxSymbols)
//     {
//         arr2[j] = arr1[i];
//         Console.WriteLine(arr2[j] + ",");
//         j++;
//     }
// }
// Console.WriteLine("]");
