# online-training-on-class-interface-and-oop


Goal of software engineering: 
We want to reduce the impact of change in our software. We need to design our classes such that a change in a class is isolated and has minimal impact on other classes in the system. With composition we encapsulate some common functionality and then we compose them together to create new classes. Diagram -&gt; Person has Animal, Dog has Animal (original design); Person has IWalkable, Dog has IWalkable, Goldfish has Animal; Goldfish has ISwimmable (design open for extension, closed for modification).

open closed principle (OCP) -
Software entities should be open for extension but closed for modification.

Not to apply this principle everywhere but there are areas in our system where we see there is potential for change like in a user notification module (send notification via mail, text or real time while users are online)

How to implement OCP using an interface:

Think of abstraction first, after the video encoder done encoding, we need to send out a notification. class vidio encoder does not know how the notification was implemented. So in this class we need to think of a notification channel as an abstraction and that's where an interface comes in. Because the interface is just a role, a contract.

e.g. Chef in a restaurant, John is the chef or Mary is if John is off. John or Mary will be the concrete class and the role Chef will be the interface.

** further study on the same topic

event and delegate

Unit Test:
- isolate the class using an interface; arrange some preconditions 
- act on a method
- do assertions

** Best practice on class design
- Whenever you have a class that has a list of objects of any type, always initialized that list to an empty list. You could run into NullReferenceException if you don't. If List<T> is not initialiezed, by default because it is a reference type, it was set to null. So when we call a method() on a null object we get NullReferenceException.
- Use object initializer to initialize properties or fields instead of overloading constructor() to do the same thing. And reserve constructors for scenarios where we really need to use them. Like an object cannot behave without being passed some initial values.
- signature of a method: name; number and type of parameters
- overloading methods: having a method with the same name but different signatures
- use params modifier for methods with varying number of parameters
- avoid design with ref modifier and out modifier
- use readonly modifier where you know that specific fields should be initialized only once (e.g. List&lt;Order&gt; Orders in Customer class). Side note: readonly field is set at run time; const field is set at compile time.
- in proj bin\Debug folder; type command ildasm proj.exe ; ildasm stands for il disassembler; how setter and getter were done behind the scene
- proper use of Indexer: same as property but declare with this[type varname] (e.g. public string this[string key]{ get; set; })
- use of dictionary(internal data structure: hash table); whenever you have a list of objects and you want to look them up by a key as opposed to an index, you use a dictionary; if you have a list of objects and you would like to look them up by index, you use a list.
- class inheritance: code reuse and polymophic behavior
- class composition: code reuse; flexibility; a means to loose-coupling

** Abstract class and abstract methods indicate they are missing the implementation and the implementation needs to be provided in the derived classes
- Do not include implementation
- If a member is declared as abstract, the containing class needs to be declared as abstract too.
- In derived classes, must implement all abstract members in the base abstract class.
- Abstract class cannot be instantiated.
- When you want to provide some common behaviour, while forcing other developers to follow your design.

** Sealed Modifier (the opposite of abstract)
- Prevents derivation of classes or overriding of methods
- Sealed classes are slightly faster because of some run-time optimizations.
- .NET class library e.g. string class

// using IEnumerable to return a read only list 
// so consumer of this class can NOT access the private field _task
// can only access the list via public Add() and Remove()
** IEnumerable vs. IQueryable
The main difference between “IEnumerable” and “IQueryable” is about where the filter logic is executed. One executes on the client side (in memory) and the other executes on the database.
