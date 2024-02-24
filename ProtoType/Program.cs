using Newtonsoft.Json;

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
        return JsonConvert.DeserializeObject<Person>(JsonConvert.SerializeObject(this), deserializeSettings);
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.BirthDate = new DateTime(1986, 10, 10);
        person.Age = (new DateTime(1, 1, 1)  + (DateTime.Now - person.BirthDate)).Year;
        person.Name = "John Doe";
        Person person1 = person.ShallowCopy();
        person.Name = "Tony Stark";

        Console.WriteLine(person1.Name);

    }
}
