# The-Sieve
This is for the challenge The Sieve in the book C# players guide fifth edition.

Objectives
Create a Sieve class with a public bool IsGood(int numbers) methods.
This class needs a constructor with a delegate parameter that can be invoked later within the IsGood method. 
Hint: You can make your own delegate type or use Funt<int, bool>.
Define methods with an int parameter and a bool return type for the following: (1) returns true for even numbers
(2) returns true for postive numbers, and (3) returns true for multiples of 10.
Create a program that asks the user to pick one of those three filters, consturcts a new Sieve
instance by passing in one of the those methods as a parameter, and then ask the user to enter numbers
repeatedly, displaying whether the number is good or bad depending on the filter in use.

Anwser this question: Describe how you could have also solved this problem with inhertiance and 
polymorphism. Which solution seems more straightforward to you, and why?    