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
long h = (long)t + (long)u; // btw we can also use checked, to make sure that if there is ever an error it would just use the correct type :D
Console.WriteLine(h);
//yippeee!! This is manit-cool2324 signing off for the night ;)
//int v = 2.1;// this would make a squigly line under, asking you if you're missing a cast!
//just like in python, it'll just round down
int v = (int)2.1; // forces to round :D
float hi = 21.45F; // F for ending --> faster on computers, 32 bits
double ee = 21.6; // No ending! --> faster on computers, 64 bits
decimal go = 83.3M; // M for ending :D --> slower on computer, but cleaner rounding, 128 bits
Console.WriteLine(go);
Console.WriteLine(hi);
Console.WriteLine(ee);
Console.WriteLine(v);

//Now we have our conditionals
int aVar = 5;
int bVar = 10;
int cVar = 5;
//honestly personally, I miss the curly braces, unless i can put them
if (aVar + bVar == cVar) // = *equals* assignment, whereass == checks for equality XD
    Console.WriteLine("Your sentence is correct:D");
if (aVar + bVar == cVar)
{
    Console.WriteLine("omg curly braces, hi!");
}
else
{// it can either be in a new line or on the last curly braces, i like it on the last curly braces with only one if statement, not mulitple :D
    Console.WriteLine("Yo, you messed up your math big time man");
}
// just like in python, you can set other variables to booleans that are set by a condition! --> idk if that makes sense!

bool bBool = aVar < bVar;
Console.WriteLine(bBool);

//Loops

int counter = 0;
counter = counter + 1;
// this only adds to counter once :(
// but you're an amitious counter, and dream that one day counter will be a very high number >:D
counter++;
while (counter < 20)
{
    counter++;
} // you did it! Your ambitions have been achieved, and your counter is very high
do
{
    counter++;
} while (counter < 20);
// Alright, now there is 2 differences
// While loops are entry checked --> condition is checked first --> condition is the (counter < 20) part
// Do-While loops are exit checked --> condition is checked last --> condition is the (counter < 20) part
// While loops would run 0 times if false
// Do-While loops would run 1 time if false

// For loops!

for (int i = 1; i < 5; i++) //this is like javascript or java --> one of those, or none of those :D
{
    Console.WriteLine(i);
}
// you can also do nested for loops!

for (int Row = 1; Row < 11; Row++)
{
    for (char column = 'a'; column < 'k'; column++) //notice this? Pretty cool right? You can just add to a char and it'll go to the next letter! :D
    {
        Console.WriteLine($"the row is {Row} and the column is {column}");
    }
}

//Let's try to give letter it's own row ;)
int row = 1;
for (char letter = 'a'; letter < 'k'; letter++)
{
    Console.WriteLine($"The row is {row} and the letter is {letter}");
    row++;
}
