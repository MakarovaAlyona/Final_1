//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
 
        string[] firstArray = { "table", "dog", "apple", "he", "cat" };
        string[] secondArray = new string[0];
        foreach (string str in firstArray)
        {
            if (str.Length <= 3)
            {
                Array.Resize(ref secondArray, secondArray.Length + 1);
                secondArray[secondArray.Length - 1] = str;
            }
        }
        Console.Write("Массив длиной <= 3: ");
        foreach (string str in secondArray)
        {
            Console.Write($"{str}; ");
        }
    