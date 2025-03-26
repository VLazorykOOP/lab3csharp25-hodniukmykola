using System;
using System.Collections.Generic;

// Базовий клас "Деталь"
class Detail
{
    protected string name;
    protected double weight;

    public Detail(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Деталь: {name}, Вага: {weight} кг");
    }
}

// Похідний клас "Механізм"
class Mechanism : Detail
{
    protected int movingParts;

    public Mechanism(string name, double weight, int movingParts) : base(name, weight)
    {
        this.movingParts = movingParts;
    }

    public override void Show()
    {
        Console.WriteLine($"Механізм: {name}, Вага: {weight} кг, Рухомі частини: {movingParts}");
    }
}

// Похідний клас "Виріб"
class Product : Detail
{
    protected string material;

    public Product(string name, double weight, string material) : base(name, weight)
    {
        this.material = material;
    }

    public override void Show()
    {
        Console.WriteLine($"Виріб: {name}, Вага: {weight} кг, Матеріал: {material}");
    }
}

// Похідний клас "Вузол"
class Assembly : Detail
{
    protected int numberOfParts;

    public Assembly(string name, double weight, int numberOfParts) : base(name, weight)
    {
        this.numberOfParts = numberOfParts;
    }

    public override void Show()
    {
        Console.WriteLine($"Вузол: {name}, Вага: {weight} кг, Кількість деталей: {numberOfParts}");
    }
}

class Program
{
    static void Main()
    {
        List<Detail> details = new List<Detail>
        {
            new Detail("Гвинт", 0.5),
            new Mechanism("Редуктор", 10.2, 5),
            new Product("Корпус", 15.7, "Алюміній"),
            new Assembly("Двигун", 50.5, 10)
        };

        foreach (var detail in details)
        {
            detail.Show();
        }
    }
}
