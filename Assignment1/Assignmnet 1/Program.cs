using Assignment1.content;

public class Program {

        private static FileService MainFile = new FileService(@"C:\Users\Crouc\Downloads\animals.txt");

        public static void Main(string[] args) {

            int Initialize = 1;

            Console.WriteLine("Did it without using the ArrayList, hope thats fine. It seemed better to me to do it this way");
            Console.WriteLine("The text file must be placed in downloads and the file location above must be updated to yours for it to work");

            while (Initialize == 1)
            {
                Console.WriteLine("1: Add Animal");
                Console.WriteLine("2: List Animals");
                Console.WriteLine("3: Exit");
                string UserInput = Console.ReadLine();

                if (UserInput == "1")
                {
                    AddAnimal();
                }

                else if (UserInput == "2")
                {
                    MainFile.FileRead();
                }

                else if (UserInput == "3")
                {
                    Initialize++;
                }
            }
        }

        public static void PrintOut(ITalkable p) {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            MainFile.FileWrite(p.GetName() + " | " + p.Talk());
        }


        public static void AddAnimal()
        {
            Console.WriteLine("Enter animal type: (Dog or Cat)");
            string AnimalType = Console.ReadLine();

            switch (AnimalType)
            {
                case "Dog":
                    Console.WriteLine("Name:");
                    string DogName = Console.ReadLine();
                    Console.WriteLine("Friendly (true/false):");
                    string FriendlyInput = Console.ReadLine();

                    try
                    {
                        bool DogFriendly;
                        if (FriendlyInput == "true")
                        {
                            DogFriendly = true;
                            PrintOut(new Dog(DogFriendly, DogName));
                        }
                        else if (FriendlyInput == "false")
                        {
                            DogFriendly = false;
                            PrintOut(new Dog(DogFriendly, DogName));
                        }
                        else
                        {
                            Console.WriteLine("Invalid data entered");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid data entered");
                    }
                    break;

                case "Cat":
                    Console.WriteLine("Name:");
                    string CatName = Console.ReadLine();
                    Console.WriteLine("Mouse Killed:");
                    string MouseKilledInput = Console.ReadLine();

                    try
                    {
                        int MouseKilled = Int32.Parse(MouseKilledInput);
                        PrintOut(new Cat(MouseKilled, CatName));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid data entered");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Type");
                    break;
            }
    }
    }