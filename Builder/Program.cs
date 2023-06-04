// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person person = new Person().SetSurname("Vinnik").SetName("Vladimir").SetPhone("89609936545").SetId(1);

Console.WriteLine(person.ToString());

class Person
{
    private int id;
    private string name;
    private string surname;
    private string phone;

    public Person SetId(int id)
    {
        this.id = id;
        return this;
    }

    public int GetId()
    {
        return id;
    }

    public Person SetName(string name)
    {
        this.name = name;
        return this;
    }

    public string GetName()
    {
        return name;
    }

    public Person SetSurname(string surname)
    {
        this.surname = surname;
        return this;
    }

    public string GetSurname()
    {
        return surname;
    }

    public Person SetPhone(string phone)
    {
        this.phone = phone;
        return this;
    }

    public string GetPhone()
    {
        return phone;
    }

    public override string? ToString()
    {
        return this.name + " " + this.surname + " " + this.phone;
    }
}


//Person person = new Person();
//person.SetSurname("Vinnik");
//person.SetName("Vladimir");
//person.SetPhone("89609936545");
//person.SetId(1);

//Console.WriteLine(person.ToString());

//class Person
//{
//    private int id;
//    private string name;
//    private string surname;
//    private string phone;

//    public void SetId(int id)
//    {
//        this.id = id;
//    }

//    public int GetId()
//    {
//        return id;
//    }

//    public void SetName(string name) 
//    {
//        this.name = name;
//    }

//    public string GetName() 
//    {
//        return name;
//    }

//    public void SetSurname(string surname)
//    {
//        this.surname = surname;
//    }

//    public string GetSurname()
//    {
//        return surname;
//    }

//    public void SetPhone(string phone)
//    { 
//        this.phone = phone;
//    }

//    public string GetPhone()
//    {
//        return phone;
//    }

//    public override string? ToString()
//    {
//        return this.name + " " + this.surname + " " + this.phone;
//    }
//}