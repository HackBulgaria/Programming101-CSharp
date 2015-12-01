# Introduction to OOP

## Time

In a Visual Studio project create a class `Time` to hold information about the current time and *the current date* .

Make an *easy-to-use* constructor (from client perspective), that would represent the time and date the client wants to hold in your class.

Implement the `ToString()` method, returning the time and date in format : "hh:mm:ss dd.MM.YY". 

*Bonus*
Make a factory method `Now()` for your class, returning the Time at the present moment :)

See http://en.wikipedia.org/wiki/Factory_method_pattern

## Pair

Make a class `Pair`, representing a pair of *Objects* (later we will revisit this with Generics)

Create properties for the first and second member of the pair.

Implement the ToString method, giving a meaningful representation of the class.
Override the equals method from Object => two pairs are equal if both their members are equal. Also define operators == and !=.
Override the `GetHashCode()` method:
```
public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + x.GetHashCode();
        hash = hash * 23 + y.GetHashCode();
        return hash;
    }
}
```

Make the class *immutable*.

## Fractions

In a Visual Studio project create a Fraction class. After creating the class write some test cases to demonstrate its functionality.
* Create a constructor with 2 arguments - the numerator and the denominator
    * if the denominator=0 the constructor should throw an exception: `throw new ArgumentException("Denominator cannot be 0")`
* Create properties for the numerator and denominator (when changing the denominator check for 0)
* Override `ToString()`: x/y
* Override `Equals()`
* define operators == and !=
* Override `GetHashCode()`:
```
public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + x.GetHashCode();
        hash = hash * 23 + y.GetHashCode();
        return hash;
    }
}
```
* define operators +, -, *, / between 2 Fractions
* define operators +, -, *, / between a Fraction and a double (return double)
* define explicit casting from Fraction to double

## Geometry Figures

Create a Visual Studio project GeometryFigures. After creating each class write some test cases to demonstrate its functionality.

### Point

Create an immutable class Point:

* Create a constructor with 2 arguments - the x and the y coordinate
* Create a default constructor which initializes the Point with the origin of the coordinate system
* Create a constructor that makes a copy of a Point
* Create 2 readonly properties for displaying the coordinates of the point
* Create a static readonly member for the origin of the coordinate system
* Override `ToString()` to return the coordinates of the point: Point(x,y)
* Override `Equals()`
* define operators == and !=
* Override `GetHashCode()`:
```
public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + x.GetHashCode();
        hash = hash * 23 + y.GetHashCode();
        return hash;
    }
}
```

### Line Segment

Create an immutable class LineSegment:
* Create a constructor with 2 arguments of type Point - the two ends of the line segment
  * if the points are equal the constructor should throw an exception: `throw new ArgumentException("Cannot create a line segment with zero length")`
* Create a constructor that makes a copy of a LineSegment
* Create 2 readonly properties for displaying the two ends of the segment
* Create a method `GetLength()`
* Override `ToString()`: Line[(x1,y1), (x2,y2)]
* Override `Equals()`
* define operators == and !=
* define operators <, >, <=, >= that compare two segments by their length
* define operators <, >, <=, >= that compare a segment and a given length
* Override `GetHashCode()`:
```
public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + Point1.GetHashCode();
        hash = hash * 23 + Point2.GetHashCode();
        return hash;
    }
}
```

Now go back to the Point class:
* define operator + with 2 Points that return a LineSegment

### Rectangle

Create an immutable class Rectangle:

* Create a constructor with 2 arguments of type Point - the points at the opposite vertices
  * if the points are on the same coordinate axis throw an exception
* Create a constructor that makes a copy of a Rectangle
* Create 4 readonly properties for displaying the 4 vertices of the rectangle (of type Point)
* Create 4 readonly properties for displaying the 4 edges of the rectangle (of type LineSegment)
* Create 2 readonly properties for dispalying the width and height of the rectangle
* Create a readonly property for displaying the center of the rectangle
* Create methods `GetPerimeter()`, `GetArea()`
* Override `ToString()`: Rectangle[(x,y), (height,width)]
* Override `Equals()`
* define operators == and !=
* Override `GetHashCode()`
