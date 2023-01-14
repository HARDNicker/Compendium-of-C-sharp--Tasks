# Compendium-of-C-sharp--Tasks

I am a student and this repository of lab work I have been doing. I haven't changed anything in the code so that I can track my progress in learning the C# programming language.  In the README file, you can find a list of tasks to easily navigate through the files.

### NOTE
Some code is not quite optimized and optimal, but it works).
There are comments in Russian in the code. 

## Input, output, condition, selection, loop with parameter
Labs 1:

Tasks:

First file :
Calculate the given formulas ![image](https://user-images.githubusercontent.com/122534600/212486521-8a67e6b4-ad84-45cc-b987-4d85d309e02d.png)
, all variables are entered from the keyboard, and the result is printed on the screen.
Static methods of Math class are used to calculate mathematical functions;

Second file :
Write a program to solve a system of linear equations;

Third file :
Two positive real numbers x and y are given.
Arithmetic operations on the numbers are numbered (1 - addition, 2 - subtraction, 3 - multiplication, 4 - division). Make a program that, based on the number entered, performs one or another actions on the numbers;

Fourth file :
Make a program-generator of prime numbers, based on the formula ![image](https://user-images.githubusercontent.com/122534600/212486627-c0794e65-c93e-4972-954a-d4a9b80bf40d.png) for 1 ≤ n ≤36. Each generated number of this type should be checked for simplicity;
   
 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## A loop with a condition, working with one-dimensional arrays
Labs 2: 

Tasks:

First file : 
Find the smallest number n of a member of the sequence, for which the condition an- an-1 < ɛ is satisfied. Display this number and all elements ai, where i = 1, 2,..., n; ![image](https://user-images.githubusercontent.com/122534600/212486793-75f7d832-b97b-45a7-b4d1-40a13b9868ff.png)

Second file :
A natural number n is given. Rearrange its digits to form the maximal number written with the same digits;

Third file :
In a one-dimensional array with an even number of elements (2N) there are N coordinates of points in the plane. They are arranged in the following order: x1, y1, x2, y2, x3, y3, etc. Determine the minimal radius of the circle centered at the origin of coordinates that contains all points;

Fourth file :
Suppose there are two non-decreasing sequences of real numbers a1 ≤ a2 ... ≤ an and b1 ≤ b2 ... ≤ bm . We need to specify the places where elements of the sequence b1, b2, ... bm should be inserted into the first sequence so that the new sequence remains increasing;
   

----------------------------------------------------------------------------------------------------------------------------------------------------------
## Two-dimensional arrays. Strings
Labs 3:

Tasks:

First file :
In a given real square matrix of order n find the largest element modulo. Obtain a square matrix of order (n - 1) by discarding the row and column in the original matrix, on the intersection of which there is an element with the found value;

Second file :
A string is given. Convert it by replacing with dots all colons (:) occurring among the first n/2 characters, and by replacing with dots all exclamation points occurring among characters following the n/2 characters;

Third file :
Text formatting. There is a text consisting of sentences separated by dots. Write a program that does the following formatting: each dot must be followed by at least one space at the end of the sentence.
The first word in the sentence should start with a capital letter;

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Stacks and queues
Labs 4:

Tasks:  	

First file : There are two stacks of real numbers, write a program that combines them into one stack;

Second file : There are coins with a face value of 3 and 7 rubles. Determine whether these coins can make up a sum of S rubles (S <= 50) and, if you can, suggest any way to get this sum;

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Dictionaries and sets
Labs 5:

Tasks: 

First file : Print the word that occurs most often in this text. If there are several such words, output the one that is smaller in lexicographical order;

Second file : Given text: the first line contains the number of lines, followed by the lines themselves. Determine how many different words this text contains;

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Working with files
Labs 6:

Tasks:

First file :  There is an integer file with less than 50 elements. Increase its size to 50 elements by writing the necessary number of zeros to the beginning of the file;
		   
Second file : There is a string file that contains dates in the format "day/month/year", with two positions for day and month and four for year (for example, "16/04/2001"). Find the line containing the latest fall date. If there are no dates with the required time of year in the file, print an empty line;

Third file :
There is a file of real numbers, containing elements of a tridiagonal matrix (by rows). Create a new file containing the elements of the nonzero part of this matrix (by rows);

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Classes
Labs 7:

Tasks:

First file : 
Describe a linear list class. Provide methods for:
1. Check its emptiness
2. Listing all elements (access to all elements in turn)
3. Deleting arbitrary element
4. Getting the list length
5. Combining two lists
Write a program that demonstrates how to use this class. It must use all the implemented methods of the class;

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Inheritance
Labs 8:

Tasks:  

First file :
Create a class of 2-dimensional shape with purely virtual methods of printing, calculating area and perimeter.
Inherit parallelogram and semicircle classes and implement these methods in them.
In derived classes set the fields defining the corresponding shapes, as well as methods of access to them for reading and writing;

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Generics and exceptions
Labs 9:

Tasks:

First file : Implement queue class template (+Exception handling)

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 ## Delegates and events
Labs 10:

Tasks: 

First file :
Write a printer class.
Main properties: name, production date, maximum tray volume (in pages), current tray volume.
Methods: add paper to tray, print document (parameter - number of document pages for single-sided printing).
Create delegates that are called when: printing new document, when printing next page of document, when paper finishes during document printing, when tray is overloaded (exceeds its maximum capacity).
Implement corresponding events.
Working with events, delegates and exceptions.
Write a program that implements the following variant classes.
The code must demonstrate the use of the classes.
Also at least two own exceptions should be created, it is necessary to implement their generation and handling;

Second file:
Implement the previous class and demonstrate its use, using standard generalized Func, Action, or EventHandler delegates for events (optional, but all events must be described through standard generalized delegates). 
Working with events, delegates, and exceptions.
Write a program that implements the following variant classes.
The code should demonstrate the use of the classes.
Also, at least two custom exceptions should be created and their generation and handling should be implemented;
 
  ----------------------------------------------------------------------------------------------------------------------------------------------------------
