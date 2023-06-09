
// See https://aka.ms/new-console-template for more information
public interface IComponent
{
    void Add(IComponent component);
    void Remove(IComponent component);
    string Display(int depth);
}

