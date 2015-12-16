# Inheritance problems

## Fast and Furious
Make a class Car. 
Make subtypes of Car, representing the following brands of cars: Audi, BMW, Volkswagen, Honda and Skoda.

Each subtype should have a method `bool IsEcoFriendly(bool testing)`, which does the following:
- For a Volkswagen car, if `testing` is `true`, it should return `true`. Return `false` otherwise.
- For any other car, return `true`.

Later, for the Audi, BMW and Volkswagen types you need to return their mileage, because all the German brand manufacturers require it - how will you do it?

## Animals
You should create a class hierarchy for Animals. All animals can move, eat, give birth. Animals can be mammals, reptiles, fish, birds. All land animals can greet (make sounds). Birds make nests, reptiles don't have constant temperature. Implement the following animals - cat, dog, crocodile, owl, shark.

Implement all methods and properties as returning a string describing the behaviour of the animal, for example `cat.Greet()` should return "Meow".

Make the appropriate classes abstract.

Test the hierarchy by creating a list of animals `List<Animal> animals` and populating it with various animals. After that iterate through the collection and output their behaviour.

## Person

Create a class Person. Each person has a gender and does daily stuff. What children do daily is play, and adults go to work. Adults can have one or more children. Children can have several toys. Toys have a colour and size.

Override the ToString() method for each class. Should any of the classes be abstract?

Test the hierarchy by creating a list of people and iterating through the collection and outputing their behaviour.

Some adults are boring, so add a property for them checking whether they are boring or not. How will you do it considering there a lot of other things that may be boring too.

## Shapes

You have to create a hierarchy of 2D shapes.

* Create a class `Point` with 2 coordinates.
* Create an abstract class `Shape` with methods `GetPerimeter()`, `GetArea()` (point is not a shape).
* Create a class `Rectangle` with properties `Width`, `Height`, `Center`. Create an inherited class `Square` with a property `Side`. `Square` should make sure that its width and height are equal (whenever one of them changes the other one should also change).
* Create a class `Ellipse` with properties `RadiusX`, `RadiusY` (the semi-axes `a` and `b` from [here](https://en.wikipedia.org/wiki/Ellipse#Elements_of_an_ellipse)), `Center`. Create an inherited class `Circle` with a property `Radius`. `Circle` should make sure that its semi-axes are equal (whenever one of them changes the other one should also change).
* Create a class `Triangle` with properties `Vertex1`, `Vertex2`, `Vertex3`.

Override ToString() method for all classes.

Now create an interface `IMovable` with a method `Move(x, y)` that moves an object along th x and y axes. Implement it in `Point` and `Shape` and its subclasses.

### Bonus - Display the shapes

For the Shapes problem above create an interface `IDisplayable` with property `System.Drawing.Color Color{get;set;}` and method `void Draw(System.Drawing.Graphics g)` that describes the color of an object and draws it on a graphics object (see [System.Drawing.Color](https://msdn.microsoft.com/en-us/library/system.drawing.color%28v=vs.110%29.aspx) and [System.Drawing.Graphics](https://msdn.microsoft.com/en-us/library/system.drawing.graphics%28v=vs.110%29.aspx)). Implement the interface in `Shape` and its subclasses.

Create a Windows Forms desktop application that draws shapes on a surface.
