namespace Labb4;

class Program
{
    static void Main(string[] args)
    {
        
        //Lista
        List<Person> folk = new List<Person>();
        
        //Huvud-loop
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("1. Lägg till person");
            Console.WriteLine("2. Visa lista med personer");
            Console.WriteLine("3. Avsluta");
            Console.Write("Ditt val: ");
            string usersPick = Console.ReadLine();
            
            switch (usersPick)
            {
                case "1":

                    folk.Add(Person.AddPeople); 


                    /*
                    //Loop för att lägga till ytteliggare person, direkt.
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
                        
                        folk.Add(new Person(name, birthday, eyeColor, hair, gender));

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
                    }
                    */



                    break;


                case "2":
                    
                    if (folk.Count == 0)
                    {  
                        Console.Clear();
                        Console.WriteLine("Listan är tom.");
                        Thread.Sleep(1750);
                    }
                    else
                    {
                        foreach (var person in folk)
                        {
                            Console.WriteLine("\n" + person.ToString());
                            Console.WriteLine("\n-----------------------------------");
                        }
                    
                        Console.WriteLine("Tryck för att återgå till huvudmeny...");
                        Console.ReadKey();
                    }
                    break; 
                    
                
                case "3": 
                    
                    Console.WriteLine("\nDu valde att avsluta.");
                    Thread.Sleep(1250);
                    Console.Clear();
                    isRunning = false;
                    break;
                
                default:
                    Console.Write("Ogiltigt val, försök igen.");
                    Thread.Sleep(1750);
                    break;
                        
            }
        }

    }
}