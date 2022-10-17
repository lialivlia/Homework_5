//��� �����������: ����� ������ �� ���������� �� ����� ���������� ������ ������, ������� �������� ��������������� �� �������������� ���� � �����������.

class Programm
{
    /// <summary>
    /// ����� ���������� �����������
    /// </summary>
    /// <returns></returns>
    static string[] SplitWords()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    // �������������� ������� ������ ReversWord
    /// <summary>
    /// ����� �������������� ���� � �����������
    /// </summary>
    /// <returns></returns>
    //static string[] ReversWord()
    //{
    //    string[] words = SplitWords();
    //    Array.Reverse(words);
    //    Console.WriteLine("\n������� ����������� � �������� �������:\n");
    //    foreach (string item in words)
    //    {
    //      Console.Write(item + " ");
    //    }
    //    return words;
    //}


    // ������ ������� ������ ReversWord
    static string[] ReversWord()
    {
        string[] words = SplitWords();
        Console.WriteLine("\n������� ����������� � �������� �������:\n");
        
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
        return words;
    }

    // ���������� ����� ������������� ����������� � ����������� ����� ���� � �������� �������
    static void Main(string[] args)
    {
        Console.WriteLine("������� ����������� � ������� ������� Enter:\n");
        ReversWord();
    }
}