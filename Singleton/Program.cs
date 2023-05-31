Singleton.Instance.Data.Add(1);
Singleton.Instance.Data.Add(2);

Singleton singleton1 = Singleton.Instance;
Singleton singleton2 = Singleton.Instance;

singleton1.Data.Add(3);
singleton2.Data.Add(4);

foreach (var item in Singleton.Instance.Data)
{
    Console.WriteLine(" " + item);
}

class Singleton 
{
    static private Singleton instance;
    public List<int> Data { get; set; }

    private Singleton()
    {
        Data = new List<int>(); 
    }

    static public Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}