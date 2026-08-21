using System;
using System.Runtime.CompilerServices;
Console.WriteLine("Hello, World!"); // This prints out things to the terminal
//Strings!
string firstFriend = "Prokhor";
string secondFriend = "Harold";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}"); // this is called string interpolation
// which is basically like string concatonation!
Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);
// same things, but i personally like the interpolation one better :D
// Just like strip in python, C# has it's own way of removing whitespaces (spaces)
string stripMe = "   hehe   ";
stripMe = stripMe.Trim();
Console.WriteLine(stripMe);
//kaboom
//btw you can also do those in prints ;)
string thirdFriend = "                 Scott";
Console.WriteLine($"My third friend is {thirdFriend.Trim()}");
//Time to learn more methods on strings

string fruits = "My favorite fruits are apple banana and watermelon";
Console.WriteLine(fruits.Replace("apple", "strawberry"));//ironically I don't actaully like strawberries.
// but it replaces the word apple to strawberry, just for that line (doesn't actaully edit the variable)
Console.WriteLine(fruits.Contains("strawberry"));
Console.WriteLine(fruits.Length);
Console.WriteLine(fruits.ToUpper());
Console.WriteLine(fruits.StartsWith("My"));
//Just a few more functions that are available with strings :D

//Ints and Floats
int a = 18;
int b = 9;
int c = a + b;
Console.WriteLine(c);

//okay that's easy, but what about bigger numbers :0
// ints usually cap out between 2.1 billion and 2.2 billion!
// Now what would happen here:
int t = 2100000000;
int u = 2100000000;
//int h = t + u;
//Console.WriteLine(h);

//okay so h overflows the max value, so essentially converting it to a long would work right?
//long h = t + u;
//Console.WriteLine(h);
//But there's another issue, the addition is happening in an integer format, just how in python you can't just add an int to a string without CASTING!
// so we hard cast the values
long h = (long)t + (long)u;
Console.WriteLine(h);
//yippeee!! This is manit-cool2324 signing off for the night ;)
