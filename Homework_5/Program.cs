//��� �����������: � ���������, ������ ��������� ������ main, ������������ ��� ������ ������, ������� ���������� � ���� ������ main. 
//��������� ������� ������������� ����, ��� ��� ������ (��������� ��� ������� ������).

class Programm
{
    /// <summary>
    /// ����� ���������� ����������� �� ��������� �����
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string[] TakeText(string text)
    {
        string[] str = text.Split(' ');
        return str;
    }
    /// <summary>
    /// ����� ������ ��������� ����
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

    // ���������� ����� ������������� ����������� � ����� ��������� ���� ����������� � �������������� �����f
    static void Main(string[] args)
    {
        Console.WriteLine("������� �����������:" + "\n");
        string text = Console.ReadLine();
        string [] resalt = TakeText(text);
        Console.WriteLine("\n����� ��������� ����:");
        OutText(resalt);
    }
}









