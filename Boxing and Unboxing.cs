// Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. 
// Unboxing extracts the value type from the object.

class Program
{

    static void Main(string[] args)
    {
        int n = 10;
        object obj = n; //boxing
        int nn = (int)obj; // unboxing

        ArrayList list = new ArrayList();
        // list.Add(object value)
        list.Add(5);   // automatic boxing
                       //to increase efficiency, we can use List<int> to add integer

    }

}