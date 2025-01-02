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
                    
                    Person.AddPerson(folk);
                    break;
                
                case "2":

                    Person.ListPerson(folk);
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