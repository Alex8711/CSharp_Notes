class Program
{
    static void Main(string[] args)
    {
        //============================================================== 


        Student student1 = new Student("Sophie");
        Student student2 = new Student("Claire");
        Teacher teacher1 = new Teacher("James");
        Teacher teacher2 = new Teacher("Warren");
        Programmer programmer1 = new Programmer("Tom");
        Programmer programmer2 = new Programmer("Brad");
        Person[] people = { student1, student2, teacher1, teacher2, programmer1, programmer2 };
        for (int i = 0; i < people.Length; i++)
        {
            people[i].SayHello();
        }
        // The out put is 
        // Hello, I am Person 
        // Hello, I am Person
        // Hello, I am Person
        // Hello, I am Person
        // Hello, I am Person
        // Hello, I am Person
        //==================================================================
        // This not we want!!
        // replace for loop by following code
        for (int i = 0; i < people.Length; i++)
        {
            if (people[i] is Student)
            {
                ((Student)people[i]).SayHello();
            }
            if (people[i] is Teacher)
            {
                ((Teacher)people[i]).SayHello();
            }
            if (people[i] is Programmer)
            {
                ((Programmer)people[i]).SayHello();
            }
        }
        // the output would like this, perfect!!!
        // Hello, I am a Student
        // Hello, I am a Student
        // Hello, I am a Teacher
        // Hello, I am a Teacher
        // Hello, I am a Programmer
        // Hello, I am a Programmer
        //===========================================================
        // It is still verbose!!!
        // Now let's use virtual to do some magic
        // first add virtual to the base class's SayHello(); 
        // second add override to the derived class's SayHello(); 
        // like this
        public virtual void SayHello()
    {
        System.Console.WriteLine("Hello, I am Person");
    }

    public override void SayHello()
    {
        System.Console.WriteLine("Hello, I am a Student");
    }
    // and then change for loop back to the simple one
    // like this
       for (int i = 0; i<people.Length; i++)
            {
               people[i].SayHello();
}
    //----Run program, the output will be 
    //     Hello, I am a Student
    // Hello, I am a Student
    // Hello, I am a Teacher
    // Hello, I am a Teacher
    // Hello, I am a Programmer
    // Hello, I am a Programmer
    // perfect. Acutally people[i].SayHello() is still calling the SayHello() from base class. But it is override by the derived class. 
}


public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        this.Name = name;
    }
    public void SayHello()
    {
        System.Console.WriteLine("Hello, I am Person");
    }


}


public class Student : Person
{
    public Student(string name) : base(name)
    {

    }
    public void SayHello()
    {
        System.Console.WriteLine("Hello, I am a Student");
    }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {

    }
    public void SayHello()
    {
        System.Console.WriteLine("Hello, I am a Teacher");
    }
}
public class Programmer : Person
{
    public Programmer(string name) : base(name)
    {

    }
    public void SayHello()
    {
        System.Console.WriteLine("Hello, I am a Programmer");
    }
}
}



