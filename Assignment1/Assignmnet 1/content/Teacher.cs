namespace Assignment1.content
{
    public class Teacher : Person, ITalkable
    {
        public int Age { get; set; }

        public Teacher(int age, string name)
        {
            Name = name;
            Age = age;
        }

        public string Talk()
        {
            return "Dont forget to do the assigned reading";
        }

        public override string ToString()
        {
            return "Teacher: " + "name=" + Name + " age=" + Age;
        }
    }

}