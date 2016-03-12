# Problems on multithreading

## APM Calculator
Write a desktop application (windows forms or WPF) that calculates your Actions Per Minute (APM) in real time
* The user can click anywhere on an empty surface
* A label shows his/her actions per minute in real time

Hints:
* Use a background thread that calculates the APM in small intervals (each second for instance) (you can use `Thread.Sleep()`)

## Raw HTML Browser
Write as a desktop application a simple browser that fetches the html content of a given url and displays the raw HTML to the user
* There should be a textbox for entering the URL
* There should be a button to start the page loading
* There should be a text area where the result is shown

Requirements:
* Use the Tasks library
* When the user clicks Load, the text of the button changes to Cancel
  * If the user clicks Cancel before the page has loaded, the loading should be canceled

Hints:
* To fetch a web page you can use the `WebClient` class

## Bonus: Circle Killer
Extend the APM Calculator with automatically spawining circles that the user has to click:
* In predefined intervals small circles spawn randomly on the surface
* When the user clicks on a circle it disappears
* Only clicks on the circles count towards the APM calculation

Hints:
* If you use Windows Forms use the `OnDraw` event of a Panel to draw the circles
* If you use WPF use Canvas to draw the circles
