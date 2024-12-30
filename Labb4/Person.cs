namespace Labb4;

public class Person
{
    
    public string Name { get; set; }
    public string Birthday { get; set; }
    public string EyeColour { get; set; }
    public Hair Hair { get; set; }
    public Gender Gender { get; set; }
    
    
    public Person(string name, string birthday, string eyeColour, Hair hair, Gender gender)
    {
        Name = name;
        Birthday = birthday;
        EyeColour = eyeColour;
        Hair = hair;
        Gender = gender;

    }
    
    public override string ToString()
    {
        return "Namn: " + Name + 
               "\nKön: " + Gender + 
               "\nFödelsedag: " + Birthday + 
               "\nÖgonfärg: " + EyeColour +
               "\nHårfärg: " + Hair.HairColor + 
               "\nHårlängd: " + Hair.HairLength;
    }

    public static List<Person> AddPeople(<List> persons) 
    {
        bool addOneMore = true;
        while (addOneMore)
        {
            Console.Clear();
            Console.WriteLine("Namn:");
            string name = Console.ReadLine();
            Console.WriteLine("Födelsedag: YYYY-MM-DD");
            string birthday = Console.ReadLine();
            Console.WriteLine("Ögonfärg:");
            string eyeColor = Console.ReadLine();
            Console.WriteLine("Hårfärg:");
            string hairColor = Console.ReadLine();

            int hairLenght = 0;
            bool hairTest = true;
            while (hairTest)
            {
                Console.WriteLine("Hårlängd: (tex. 40)");
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

            Console.WriteLine("Kön: (Male, Female, Other, Non-Binary)");
            string genderString = Console.ReadLine().ToUpper();
            Gender gender = Gender.Other;
            // Omvandla kön-sträng till enum
            if (genderString == "MALE")
                gender = Gender.Male;
            else if (genderString == "FEMALE")
                gender = Gender.Female;
            else if (genderString == "NON-BINARY")
                gender = Gender.NoneBinary;

            // Skapa ett nytt Hair-objekt
            Hair hair = new Hair(hairLenght, hairColor);

            persons.Add(new Person(name, birthday, eyeColor, hair, gender));

            Console.WriteLine("Vill du lägga till en till person? JA/NEJ");
            string yesOrNo = Console.ReadLine().ToUpper();
            if (yesOrNo == "JA")
            {
                addOneMore = true;
            }
            else
            {
                addOneMore = false;
            }
            return folk;
    }
    
}