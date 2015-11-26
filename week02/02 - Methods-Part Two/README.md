# Problems which involve using C# built-in classes #

## Friday the 13th ##

Write a method which given a year range, returns how many
Fridays 13ths there are in that range

`int UnfortunateFridays(int startYear, int endYear)`

## Date sums ##

Find all dates in a given whose digits of the month number
and the day number sum up to a given value. Print each of
them on the console in the format 
`dd/mm/yyyy: d+d+m+m=sum`.

`void PrintDatesWithGivenSum(int year, int sum)`

## 1337 ##

When the clock hits 13:37 on December 21st, this is a special
time for hackers. Write a method which prints how many days,
hours, and minutes remain until the next such time comes.

`void HackerTime()`

The result should be printed on the console in the format dd:hh:mm

## Appointments intersection ##

You are given a list of appointments and your task is to find the
intersecting appointments. Write a method which takes two equal-sized
arrays as arguments and prints one line for each pair of intersecting
appointments. The line should be in the format:

The appointment starting at dd/mm/yyyy hh:mm intersects the
appointment starting at dd/mm/yyyy hh:mm with exactly mmmm minutes.

`void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)`

## Calendar ##

Write a method which prints on the console the calendar for and
specified month and year. The calendar should be localized according to
a certain culture.

`void PrintCalendar(int month, int year, CultureInfo culture)`

The first line should contain the name of the month, the second line
the names of the weekdays space-separated, and the next lines should
the month day numbers, each right-aligned to the column of its week.

Example:

PrintCalendar(11,2015, new CultureInfo("bg-BG")):
```
Ноември
понеделник вторник сряда четвъртък петък събота неделя
         1       2     3         4     5      6      7
         8       9    10        11    12     13     14
        15      16    17        18    19     20     21
        22      23    24        25    26     27     28		 
		29      30     
```

## Bank Account Balance ##

Pesho has extracted his bank account statement in a file
and he wants to know how much money he has received, has spent
and what is his balance (received - spent). 
He wants to be able to check that for any given date range.

The format of Pesho's file is as below:

25.03.2015г.;теглене;25.12лв
28.03.2015г.;теглене;215.22лв
29.03.2015г.;теглене;115.62лв
30.03.2015г.;теглене;13.37лв
31.03.2015г.;внасяне;1000.00лв
01.04.2015г.;теглене;400.00лв

i.e.

<date>;<operation[теглене|внасяне]>;<amount[X.XXлв]>

Hint: Use File.ReadAllText to read the contents of the file.

## Polygon Circumference ##

Write a method which calculates the circumference of a given polygon.

`float CalcCircumference(PointF[] points)`

The polygon is given as an array of `PointF`s which represents
a point with a floating point coordinates (from System.Drawing).

The 0 index of the array contains the bottom-most point,
and the next points are sorted counter-clockwise according to
the point at 0.

Hints: TBA

## Polygon Area ##

Write a method which calculates the area of a given polygon.

`float CalcArea(PointF[] points)`

The polygon is given as an array of `PointF`s which represents
a point with a floating point coordinates (from System.Drawing).

The 0 index of the array contains the bottom-most point,
and the next points are sorted counter-clockwise according to
the point at 0.

Hints: TBA

## Random Numbers ##

Write a method which outputs a matrix of random floating point
numbers to a file.
The dimensions of the matrix are given as arguments. The numbers
should be in the range 0-1000 and should be printed with exactly
two digits after the decimal point. The numbers should be separated
by at least one space and should be right aligned to the size of their
column (which you can consider to be fixed at 8 characters).

void GenerateRandomMatrix(int rows, int columns, string fileName)

3x3:
   13.37  545.87   75.64
  184.37 1000.00  684.64
    1.00    9.67  378.68
   
Hint: Use File.WriteAllText to output the result.

## Clock angle ##

Write a method which calculates the angle (degree) between hour and minute hands. 

int GetClockHandsAngle(DateTime time)

1) Calculate the angle if you consider that the hour hand points to exact hour (when the time is 4:34 then the hour hand points exactly to 4 o'clock)

2) Calculate the angle if the hour hand points doesn't point exactly to the number (when the time is 4:30 then the hour hand points exactly in the middle between 4 and 5 o'clock)

Example : 15:00 is 90 degree 

Hint : Use Math library
