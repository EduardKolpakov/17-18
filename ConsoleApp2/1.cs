zadanie5();
async void zadanie1()
{
    string text = Console.ReadLine();
    using (StreamWriter sw = new StreamWriter(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\Letter_To_Santa_Claus.txt", false))
    {
        await sw.WriteLineAsync(text);
    } 
}
void zadanie2()
{
    int count = 0;
    string res;
    using (StreamReader sr = new StreamReader(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\Text.txt"))
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
    using (StreamWriter sw = new StreamWriter(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\TEXT1.txt", false))
    {
        for (int i = 0; i < 10; i++)
        {
            sw.WriteLine(Random.Shared.Next(0, 1000));
        }
    }
    using (StreamReader sr = new StreamReader(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\TEXT1.txt"))
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
    using (StreamWriter sw = new StreamWriter(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\TEXT1_1.txt", false))
    {
        foreach (int s in numbers)
        {
                sw.WriteLine(s);
        }
    }
}

void zadanie4()
{
    string[] res = new string[3];
    int num = Convert.ToInt32(Console.ReadLine());
    using (StreamReader sr = new StreamReader(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\fio_stud.txt"))
    {
        int len = 0;
        len = File.ReadAllLines(@"C:\Users\202215\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\fio_stud.txt").Count();
        if (num > len)
        {
            Console.WriteLine($"Студента с номером {num} нет в списке");
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                res = sr.ReadLine().Split(" ");
            }
            Console.WriteLine(res[0]);
        }
    }
}

void zadanie5()
{
    string choice = Console.ReadLine();
    if (choice == "Random")
    {
        int ran = Random.Shared.Next(0, 2);
        if (ran == 0)
        {
            choice = "Reader";
        }
        else
        {
            choice = "Writer";
        }
        Console.WriteLine(choice);
    }
    if (choice == "Reader")
    {
        using (StreamReader sr = new StreamReader(@"C:\Users\Kolpa\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\zadanie5.txt"))
        {
            if (string.IsNullOrEmpty(sr.ReadToEnd()))
            {
                Console.WriteLine("Файл пустой!!!");
            }
            else
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
    else if (choice == "Writer")
    {
        using (StreamWriter sw = new StreamWriter(@"C:\Users\Kolpa\Source\Repos\EduardKolpakov\17-18\ConsoleApp2\zadanie5.txt", true))
        {
            sw.WriteLine("\nИльназ Алмазович лучший!!! Чест слово, я прям кайфую на его па-рах!!! Мы вас любим!!!");
        }
    }
}