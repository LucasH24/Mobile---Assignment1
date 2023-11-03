namespace Assignment1.content
{
    public class Dog : Pet, ITalkable
    {
    public bool Friendly { get; set; }

    public Dog(bool friendly, string name)
    {
        Name = name;
        Friendly = friendly;
    }

    public bool IsFriendly()
    {
        return Friendly;
    }

    public string Talk()
    {
        return "Bark";
    }

    public override string ToString()
    {
        return "Dog: " + "name=" + Name + " friendly=" + Friendly;
    }

    }

    
}