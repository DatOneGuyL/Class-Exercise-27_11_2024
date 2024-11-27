internal class Program
{
    private static void Main()
    {
        string st = "";
        Random rnd = new Random();
        for (int i = 0; i < 1000; i++)
        {
            st += rnd.Next(500) + ",";
        }
        writeText("data.txt", st);

        Console.WriteLine("noi dung file data.txt");
        string content = readContent("data.txt");
        Console.WriteLine(content);
    }

    static void writeText(string path, string content)
    {
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine(content);
        writer.Close();
    }
    static string readContent(string path)
    {
        StreamReader reader = new StreamReader(path);
        string content = reader.ReadToEnd();
        reader.Close();
        return content;
    }
}