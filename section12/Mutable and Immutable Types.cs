/*Mutable Types:
• Mutable types are types whose instances can be
modified after they are created.
• Characteristics: Properties or fields of a mutable
type can be changed.
• Changes to an instance affect the state of that
instance.
• Examples include classes, arrays, and custom objects
where properties can be modified.





Immutable Types:
• Immutable types are types whose instances cannot
be modified after they are created.
• Characteristics: Properties or fields of an immutable
type cannot be changed after the instance is created.
• Any operation that appears to modify the instance
actually returns a new instance with the desired
changes.
• Examples include strings, tuples, and some built-in
value types.
• Another Example a Person Class that has everything as
ready only.






Pros and Cons:
Mutable Types:
• Pros:
• More flexible for certain scenarios.
• Can be more memory-efficient if state changes frequently.
• Cons:
• Prone to unintended side effects.
• May require additional effort to maintain consistency.
Immutable Types:
• Pros:
• Safer and less error-prone since instances cannot be modified.
• Easier to reason about and maintain.
• Cons:
• Creating a new instance for each modification
• Can be less memory-efficient for certain scenarios.




//expamble 

String is Immutable
        string str1 = "Hello";  // Object جديد في الـ Heap
        string str2 = str1;     // str2 تشير لنفس الـ object
        Console.WriteLine("Before change:");
        Console.WriteLine($"str1 = {str1}");  // Hello
        Console.WriteLine($"str2 = {str2}");  // Hello
        // الآن نعدل str2
        str2 = str2 + " World"; 
        Console.WriteLine("\nAfter change:");
        Console.WriteLine($"str1 = {str1}");  // Hello → ما اتغيرتش
        Console.WriteLine($"str2 = {str2}");  // Hello World → اتغيرت
stringلان أي تعديل على 
objectينتج 
Heap جديد في الـ






string s1 = "Hello";
string s2 = s1;//create new object
s1 = "World";

Console.WriteLine(s2);//print Hello





*/