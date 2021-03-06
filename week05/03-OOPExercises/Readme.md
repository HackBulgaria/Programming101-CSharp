# Dungeons and Lizards

We are going to make a simple, 2D turn-based console game filled with dungeons and lizards!

We are going to have hero, enemies, weapons, treasures and magic!

So lets start with the basic stuff:

## Our Hero

Make a `Hero` class which can be initialized by that (all constructor arguments are shown in the example):

```CSharp
var hero = new Hero("Bron", "Dragonslayer", 100, 100, 2); \\ name, class, health, mana, manaRegenerationRate
```

Our hero should have the following methods:

### `KnownAs()` method

Add a `KnownAs()` method to our Hero, which returns a string, formatted in the following way:
`"{hero.name} the {hero.title}"`

__For example:__

```CSharp
>>> h.KnownAs()
Bron the DragonSlayer
```

### `GetHealth()` and `GetMana()` and `IsAlive()` and `CanCast()`

Every hero starts with the given `health` and `mana` points.

__Those `health` and `mana` points are the maximum health and mana for the hero!__

* When a hero reaches 0 `health` he is considered death.
* When a hero reaches 0 `mana`, he cannot cast any spells

Implement the following methods:

* `IsAlive()` which returns `True`, if our hero is still alive. Otherwise - `False`.
* `GetHealth()` which returns the current `health`
* `GetMana()` which returns the current `mana`
* `CanCast()` which returns `True`, if our hero can cast the magic he has been given. Otherwise - `False`

### `TakeDamage(int damagePoints)`

So, our hero can take damage which reduces his health.

Implement a method, called `TakeDamage(int damagePoints)` where damage can be either integer or floating point value.

This method should reduce the hero's health by `damage`

__If we inflict more damage than we have health, health will always be equal to zero and we cannot get below that!__

### `TakeHealing(int healingPoints)`

Our hero can also be healed!

Implement a method, called `TakeHealing(int healingPoints)` which heals our hero.

Here are the requirements:

* If our hero is dead, the method should return `False`. It's too late to heal our hero
* We cannot heal our hero above the maximum health, which is given by `health`
* If healing is successful (Our hero is not dead), the method should return `True`

### `TakeMana(int manaPoints)`

Our hero can also increase his mana in two ways:

* Each time he makes a move, his `mana` is increased by `manaRegenerationRate` amount.
* He can drink a mana potion, which will increse his mana by the amount of mana points the potion have.

**Hero's mana cannot go above the start `mana` given to him, neither he can go down below 0 mana.**

### `Equip(Weapon weapon)` method

Our hero can equip one weapon and one spell in order to have damage.

Check the weapon example for more information.

### `Learn(Spell spell)` method

The same as `equip`, but takes a `Spell` class.

Our hero can learn only 1 spell at a time.

If you learn a given spell, and after this learn another one, the hero can use only the latest.

### `Attack()` method

The method should return the demage done either from the weapon or from the spell (more on that, later)

If the hero has not been equiped with weapon or he has no spells, his attack points are 0.

The method can be called in two ways:

* `Attack(Weapon weapon)` - returns the damage of the weapon if equiped or 0 otherwise
* `Attack(Magic magic)` - returns the damage of the spell, if quiped or 0 otherwise

## The Enemies

Implement a class `Enemy` which is initialized like that:

```CSharp
var enemy = Enemy(100, 100, 20); // health, mana, damage
```

The `Enemy` should have the following methods, just like our hero:

* `IsAlive()`
* `CanCast()`
* `GetHealth()`
* `GetMana()`
* `TakeHealing()`
* `TakeMana()`
* `Attack()`
* `TakeDamage(int damage)`

* **Enemies cannot regenerate mana!**
* **Enemies have starting damage, which is different from a weapon or a spell. They can equip weapons or learn spells but it is not required for them to have any damage, as it is for our hero.**

## The weapons and spells

In order for our hero to have proper damage, he must be equiped with either a weapon or a spell.

One hero can carry at max 1 weapon and 1 spell.

### Weapon class

Implement a simple class `Weapon` which behave like that:

```CSharp
var h = new Hero("Bron", "Dragonslayer", 100, 100, 2); // health=100, mana=100, mana_regeneration_rate=2
var w = new Weapon("The Axe of Destiny", 20); // damage=20

h.equip(w);

if(h.attack(w) == 20){
// bla bla
}
```

### Spell class

This should be more complex. Implement a spell class, which behaves like that:

```CSharp
var s = Spell("Fireball", 30, 50, 2) // name, damage, manaCost, castRange
```

`Name` and `Damage` are self explanatory.

* `ManaCost` means that the spell needs at least that much amount of mana in order to be casted. Raise an error if you cannot cast that spell.
* `CastRange` is a bit more special and related to the Dungeon. You can cast that spell on an enemy, which is within the `CastRange`. If `CastRange` is 1, you can attack enemies, that are next to you. If cast range is greater than 1, you can attack enemies from distance, that is `CastRange` squares away. **Casting range is only calculated in a straight line. You cannot curve spells**

## The Dungeons and treasures

We are going to need a dungeon, where our hero can fight his enemies and find powerful weapons and spells!

Our dungeon is going to be a 2D map that looks like that:

```
S.##.....T
#T##..###.
#.###E###E
#.E...###.
###T#####G
```

Where:

* `S` means a starting point for our hero.
* `G` means gateway - the end of the dungeon (and most propably the enter to another)
* `#` is an obstacle
* `.` is a walkable path.
* `T` is a treasure that can be either mana, health, weapon or spell
* `E` is an enemy that our hero can fight

We are going to load the layout of our map from a file. For example, the map above can be located in a filed called `level1.txt`

We create new dungeon like this:

Our `Dungeon` should have the following methods:

### `PrintMap()`

This should print the map to the console. Check the example above.

### `Spawn`

We want to spawn our hero in the `S` location of the map.

Implement a method, called `Spawn(Hero hero)` where:

* `hero` is a `Hero` instance

This one takes the first free spawning point in the map and populates it with `H`.

The first free spawning point is the one, that we get if we start from top-left and walk right.

If the spawning is successful - return True. Otherwise (If there are no more spawning points, return False)

**If our hero dies, he can respawn at the next spawning point. If there are no free spawning points, game is over**


So, if we have the map above, let's take the following example:

```CSharp
map.Spawn(some_hero_instance)
map.PrintMap()
H.##.....T
#T##..###.
#.###E###E
#.E...###.
###T#####G
```

### `MoveHero()`

Now, implemented a method `MoveHero(Direction direction)` where:

* `Direction` is an enum with either `"Up"`, `"Down"`, `"Left"` and `"Right"`

This should move our hero in the desired direction.

Return `True` if he can move into that `direction` or `Fasle` otherwise.

__For example:__

```
map.move_hero(Direction.Right) //True
map.PrintMap()
.H##.....T
#T##..###.
#.###E###E
#.E...###.
###T#####G
map.moveHero(Direction.Up) \\False
map.moveHero(Direction.Down) \\Found treasure!
map.printMap()

..##.....T
#H##..###.
#.###E###E
#.E...###.
###T#####G
```

Here are the cases:

* If you move into an obstacle, return False and don't make the move.
* If you move outside the map - return False and don't make the move.
* If you move into an enemy, a `Fight` is automatically started. Otherwise, you have options, which we will describe in the `Fight` class
* If you move into `Treasure`, roll a dice to decide what it can be - a mana or health potion, a weapon or a spell

### Treasures

It is a good idea to have a finite list of treasures that can be found in a given dungeon.

One idea is to keep a list of treasure in the **txt** file, where the map is. Other idea is to have a separate file that keeps the loot for each map.

Our suggestion for you is to keep a track of all treasures in the `Dungeon` class and have a method `PickTreasure()` that returns an instance of randomly picked treasure.

## Fights

The interesting part is here.

Our hero must fight his enemies in order to reach the exit of the dungeon.

Our `Dungeon` should have a `heroAttack(by)` method, which checks if our hero can attack either by weapon or by spell, again having a `by` keyword-argument, like the `Weapon`


A fight happens when:

* Our hero walks into the same position as the enemy - then the fights start automatically
* Our hero is within some range of the enemy and triggers `heroAttack` method call. Then we can attack our enemy, but our enemy must walk to our place in order to start attacking us. This is really helpful with spells!

Implement a `Fight` class that takes a hero and an emeny and simulates a fight between them.

The `Fight` is over when either our hero or the enemy is dead.

Here is a full example:

```CSharp
var h = Hero("Bron", "Dragonslayer", 100, 100, 2) \\name="Bron", title="Dragonslayer", health=100, mana=100, mana_regeneration_rate=2
var w = Weapon("The Axe of Destiny", 20) \\ name="The Axe of Destiny", damage=20
h.Equip(w)
var s = Spell("Fireball", 30, 50, 2)
h.Learn(s)
map = Dungeon("level1.txt")
map.Spawn(h)
map.printMap()
H.##.....T
#T##..###.
#.###E###E
#.E...###.
###T#####G
map.moveHero(Direction.Right) \\True
map.moveHero(Direction.Down) \\ in console: Found health potion. Hero health is max.
>>> map.PrintMap()
..##.....T
#H##..###.
#.###E###E
#.E...###.
###T#####G
map.heroAttack(by="spell") \\ Nothing in casting range 2
map.moveHero(Direction.Down)
map.moveHero(Direction.Down)
map.printMap()
..##.....T
#.##..###.
#.###E###E
#HE...###.
###T#####G
map.heroAttack(by="spell")
A fight is started between our Hero(health=100, mana=100) and Enemey(health=100, mana=100, damage=20)
Hero casts a Fireball, hits enemy for 20 dmg. Enemy health is 80
Enemy moves one square to the left in order to get to the hero. This is his move.
Hero casts a Fireball, hits enemy for 20 dmg. Enemy health is 60
Enemy hits hero for 20 dmg. Hero health is 80
Hero does not have mana for another Fireball.
Hero hits with Axe for 20 dmg. Enemy health is 40
Enemy hits hero for 20 dmg. Hero health is 60.
Hero hits with Axe for 20 dmg. Enemy health is 20
Enemy hits hero for 20 dmg. Hero health is 40.
Hero hits with Axe for 20 dmg. Emely health is 0
Enemy is dead!
```

### Fight steps

The fight follows this algorithm:

* Our hero always attacks first
* We always use the attack that deals more damage
* If our weapon and our spell deals the same amount of damage, use the spell first.
* When you run out of mana, use the weapon (if any)
* Think of how you can make the enemies cast spells?

## Creativity and Improvisation

As you can see, this is a big and a fat problem. There are things that are not well defined. Try to split the solution into to projects - logic, where the behavior of our game will be located and a console application, where the logic for displaying our information will be.

**This is up to you. Make an interesting game!**

