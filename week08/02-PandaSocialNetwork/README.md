# We are going to make a social networks for Pandas

This is the next big thing. We promise!

**Note:** In this exercise you should create unit tests for the different modules and classes.

## Panda

For our social network, we are going to need a `Panda` class which behaves like that:

```csharp
var ivo = new Panda("Ivo", "ivo@pandamail.com", GenderType.Male)

ivo.Name == "Ivo" // true
ivo.Email == "ivo@pandamail.com"  // true
ivo.Gender == GenderType.Male // true
ivo.IsMale == true // true
ivo.IsFemale == false // true
```

The `Panda` class also should be possible to:

* Be turned into a string
* Be hashed and used as a key in a dictionary
* Make sure that the email is a valid email (make a very basic check for `@` and `.`)

Two `Panda` instances are equal if they have matching `Name`, `Email` and `Gender` properties.

## SocialNetwork

Now it is time for our social network!

Implement a class, called `PandaSocialNetwork`, which has the following public methods:

* `AddPanda(panda)` - this method adds a `panda` to the social network. The panda has 0 friends for now. If the panda is already in the network, throw an `PandaAlreadyThereException` error.
* `HasPanda(panda)` - returns `true` or `false` if the `panda` is in the network or not.
* `MakeFriends(panda1, panda2)` - makes the two pandas friends. Throw `PandasAlreadyFriendsException` if they are already friends. **The friendship is two-ways** - `panda1` is a friend with `panda2` and `panda2` is a friend with `panda1`. **If `panda1` or `panda2` are not members of the network, add them!**
* `AreFriends(panda1, panda2)` - returns `true` if the pandas are friends. Otherwise, `false`
* `FriendsOf(panda)` - returns a list of `Panda` with the friends of the given `panda`. Returns `false` if the `panda` is not a member of the network.
* `ConnectionLevel(panda1, panda2)` - returns the connection level between `panda1` and `panda2`. If they are friends, the level is 1. Otherwise, count the number of friends you need to go through from `panda` in order to get to `panda2`. If they are not connected at all, return `-1` or one of the pandas are not member of the network.
* `AreConnected(panda1, panda2)` - return `true` if the pandas are connected somehow, between friends, or `false` otherwise.
* `HowManyGenderInNetwork(level, panda, gender)` - returns the number of `gender` pandas (male of female) that in the `panda` network in that many  `level`s deep. If `level == 2`, we will have to look in all friends of `panda` and all of their friends too. And count

## An example

```csharp
var network = new PandaSocialNetwork()
ivo = new Panda("Ivo", "ivo@pandamail.com", GenderType.Male)
rado = new Panda("Rado", "rado@pandamail.com", GenderType.Male)
tony = new Panda("Tony", "tony@pandamail.com", GenderType.Female)

network.AddPanda(ivo)
network.AddPanda(rado)
network.AddPanda(tony)

network.MakeFriends(ivo, rado)
network.MakeFriends(rado, tony)

network.ConnectionLevel(ivo, rado) == 1 // true
network.ConnectionLevel(ivo, tony) == 2 // true

network.HowManyGenderInNetwork(1, rado, GenderType.Female) == 1 // true
```

## Save and load

We want to be able to save and load our social network in different formats and sources (in a file, in a database etc). For that purpose create an interface `IPandaSocialNetworkStorageProvider` with two methods `void Save(PandaSocialNetwork network)` and `PandaSocialNetwork Load()`.

### Save and load from file

Implement `IPandaSocialNetworkStorageProvider` for saving and loading a panda network in a file

If you use the .Net builtin serialization keep in mind that the binary serializer saves also the private fields whereas the xml serializer saves only the public ones.

**Tip:** it is a good idea to implement each storage provider in a separate project (so that if you decide to add a new one you won't need to change the main project)

## Console interface

Create a console interface for working with the panda network. It should support all operations in the `PandaSocialNetwork` class as well as saving and loading it.

