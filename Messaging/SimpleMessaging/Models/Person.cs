namespace Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public void UpdateAge(int age) => Age = age;
        public void ChangeName(string name) => Name = name;
        public void ChangeLastName(string lastName) => LastName = lastName;

        public Person(int id, string name, string lastName, int age)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }

    public class FakePersonCollection
    {
        //DB yapmaya gerek duymadım "...mış gibi" yapıyorum
        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person(1,"Türkay","Ürkmez",42),
                new Person(2,"Bahar","Sarıoğuz",32),
                new Person(3,"Metali","Tekiz",38)
            };
        }
    }
}