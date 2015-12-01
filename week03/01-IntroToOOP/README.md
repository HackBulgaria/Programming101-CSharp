# Introduction to OOP

## Geometry Figures

Create a Visual Studio project GeometryFigures. After creating each class write some test cases to demonstrate its functionality.

### Point

Create an immutable class Point:

* Create a constructor with 2 arguments - the x and the y coordinate
* Create a default constructor which initializes the Point with the origin of the coordinate system
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

### Rectangle

Create an immutable class Rectangle:

* Create a constructor with 2 arguments of type Point - the points at the opposite vertices
  * if the points are on the same coordinate axis throw an exception
* Create 4 readonly properties for displaying the 4 vertices of the rectangle (of type Point)
* Create 4 readonly properties for displaying the 4 edges of the rectangle (of type LineSegment)
* Create 2 readonly properties for dispalying the width and height of the rectangle
* Create a readonly property for displaying the center of the rectangle
* Create methods `GetPerimeter()`, `GetArea()`
* Override `ToString()`: Rectangle[(x,y), (height,width)]
* Override `Equals()`
* define operators == and !=
* Override `GetHashCode()`
