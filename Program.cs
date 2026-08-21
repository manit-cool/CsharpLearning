using System;
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
