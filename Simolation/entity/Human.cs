using Simolation.Attributes;
using Simolation.lists;

namespace Simolation.entity;

public class Human
{
    private Human Married { get; set; }
    private int intAge { get; set; }
    private int intNumber { get; set; }
    private double doubleHeight { get; set; }
    private List<Human> children { get; set; }
    private List<HumanAttributes> attributes { get; set; }

    public Human(int age, double height)
    {
        age = intAge = age;
        intAge = HumanList.Humans.Count;
        doubleHeight = height;
        children = new List<Human>();
        attributes = new List<HumanAttributes>();
    }

    public static Human NewChildren(Human father, Human mother)
    {
        Human child = new Human(0, 1.88);
        father.children.Add(child);
        mother.children.Add(child);
        return child;
    }

    public static void Marry(Human father, Human mother)
    {
        HumanList.MarriedHumans.Add(father, mother);
    }
}