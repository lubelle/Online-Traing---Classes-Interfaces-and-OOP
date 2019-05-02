# online-training-on-class-interface-and-oop


Goal of software engineering: 
We want to reduce the impact of change in our software.

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
- 

  
