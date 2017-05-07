
Mixin Class Defined<br/>
"A mixin class is a class that's intended to provide an optional interface<br/>
or functionality to other classes. It's similar to an abstract class in that it's not<br/>
intended to be instantiated. Mixin classes require multiple inheritance."<br/>
Gamma et al., Design Patterns: Elements of Reusable Object-Oriented Software<br/>

Mixins in .NET<br/>
-.NET languages do not support multiple class inheritance<br/>
  Mixin can be an interface<br/>
- A class can implement interfaces even when it has a base class<br/>
  Existing class can also be an interface<br/>
  
Is Mixin a Pattern?<br/>
-"Each pattern describes a problem which occurs over and over again<br/>
  in our environment, and then describes the core of the solution to that problem,<br/>
  in such a way that you can use this solution a million times over,<br/>
  without ever doing it the same way twice."<br/>
  Alexander et al., A Pattern Language<br/>
  
-Is Mixin a Pattern?<br/>
 Does the language support Mixins natively?<br/>
- Common Lisp has an idiomatic implementation of Mixins<br/>
- C++ supports multiple class inheritance<br/>
 Mixins in C#<br/>
- Not supported out of the box<br/>
- Used in a way characteristic to patterns<br/>

Implementing Mixins in C#<br/>
 Aspect-oriented frameworks<br/>
- Intention to mix interfaces is expressed using attributes<br/>
• Beware of strange solutions in these frameworks<br/>
- Frameworks add complexity to the project<br/>
• Make sure that added complexity pays off<br/>
 Using extension methods<br/>
- New method is added to the original class<br/>
- Extension method acts as any other method defined on the class<br/>
• Extension method can only see public members of the class<br/>
 The goal of this module<br/>
- Implement a simple solution<br/>
- Intentions must be clearly indicated in code<br/>
