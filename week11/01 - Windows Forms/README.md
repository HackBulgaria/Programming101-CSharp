# Tasks

## Calculator

Write a basic calculator application. 

* The calculator should support the basic operators: +,-,*,/
* In addition, the functions sqrt, log2 and ln should also be supported
* Fractional numbers should also be supported

## Text auto correct

Write a text pad which auto-corrects you as you type.

The program should read the words dictionary from a file. Here is a [sample one](http://www-01.sil.org/linguistics/wordlists/english/wordlist/wordsEn.txt)

For each written word (after you press space next to the word), the program should
check if the word exists in the dictionary and if it does not, replace it with the
most similar to it which exists in the dictionary.

To determine similarity between words, you can count the number of positions
in which two words differ.

## File browser

Write a simple file browser with a TreeView and a ListView. 

* The TreeView should display the folder structure of drive C:\ (folders only).
* When you select a folder from the TreeView, its contents should be display in the ListView.
* Double clicking a folder in the ListView should open the folder.
* Double clicking a file in the ListView should open it with the associated program for it.
