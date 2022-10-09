//Что оценивается: в программе, помимо основного метода main, присутствует два других метода, которые вызываются в теле метода main. 
//Названием методов соответствуют тому, что они делают (разделяют или выводят данные).

class Programm
{
    /// <summary>
    /// Метод считывания введенного пользователем предложения
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string[] TakeText(string text)
    {
        string[] str = { text };
        return str;
    }
    /// <summary>
    /// Метод вывода отдельных слов
    /// </summary>
    /// <param name="text"></param>
    static void OutText(string text)
    {
        string[] resalt = TakeText(text);
        resalt = text.Split();

        foreach (string item in resalt)
        {
            Console.WriteLine($"\n{item}");
        }
    }

    // Реализация ввода пользователем предложения и вывод отдельных слов предложения с использованием методf
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:" + "\n");
        string text = Console.ReadLine();
        TakeText(text);
        Console.WriteLine("\nВывод отдельных слов:");
        OutText(text);
    }
}









