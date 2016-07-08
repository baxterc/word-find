
Specifications:

-Return 0 if the word is not the same as the string.
Input Example: "hello", "goodbye"
Output Example: 0

-Return 1 if the word is the same as the string.
Input Example:
Output Example:

-Return 0 if the string does not contain the word.
Input Example:
Output Example:

-Return 1 if the string does contain the word.
Input Example:
Output Example:

-Return 2 if the string is two instances of the word.
Input Example:
Output Example:

-Find words separated by characters other than spaces such as hyphens, commas, periods, etc.
Input Example: "honk-honk", "honk"
Output Example: 2

-Assuming the user wants an inclusive search, return the number of times the main string contains both exact matches of their search word other words which contain (but are not exactly the same as) their search word.
Input Example: "loopy loop bloopers", "loop"
Output Example: 3

-Check if the user wants a case-sensitive search; if they do, match an the string with the search word if they are exactly the same.  This does not require a .ToLower() method to be applied to the two strings.
Input Example:
Output Example:

-If the user does not want a case-sensitive search, match the string with the search word if they are the same when turned into all lower case.
Input Example:
Output Example:
