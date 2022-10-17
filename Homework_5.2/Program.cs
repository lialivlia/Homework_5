//Что оценивается: вызов метода по разделению на слова происходит внутри метода, который отвечает непосредственно за инвертирование слов в предложении.

class Programm
{
    /// <summary>
    /// Метод разделения предложения
    /// </summary>
    /// <returns></returns>
    static string[] SplitWords()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    // Первоначальный вариант метода ReversWord
    /// <summary>
    /// Метод инвертирования слов в предложении
    /// </summary>
    /// <returns></returns>
    //static string[] ReversWord()
    //{
    //    string[] words = SplitWords();
    //    Array.Reverse(words);
    //    Console.WriteLine("\nВыводим предложение в обратном порядке:\n");
    //    foreach (string item in words)
    //    {
    //      Console.Write(item + " ");
    //    }
    //    return words;
    //}


    // Второй вариант метода ReversWord
    static string[] ReversWord()
    {
        string[] words = SplitWords();
        Console.WriteLine("\nВыводим предложение в обратном порядке:\n");
        
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
        return words;
    }

    // Реализация ввода пользователем предложения и последующий вывод слов в обратном порядке
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение и нажмите клавишу Enter:\n");
        ReversWord();
    }
}