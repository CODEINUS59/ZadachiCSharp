using System;


public class Newsapper
{
    public static string name;
    public static int tirage;
    public static int rows;

    public void Init()
    {
        name = "Пермь Великая";
        tirage = 1000;
        rows = 100;

    }
    public void Info()
    {
        Console.WriteLine("Название газеты: " + name);
        Console.WriteLine("Тираж: " + tirage + " экземпляров");
        Console.WriteLine("Количество полос: " + rows);
    }

    public void ChangeName()
    {
        string newname;

        Console.WriteLine("Введите новое имя газеты \n");
        newname = Console.ReadLine();
        name = newname;

    }
    public void ChangeNumber()
    {
        int newrows;
        Console.WriteLine("Введите новое количество полос газеты \n");
        newrows = Convert.ToInt32(Console.ReadLine());
        rows = newrows;

    }
}


