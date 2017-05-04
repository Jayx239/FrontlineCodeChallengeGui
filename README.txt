Frontline Code Challenge Gui
Created By Jason Gallagher

This application was developed in visual studio 2012. To use it open the solution file
in visual studio, compile, and run.

This gui application allows the user to type in an encoded string and decode it in another format.
The input string is expected to follow the format below:
(word1,word2(nestedword1)unestedword)

Default output:
- word1
- word2
-- nestedword1
- unestedword

Alphabetical sort:
-- nestedword1
- unestedword
- word1
- word2

Ascii Sort:
-- nestedword1
- unestedword
- word1
- word2

I completed the application in just over 24 hours inbetween classes and homework.

Design considerations:

StringBuilder:
In the parser class I decided to use the StringBuilder class for generating the output. This was done
because in C# each time a string is modified a new string is created, not modified. This can be very
inneficient and cause the application to run significantly slower.

Sort types:
When looking at the example output of the sorted list found on the code challenge prompt it did not
appear to be in alphabetical order. I decided to sort the items by alphabetical order, not taking
into account the preceding '-' characters. Then I decided to create an ascii sort method that did
take into account these characters.

