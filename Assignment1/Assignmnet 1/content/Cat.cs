namespace Assignment1.content
{
    public class Cat : Pet, ITalkable
    {
    public int MouseKilled { get; set; }

    public Cat(int mouseKilled, string name)
    {
        Name = name;
        MouseKilled = mouseKilled;
    }

    public int GetMouseKilled()
    {
        return MouseKilled;
    }

    public void AddMouse()
    {
        MouseKilled++;
    }

    public string Talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return "Cat: " + "name=" + Name + " mouseKilled=" + MouseKilled;
    }

    }

    
}