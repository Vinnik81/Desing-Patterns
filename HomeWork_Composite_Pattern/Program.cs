
Category category = new Category("Языки программирования");


IComponent cSharp = new Course("C#", "C# язык программирования");
IComponent javaScript = new Course("JavaScript", "JavaScript язык программирования");
IComponent cpp = new Course("C++", "C++ язык программирования");
IComponent sql = new Course("SQL", "SQL языки программирования");
IComponent pyton = new Course("Pyton", "Pyton языки программирования");

category.Add(cSharp);
category.Add(javaScript);
category.Add(cpp);
category.Add(sql);
category.Add(pyton);
category.Remove(pyton);

Console.WriteLine(category.Display(0));

Category category1 = new Category("Основы IT");

IComponent hardware = new Course("Hardware" ,"Апаратное обеспечение рабочих станций и ноутбуков");
IComponent admWindows_10 = new Course("Windows 10", "Администрирования OS Windows 10");
IComponent admLinux = new Course("Linux", "Администрирование OS Linux");

category1.Add(admWindows_10);
category1.Add(admLinux);
category1.Add(hardware);

Console.WriteLine(category1.Display(1));

Category category2 = new Category("Основы Компьютерных сетей");

IComponent network = new Course("Network", "Основы теории сетей");
IComponent webSecurity = new Course("WebSecurity", "Основы защиты информации");

category2.Add(network);
category2.Add(webSecurity);

Console.WriteLine(category2.Display(2));
