zadanie3();
async void zadanie1()
{
    string text = Console.ReadLine();
    using (StreamWriter sw = new StreamWriter(@"C:\Users\Kolpa\source\repos\ConsoleApp2\ConsoleApp2\Letter_To_Santa_Claus.txt", false))
    {
        await sw.WriteLineAsync(text);
    } 
}
void zadanie2()
{
    int count = 0;
    string res;
    using (StreamReader sr = new StreamReader(@"C:\\Users\\Kolpa\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Text.txt"))
    {
        res = sr.ReadToEnd();
    }
    string res1 = res.Replace("\r\n", " ");
    string res2 = res1.Replace('.', ' ');
    List<string> text = new List<string> (res2.Split(' '));
    foreach (string s in text)
    {
        if (s.StartsWith('С') || s.StartsWith('с'))
            count++;
    }
    Console.WriteLine($"Слов, начинающихся на букву 'с' - {count}");
}
void zadanie3()
{
    string res;
    List<int> numbers = new List<int> { };
    using (StreamWriter sw = new StreamWriter(@"C:\Users\Kolpa\source\repos\ConsoleApp2\ConsoleApp2\TEXT1.txt", false))
    {
        for (int i = 0; i < 10; i++)
        {
            sw.WriteLine(Random.Shared.Next(0, 1000));
        }
    }
    using (StreamReader sr = new StreamReader(@"C:\Users\Kolpa\source\repos\ConsoleApp2\ConsoleApp2\TEXT1.txt"))
    {
        res = sr.ReadToEnd();
        List<string> nums = new List<string>(res.Replace("\r\n", " ").Split(' '));
        foreach (string s in nums)
        {
            if (s != "")
            {
                if (Convert.ToInt32(s) % 2 == 0)
                    numbers.Add(Convert.ToInt32(s));
            }
        }
    }
    using (StreamWriter sw = new StreamWriter(@"C:\Users\Kolpa\source\repos\ConsoleApp2\ConsoleApp2\TEXT1_1.txt", false))
    {
        foreach (int s in numbers)
        {
                sw.WriteLine(s);
        }
    }
}