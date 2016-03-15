# Reflection

## Incrementable
Create a custom attribute class `IncrementableAttribute`.

Create an extension method of `object` that:
* if the class of the object is marked with `Incrementable` then iterate through all its int public properties (that have both getter and setter) and increment them by 1
* otherwise iterate through all public properties of the object (that have both getter and setter) marked with the `Incrementable` attribute and increments them by 1. If the property is not of type int throw an exception.

Create some classes to test the above extension method
