# Class and Object

A class is a data structucture that contains a memberes (contants and field) and methods.  
A object is created from the class and can create a multiple object of a one class.

`class.cs`  Sample example code of class  and object

Here it is the detailed description of various data members and function methos used in the c# c.  

![](https://github.com/lallaw8809/c-Sharp/blob/main/imgs/class_object.png?raw=true)

Ref; https://www.tutlane.com/tutorial/csharp/csharp-classes-and-objects-with-examples#:~:text=In%20c%23%2C%20Classes%20and%20Objects%20are%20interrelated.%20The,class%20to%20access%20the%20defined%20properties%20and%20methods.

# Class modifier
Thease are the class modifiers in c#.

- public   
- protected  
- private  
- internal  
- abstarct   
- static   
- sealed   
- new  
- class_modifier_unsafe  

# Constructors
- A construct is a special method that is used to intitialize objects.
- It is a member of the class. The name of the constructor is same as the class name.
- A constructor is used to set the initial values for fields.

### Constructor overloading
It supports to have a different set of parameters, written a sample code in `constructorOverlaod.cs`

### Calling constructor
It will execute the calling contructor first and followed by execute the constructor.  

### static constructor
- A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only.
- A static constructor does not take access modifiers or have parameters
- A class can only have one static constructor.
- Static constructors cannot be inherited or overloaded.

`constructors.cs` Sample code of constructor class  
`constructorOverlaod.cs` Sample code for constructor overlad, calling constructor and static contructor.

# Static class

- A static class cannot be instantiated.
- Can not use a new operator to create a variable type of the class type (No instance variable).
- Contains only static members.
- Cannot contain Instance Constructors.
- It is sealed so we can not inheritance the static class

`staticClass.`  Sample example static code of class  

# Abstract class

- Abstract class is marked as a keyword `abstract` in the class definition and `abstarct` means that the class is incomplete and can not initialized. 
- Can not created a instace of this class but can be used in drived class.
- An abstract class cannot be sealed.

`abstract.cs` Showed a sample code that how to use the abstract class, virtual and override.  

# Inheritance

This method is used to inherit the field and method form one class to another.  
The inheritance symbol `:`    

Syntax
```sh
<access_modifier> class <base_class_name>
{
    // Base or parent class Implementation
}

<access_modifier> class <derived_class_name> : <base_class_name>
{
    // Derived or child class implementation
}
```

`inheritance.cs` Sample code of inheritance   
`multiInheritance.cs` Sample code of multi inheritance  

# Prpertoies

# Interface