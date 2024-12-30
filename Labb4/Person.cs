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
    
}