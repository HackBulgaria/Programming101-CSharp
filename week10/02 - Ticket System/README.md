#Some helpful methods
## Password security
* [How to handle hash and salt](https://msdn.microsoft.com/en-us/library/system.security.cryptography.rngcryptoserviceprovider.aspx)

Ticket system part one
Recently we have noticed that the experience of buying a ticket for a train or bus is somewhat cumbersome. So we are going to make a superior system(and maybe make some money out of it).
This project will be implemented in multiple classes.
So to start building the system we will need to define some base entities.

##Cities
* Name

##Trains
* Identifier
* Seats – Where each seat can be first or second class
* Brief description

##Schedule
* Starting City
* End City
  * BONUS: Remember each city stop
* Travel Time
* The train with which the trip will be made
* Ticket price

##User
* Email 
* User name
* two users cannot have the same user name or email
* Password – The password should not be stored in plain text
* Discount Card Number
* Credit Card Number – Again not in plain text / the SVC should not be stored at all.
* Address
* Zip Code
* First name
* Last name

##Ticket
* TripDateAndTime
* Original Price
* Price sold
* UserSoldTo
* SeatNumber

##Discount Card
* ID
* Type – students/isic etc
* Discount amount
* Applies to first class – true/false

##The app must have the following functionalities:
###City wise:
* Get all cities
* Add a city 
* Delete a city

###Train wise:
* Get a list of trains
* Add a train
* Edit a train
* Delete a train

###Schedule wise
* Display the full schedule
* Add a trip – if the train is not in use – for now let us just take that it will teleport from place a to place after the trip is over (it is not safe for humans)
* Edit an existing trip
* Get all trips from city A to city B

###Tickets
* Every user should buy a ticket, if the seat he wants to buy is not taken.
