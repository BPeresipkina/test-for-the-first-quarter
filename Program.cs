// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите строк ввода: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] massive = new string[n];
string fact = "";
int m = 0; //кол-во элементов меньше 4 символов
int j = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите данные: ");
    fact = Console.ReadLine();
    if (fact.Length < 4) m++;
    massive[i] = fact;
}

Console.WriteLine($"[{string.Join(", ", massive)}]");
// Console.WriteLine(m);

string[] finalMassive = new string[m];
for (int i = 0; i < n; i++)
{
    fact = massive[i];
    if (fact.Length < 4)
    {
        finalMassive[j] = fact;
        j++;
    }
}

Console.WriteLine($"[{string.Join(", ", finalMassive)}]");