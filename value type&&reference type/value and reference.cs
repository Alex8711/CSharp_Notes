class Program
{
 
     static void Main(string[] args)
     {
            // value type
    // int double char decimal bool enum struct
         int n1=10;
         int n2=n1;
         n2=20;
         System.Console.WriteLine(n1);  // 10
         System.Console.WriteLine(n2);  // 20

                     // reference type
    // string array class collection object interface
         Person p1 = new Person();
         p1.Name="Alex";
         Person p2 = p1;
         p2.Name = "Brad";
         System.Console.WriteLine(p1.name); // Brad
     }
   // string is a little bit strange. Because it is immutable
            string s1 = "abc";
            string s2 = s1;
            Console.WriteLine($"s1 is {s1}");// s1 is abc
            Console.WriteLine($"s2 is {s2}");// s2 is abc
            Console.WriteLine("change s1");

            s2 = "def";
            Console.WriteLine($"s1 is {s1}");//s1 is abc
            Console.WriteLine($"s2 is {s2}");//s2 is def
}