# Delegates

## Filters(selectors)

Write a method which takes as arguments a collection of integers
and a filter method which decides whether an element passes the
filter or not. Return the filtered collection.

Optional: make the method and the delegate generic so that they
can work with collections of any type (not just integers)

`List<int> FilterCollection(List<int> original, FilterDelegate filter)`

## Aggregates

Write a method which takes as arguments a collection of integers
and an aggregate method which defines a way to aggregate all the
integers into a single integer (possible aggregates are Sum, Product,
Average, Max, Min). Return the result of the aggregation.

`int AggregateCollection(List<int> original, AggregationDelegate aggregate)`

Optional: make the method and the delegate generic so that they
can work with collections of any type (not just integers)

## Bubble sort with a predicate

Rewrite your bubble sort extension method from week05 to take
as a parameter a delegate instead of an IComparer.

`Note`: the term `predicate` comes from the field of mathematical
logics and it basically means a function which returns true or false.
For example, `bool f(int x)` is a predicate on x.

# Events

## AverageAggregator

Create a class called AverageAggregator which can dynamically aggregate
numbers and retrieve their average. The class should have the following
members:

* read-only property decimal Average - returning the average of the currently added numbers
* a method void AddNumber(int number) - adds a new number and updates the average

Add an event to this class AverageChanged which fires only when the value of the Average
property has changed.
 
## INotifyPropertyChanged

Create a class of your choice with a few (3-5) properties. Implement
the INotifyPropertyChanged interface in your class. Create a collection
with several instances of your type and apply a few changes to some of them.
Print the hash code and the changed property of every item, 
using the PropertyChanged event.

## NotifyCollection

Create a class NotifyCollection (IList) with an event `CollectionChanged`
which fires every time something in the collection changes. Implement
proper event arguments which provide enough information for the change:
the type of the change (you can use enum), the changed item(s) index, etc.

The possible changes are: add(insert) item, remove item, replace item, 
change item's property.

`Hint`: to listen for property changes inside the items, the items must
implement the INotifyPropertyChanged interface. The collection should track
when items are entering/leaving the collection and subscribe/unsubscribe to 
their PropertyChanged event.

## Network receive buffer

When writing realtime networking applications, it is a common approach to
implement the following format of the streaming data: 

```
[2 bytes: length-of-message][length-of-message bytes: message]
[2 bytes: length-of-next-message]...
```

This is needed because the [transport layer](https://en.wikipedia.org/wiki/OSI_model) sometimes
decides to segment the data in a way that we cannot predict, and we might receive
a message in several chunks which we have to put together again after that. 

Your task is to write the ReceiveBuffer class which handles those chunks and restores
the original packages. It should have a single method `BytesReceived(byte[] data)`
and an event MessageReceived which fires when a message has been reconstructed.
Its event arguments should contain the UTF-8 decoded message.

To test the class, write another class PacketGenerator, which given a message,
converts it to a UTF-8 encoded byte array, appends the 2 bytes with its length at
its beginning, then splits the message at random points and sends the chunks to the
ReceiveBuffer class.

Subscribe to the event and print the received messages.

You will be using [TCP](https://en.wikipedia.org/wiki/Transmission_Control_Protocol), 
so you can count on the fact that packets arrive in the same
order they were sent and no packets will be lost.

The 2 bytes describing the length of the message are in [Big-Endian](https://en.wikipedia.org/wiki/Endianness) order.