//��� �����������: � ���������, ������ ��������� ������ main, ������������ ��� ������ ������, ������� ���������� � ���� ������ main. 
//��������� ������� ������������� ����, ��� ��� ������ (��������� ��� ������� ������).

class Programm
{
    /// <summary>
    /// ����� ���������� ���������� ������������� �����������
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static string[] TakeText(string text)
    {
        string[] str = { text };
        return str;
    }
    /// <summary>
    /// ����� ������ ��������� ����
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

    // ���������� ����� ������������� ����������� � ����� ��������� ���� ����������� � �������������� �����f
    static void Main(string[] args)
    {
        Console.WriteLine("������� �����������:" + "\n");
        string text = Console.ReadLine();
        TakeText(text);
        Console.WriteLine("\n����� ��������� ����:");
        OutText(text);
    }
}









