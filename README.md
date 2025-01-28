# Abstract classes
An introduction to abstract classes and virtual methods etc

### What Is an Abstract Class?
An abstract class in C# is a special type of class that cannot be instantiated directly. It is designed to serve as a blueprint for other classes to inherit from.

You can think of an abstract class as laying out the foundation for certain behaviors, but not providing all the details of how those behaviors work.

### Key Characteristics
1. Cannot Create Objects
    * You cannot do new SomeAbstractClass() to instantiate an abstract class directly. Instead, you must inherit from it in a non-abstract (concrete) class.
2. Can Contain Abstract Methods
    * An abstract method is declared inside an abstract class with no method body (no implementation).
    * Any non-abstract class that inherits from this abstract class must override and provide the implementation for these abstract methods.
3. Can Have Regular Methods and Properties
    * Apart from abstract members, an abstract class can also contain fully implemented methods, properties, or fields. This can help avoid repeating common code in multiple subclasses.

### Why Use Abstract Classes?
1. Shared Behavior / Inheritance
    * If you have several closely related classes that share some methods or properties, you can put the common logic in the abstract class.
    * Each subclass then inherits this code, keeping it DRY (Don’t Repeat Yourself).
2. Enforce Certain Methods
    * By declaring abstract methods, you force the subclasses to implement those methods, ensuring a consistent interface.
3. Partial Implementation
 * You can implement some general functionality in the abstract class, while leaving specific details to the subclasses.

### When to Choose Abstract Classes vs. Interfaces
* Abstract Classes
    * Use when you have partial implementations or shared code that multiple related classes can inherit.
    * You can include both abstract and regular methods.

* Interfaces
    * Use to define a contract (only method/property signatures, no common code).
    * Useful when you need to represent “capabilities” across otherwise unrelated classes.

### Summary
* Abstract classes are a way to enforce certain methods or properties in subclasses while also providing optional shared implementations.
* They cannot be instantiated directly.
* Abstract methods in these classes have no body and must be implemented by subclasses.
* Regular methods can also be included, providing a convenient way to share common logic.
* This helps keep your code organized, ensures consistent behavior across different but related classes, and reduces repetition.

By understanding abstract classes, you’ll be able to design your C# applications with more flexible and maintainable architectures, leveraging inheritance where it truly makes sense.

# Virtual methods
### What Is a Virtual Method?
A virtual method in C# is a method in a base class that you can override in a derived class. This provides a way to change or extend the behavior of a base class method in child classes, without modifying the base class itself.

### Key Characteristics
1. Defined in a Base Class
    * You mark a method in the base class with the keyword virtual.

2. Optionally Overridden in Derived Classes
    * In a derived (child) class, you can use the override keyword to change how that method works.

3. Method Resolution at Runtime
    * C# uses the concept of dynamic dispatch. This means when you call a virtual method on an object, the most derived implementation of that method is used at runtime.
### Why Use Virtual Methods?
1. Extensibility
    * Virtual methods let you extend or modify functionality in child classes without altering the base class code.

2. Polymorphism
    * One of the pillars of Object-Oriented Programming (OOP) is polymorphism. Virtual methods are part of how polymorphism is implemented in C#. If multiple classes inherit from the same base class, each can provide its own specialized version of a virtual method.
3. Cleaner Code
    * You avoid duplicating code in multiple classes and keep shared behavior in the base class, customizing only the parts that need to be different in child classes.

### Virtual vs. Abstract vs. Sealed
* Virtual Method:
    * Has an implementation in the base class and can be overridden in a derived class.
    * It’s optional to override it in a derived class—if you don’t override, you get the base behavior.

* Abstract Method:
    * Declared in an abstract class. No implementation in the base class (just the signature).
    * Must be overridden in a derived class.

* Sealed Method:
    * Prevents further overriding in subclasses. For example, you can override a virtual method and then mark it as sealed to stop the chain of overrides.