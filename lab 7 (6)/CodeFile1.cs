using System;

// в даній програмі ми вводимо людину , робота або тварину, повну інформацію про них
// далі ми повинні ввести рік, рік народження яких ми хочемо побачити

class Person : ICitizen, IRobot, IPet // наслідуємо методи з інтерфейсів
{
    public string? person;

    string? id;
    string? name;
    string? model;
    int? age;
    string? birthdate;

    public string? Name { get => name; set => name = value; }
    public string? Model { get => model; set => model = value; }
    public int? Age { get => age; set => age = value; }
    public string? Id { get => id; set => id = value; }
    public string? Birthdate { get => birthdate; set => birthdate = value; }

    public Person(   // заповнюжмо інформацію про людину
        string? person = null,
        string? id = null,
        string? birthdate = null,
        string? model = null,
        string? name = null,
        string? age = null
        )
    {
        this.person = person;

        Id = id;
        Birthdate = birthdate;
        Model = model;
        Name = name;
        Age = Convert.ToInt32(age);
    }


    public void InputPerson()
    {
        string? LineOnData = "";
        string?[] str;
        string? Birthdate = "";

        List<Person> persons = new();

        while (LineOnData?.ToLower() != "end") 
        {
            Console.Write("Data or end: ");
            LineOnData = Console.ReadLine();


            if (LineOnData?.ToLower() == "end") 
                break;  // після написання end перервати програму

            if (LineOnData != null)
            {
                str = LineOnData.Split(' ');


                if (str[0]?.ToLower() == "citizen") // після написання citizen додаємо в масив людину з повною інфою про неї
                    persons.Add(new Person(str[1])
                    {
                        person = str[0],
                        Name = str[1],
                        Age = Convert.ToInt32(str[2]),
                        Id = str[3],
                        Birthdate = str[4]
                    });
                else if (str[0]?.ToLower() == "robot") // після написання robot додаємо в масив робота з повною інфою про нього
                    persons.Add(new Person(str[2])
                    {
                        person = str[0],
                        Model = str[1],
                        Id = str[2]
                    });
                else if (str[0]?.ToLower() == "pet") // після написання pet додаємо в масив тваринки з повною інфою про неї
                    persons.Add(new Person(str[2]) 
                    { 
                        person = str[0], 
                        Name = str[1],
                        Birthdate = str[2]
                    });
            }
        }

        Console.Write("Year: "); // вивести рік народження
        Birthdate = Console.ReadLine();

        foreach (Person person in persons) // перерахувати людей в списку persons
        {
            string[] tempStr = { };
            if (person.Birthdate != null) // якщо рік не дорівнює нулю, вивести рік народження з врахуванням пробілів / або .
            {
                tempStr = person.Birthdate.Split('/', ' ', '.'); 
            }    
               

            foreach (string s in tempStr)
            {
                if (person.Birthdate != null && s == Birthdate) 
                {
                    Console.WriteLine("Birthdate: " + person.Birthdate); // вивести введену дату народження людини
                }
                   
            }
               
        }
    }
}