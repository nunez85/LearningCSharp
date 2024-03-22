
void One() => Console.WriteLine("One");
void Two() => Console.WriteLine("Two");
void Three() => Console.WriteLine("Three");

Example chain = One;
chain += Two;
chain += Three;
chain.Invoke();

// Deleting Two function
Console.WriteLine("Deleting Two lambda in the chain:");
chain -= Two;
chain.Invoke();

Console.WriteLine("Creating another chain:");
Example anotherChain = (Example)Two + Three;
anotherChain.Invoke();

Console.WriteLine("Creating a lambda chain:");
Example lambdaChain = () => Console.WriteLine("Hello!");
lambdaChain += () => Console.WriteLine("Good bye now :)");


// Needs to be all he way down for some reason
delegate void Example();