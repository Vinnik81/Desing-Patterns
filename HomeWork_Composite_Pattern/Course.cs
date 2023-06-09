
// See https://aka.ms/new-console-template for more information

public class Course : IComponent
{
    private string name;
    private string description;

    public Course(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Add(IComponent component)
    {
        Console.WriteLine("Могу добавить в курс.");
    }

    public void Remove(IComponent component)
    {
        Console.WriteLine("Могу удалить из курса.");
    }

    public string Display(int depth)
    {
        return new String('-', depth) + name + " (" + description + ")\n";
    }
}

