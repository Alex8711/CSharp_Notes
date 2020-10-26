//Inheritance

//1-the derived class inherit the base class's properties and methods excepts the private members
//2-the derived class doesnt inherit the constructor from base class
//  but the derived class will call base class's non-parameters constructor by default to create a (Base Class) Object.
//  then the derived class object can use base class's properties and methods!!
//  **However if we write  a constructor with parameters in the base class, then the derived class can not call non-parameters constructor by default.
//  **solution-1, write a non-parameter constructor in the base class
//  **solution-2, call the base class's constructor with base()  in the derived class

// new--  can hides an accessible base class method.(same signature)


// feature of Inheritance
//1-  a derived class can have ONLY ONE base class!!!(one baby can only have one biological father!)
//2-