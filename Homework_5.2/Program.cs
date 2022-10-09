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
    /// <summary>
    /// ����� �������������� ���� � �����������
    /// </summary>
    /// <returns></returns>
    static string[] ReversWord()
    {
        string[] words = SplitWords();
        Array.Reverse(words);
        Console.WriteLine("\n������� ����������� � �������� �������:\n");
        foreach (string item in words)
        {
          Console.Write(item + " ");
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