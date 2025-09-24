using HelloWorld;

String nameInput;
String birthdayInput;
Console.WriteLine("Hola, bienvenido al calculador de edad");
Console.WriteLine("escribe tu nombre: ");
nameInput = Console.ReadLine();
Console.WriteLine($"un gusto conocerte {nameInput}");
Console.WriteLine("escribe tu fecha de nacimiento en formato dd/mm/yy");
birthdayInput = Console.ReadLine();
DateOnly dateConverted = new DateOnly();
bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
if (!isDateValid)
    Console.WriteLine($"La fecha de nacimiento es invalida, datos erroneos: {birthdayInput}");

var person = new Person
{
    name = nameInput,
    birthday = dateConverted,
    age = DateTime.Now.Year - dateConverted.Year
};
Console.WriteLine($"tu nombre: {nameInput}");
Console.WriteLine($"tu fecha de nacimiento: {person.birthday}");
Console.WriteLine($"tu edad: {person.age}");






Console.WriteLine();
namespace HelloWorld
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public DateOnly birthday;
    }
}

