# Ticket System App

Extend the [Ticket System](https://github.com/HackBulgaria/Programming101-CSharp/tree/master/week10/02%20-%20Ticket%20System)
task from the previous week and allow all operations to be done via the graphical interface.

Add a column IsAdmin to the Users table to be able to distinguish between
normal users and administrators.

## Login screen

Start with a login screen where the user enters a username and a password, then logs in.

## Normal users

Normal users should be able to:

* Display the train shedule for a given date
* Get all trips from city A to city B for a given date
* Buy a ticket for a trip.

## Admin users

Admin user should be able to:

### City wise:

* Get all cities
* Add a city 
* Delete a city

### Train wise:

* Get a list of trains
* Add a train
* Edit a train
* Delete a train

### Schedule wise

* Display the full schedule
* Add a trip – if the train is not in use in the specified time span
* Delete trip