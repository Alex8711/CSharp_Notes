// The Liskov Substitution Principle says that 
// the object of a derived class should be able to replace 
// an object of the base class without bringing any errors 
// in the system or modifying the behavior of the base class.
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();

        Person p1 = new Student();

        Console.ReadKey();
    }
}

class Person
{


    public Person()
    {
        Console.WriteLine("This is Person's Constructor，I am a Person!");
    }

    public void PersonSayHello()
    {
        Console.WriteLine("Hello,I am a Person!!!");
    }

}

class Student : Person
{
    public Student()
    {
        Console.WriteLine("This is Student's Constructor，I am a Student!");
    }

    public void StudentSayHello()
    {
        Console.WriteLine("Hello,I am a Student!");
    }
}


// when we run the program, the output is 
// This is Person's Constructor，I am a Person!
// This is Person's Constructor，I am a Person!
// This is Student's Constructor，I am a Student!
// when derived class instantiates an instance, it will call base class's constructor.
// By doing this, the derived class instance can inherit properties and methods from base class.
// Now we add some code to the Main() function
// add p.
static void Main(string[] args)
{
    Person p = new Person();
    p.PersonSayHello();

    Person p1 = new Student();
    p1.PersonSayHello();
}
// then we found only p1 can only call PersonSayHello() and p1 can not call StudentSayHello().

//now please look at the liskov.png
// that's why p1 can only call the method from base class!

// try following code in the Main() function
Student s1 = p;   //you will get error

// However, if we want p1 to call StudentSayHello(), we can convert the type
((Student)p1).StudentSayHello();
((Student)p1).PersonSayHello();
// these will work!!!

// Another method---- we can use virtual and overide to do it
// first- add virtual to the Person class's PersonSayHello()
// // like this
public virtual void PersonSayHello()
{
    Console.WriteLine("Hello,I am a Person!!!");
}

//second - go to Student class, add following code
// // like this
public override void PersonSayHello()
{
    Console.WriteLine("Hello,I am a Student!!!");
}

// Now, let's call p1.PersonSayHello();
// the output is 
// Hello,I am a Student!!!

//personal thoughts about this
// I think p1 is neither a Person type nor a Student type.
// p1 is declared as a Person type and have properties of Person type, but it occupied memory space from Student class.
// p1 will call derived class's method IF the method is override

// weird?  Maybe. But we are using it very often;
// check string.Join() method
// public static string Join (char separator, params object[]? values);
// string.Join("|", new string[]{"1","2","3","4"});
// we assign the object[] with a string[], LOL



// let's go to virtual method.cs