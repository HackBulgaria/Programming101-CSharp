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

You have to create a hierarchy of 2D shapes
