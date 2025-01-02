namespace Labb4;

public class Person
{
    // Propertys till Personklassen
    public string Name { get; set; }
    public string Birthday { get; set; }
    public string EyeColor { get; set; }
    public Hair Hair { get; set; }
    public Gender Gender { get; set; }

    // En konstruktor
    public Person(string name, string birthday, string eyeColour, Hair hair, Gender gender)
    {
        Name = name;
        Birthday = birthday;
        EyeColor = eyeColour;
        Hair = hair;
        Gender = gender;

    }

    // Metod för att lägga till personer, tar en lista som parameter
    public static void AddPerson(List<Person> people)
    {
            //Loop för att lägga till ytterligare person, direkt.
            bool addOneMore = true;
            while (addOneMore)
            {
                Console.Clear();
                Console.WriteLine("Förnamn:");
                string name = Console.ReadLine();
                Console.WriteLine("Födelsedag: YYYY-MM-DD");
                string birthday = Console.ReadLine();
                Console.WriteLine("Ögonfärg:");
                string eyeColor = Console.ReadLine();
                Console.WriteLine("Hårfärg:");
                string hairColor = Console.ReadLine();
                

                // Här lägger vi in felhantering så man bara kan skriva in siffror
                int hairLenght = 0;
                bool hairTest = true;
                while (hairTest)
                {
                    Console.WriteLine("Hårlängd i cm: ");
                    string userhairLenght = Console.ReadLine();
                    if (int.TryParse(userhairLenght, out hairLenght))
                    {
                        hairTest = false;
                    }
                    else
                    {
                        Console.WriteLine("Mata in längden i centimeter, endast siffror.");
                    }
                }

                Console.WriteLine("Kön: (Man, Kvinna, IckeBinär, Annat)");
                string genderString = Console.ReadLine().ToUpper();
                // Vi deklarerar en enumtyp "gender" och tilldelar den "Annat". Om använadaren skriver något annat än vad som finns blir det "annat".   
                Gender gender = Gender.Annat;
                // Omvandla kön-sträng till enum och tilldelar den det relevanta könet.
                if (genderString == "Man")
                    gender = Gender.Man;
                else if (genderString == "Kvinna")
                    gender = Gender.Kvinna;
                else if (genderString == "IckeBinär")
                    gender = Gender.IckeBinär;

                // Skapar ett Hair-objekt av typen struct där vi lagrar hårdata. 
                Hair hair = new Hair(hairLenght, hairColor);
                // Vi lägger till personen i vår lista som vi skapade i main.
                people.Add(new Person(name, birthday, eyeColor, hair, gender));
                // Om man vill lägga till ännu en person.
                Console.WriteLine("Vill du lägga till en till person? Tryck J annars Enter");
                string yesOrNo = Console.ReadLine().ToUpper();
                if (yesOrNo == "J")
                {
                    addOneMore = true;
                }
                else
                {
                    addOneMore = false;
                }
            }
    }
    // Metod för utskrift. Vår "people" lista som parameter
    public static void ListPerson(List<Person> people)
    {
        Console.Clear();
        // Vi börja med att kolla om listan är tom
        if (people.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Listan är tom.");
            Thread.Sleep(1750);
        }
        else
        {
            // Vi skriver ut med hjälp av metoden "ToString"
            foreach (var person in people)
            {
                Console.WriteLine("\n" + person.ToString());
                Console.WriteLine("\n-----------------------------------");
            } 
            Console.WriteLine("\nTryck för att återgå till huvudmeny...");
            Console.ReadKey();
        }
    }
    // Metod för att skriva ut
    public override string ToString()
    {
        return "Namn: " + Name +
               "\nKön: " + Gender +
               "\nFödelsedag: " + Birthday +
               "\nÖgonfärg: " + EyeColor +
               "\nHårfärg: " + Hair.HairColor +
               "\nHårlängd: " + Hair.HairLength;
    }





}