namespace HashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table");
            Console.WriteLine("Enter options");
            Console.WriteLine("\nfor UC1 enter 1\nFor UC2 enter 2 ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {

                case 1:
                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                    hash.Add("0", "To");
                    hash.Add("1", "be");
                    hash.Add("2", "or");
                    hash.Add("3", "not");
                    hash.Add("4", "to");
                    hash.Add("5", "be");

                    Console.WriteLine(hash.GetV("0"));
                    Console.WriteLine(hash.GetV("1"));
                    Console.WriteLine(hash.GetV("2"));
                    Console.WriteLine(hash.GetV("3"));
                    Console.WriteLine(hash.GetV("4"));
                    Console.WriteLine(hash.GetV("5"));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("WEL-COME In Hash Table");
                    MyMapNode<string, string> hash1 = new MyMapNode<string, string>(20);
                    Console.WriteLine(hash1.IsEmpty());
                    hash1.Add("0", "Paranoids");
                    hash1.Add("1", "are");
                    hash1.Add("2", "not");
                    hash1.Add("3", "paranoid");
                    hash1.Add("4", "because");
                    hash1.Add("5", "they");
                    hash1.Add("6", "are");
                    hash1.Add("7", "paranoid");
                    hash1.Add("8", "but");
                    hash1.Add("9", "they");
                    hash1.Add("10", "keep");
                    hash1.Add("11", "putting");
                    hash1.Add("12", "themselves");
                    hash1.Add("13", "deliberately");
                    hash1.Add("14", "into");
                    hash1.Add("15", "paranoid");
                    hash1.Add("16", "avoidable");
                    hash1.Add("17", "situations");
                    Console.WriteLine(hash1.GetV("5"));
                    Console.WriteLine(hash1.GetV("0"));
                    Console.WriteLine($"size is: {hash1.Getsize()}");

                    string output = hash1.GetV("3");
                    int count = 0;
                    for (int i = 0; i < hash1.Getsize(); i++)
                    {
                        string temp = hash1.GetV($"{i}");
                        if (output == temp)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"frequency of {output} is : {count}");
                    Console.ReadLine();
                    break;
            }
        }
        
    }
}