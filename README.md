# Word Finder

#### A simple search app.

#### By Charlie Baxter

## Description
This site allows you to search a string of text using a search term of your choice.  The page will return a count of the number of times your search term occurs in the text you submitted.  It includes options for a case-sensitive search as well as an inclusive search, which will find words within words and return them as a match (like "monk" in the word "monkey").

## Setup
* Clone this repository
* Install a C# framework such as Mono, which is available from [www.mono-project.com](http://www.mono-project.com/)
* Navigate to the project folder using your terminal/shell and run the command "dnu restore" to load dependencies.
* Type the command "dnx kestrel" to load the project.  The following message should appear:   
Hosting environment: Production   
Now listening on: http://localhost:5004   
Application started. Press Ctrl+C to shut down.
* In your web browser, type in http://localhost:5004
* Once finished, type control-C in your terminal or shell.

## Technologies Used
* C#
* Nancy
* Razor
* HTML
* CSS


## Specifications:

#### This program will:

- ###### Return 0 if the word is not the same as the string.  These two values are obviously unequal and should trigger the most basic behavior we expect our program to exhibit.
Input Example: "hello", "goodbye"  
Output Example: 0

- ###### Return 1 if the word is the same as the string.  This add a conditional but uses the same behavior as above.
Input Example: "hello", "hello"  
Output Example: 1

- ###### Return 1 if the string contains the word.  The search word is contained at the beginning of the string and should be easily found.
Input Example: "monkey", "monk"  
Output Example: 1

- ###### Return 2 if the string is two instances of the word separated by a space.  In this example, we're using the same word twice, just separated by a single space, and with no other words that might interfere in some way to ensure that this behavior is correct
Input Example: "beep beep", "beep"  
Output Example: 2

- ###### Find words separated by characters other than spaces such as hyphens, commas, periods, etc.  Again, we're just using the same word twice, but with a different delimiter than just a space (in this case, a hyphen).
Input Example: "honk-honk", "honk"  
Output Example: 2

- ###### Assuming the user wants an inclusive search, return the number of times the main string contains both exact matches of their search word other words which contain (but are not exactly the same as) their search word.  This is an elaboration on the above concepts of exact and inclusive matches found within a space-separated string.
Input Example: "loopy loop bloopers", "loop"  
Output Example: 3

- ###### Check if the user wants a case-sensitive search; if they do, match an the string with the search word if they are exactly the same.  This is a new behavior so it does away with some of the above logic and reverts to our first behavior, but our method now will convert the two strings to lower case unless the user specifies otherwise.
Input Example: "Test", "test"  
Output Example: 0  
Input Example: "Test", "Test"  
Output Example: 1

- ###### Return a count of exact matches only if the user enters a search term that contains a space.  This requires an additional condition to check to see if the search word contains a space, which in turn triggers different logic than what has been previously implemented.  This example uses only an exact match to keep things simple.
Input Example: "Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo", "Buffalo buffalo"  
Output Example: 3

## Known Bugs
None  

## Contact & Support
If you run into any issues with this page, have any questions, ideas, or concerns, feel free to email me at charlie.r.baxter@gmail.com.

## Legal
Copyright (c) 2016 Charlie Baxter.  This software is licensed under the MIT License.
