
// See https://aka.ms/new-console-template for more information
public class Category : IComponent
{
    private string name;
    private List<IComponent> components = new List<IComponent>();

    public Category(string name)
    {
        this.name = name;
    }

    public void Add(IComponent component)
    {
        components.Add(component);
    }

    public void Remove(IComponent component)
    {
        components.Remove(component);
    }

    public string Display(int depth)
    {
        string result = new String('-', depth) + name + "\n";
        foreach (IComponent component in components)
        {
            result += component.Display(depth + 2);
        }
        return result;
    }
}

