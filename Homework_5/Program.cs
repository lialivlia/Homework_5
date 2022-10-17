//Что оценивается: в программе, помимо основного метода main, присутствует два других метода, которые вызываются в теле метода main. 
//Названием методов соответствуют тому, что они делают (разделяют или выводят данные).

class Programm
{
    /// <summary>
    /// Метод разделения предложения на отдельные слова
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string[] TakeText(string text)
    {
        string[] str = text.Split(' ');
        return str;
    }
    /// <summary>
    /// Метод вывода отдельных слов
    /// </summary>
    /// <param name="text"></param>
    static string[] OutText(string [] text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine("\n" + text[i]);
        }
        return text;
    }

    // Реализация ввода пользователем предложения и вывод отдельных слов предложения с использованием методf
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:" + "\n");
        string text = Console.ReadLine();
        string [] resalt = TakeText(text);
        Console.WriteLine("\nВывод отдельных слов:");
        OutText(resalt);
    }
}









