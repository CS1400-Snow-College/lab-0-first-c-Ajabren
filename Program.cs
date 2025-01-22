// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
string aFriend = "Antron";
Console.WriteLine("Hello " + aFriend);
aFriend = "Azale";
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Helloo {aFriend}");
string firstFriend = "Antron";
string secondFriend = "Azale";
Console.WriteLine($"My World friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
string greeting = "      How are you!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
string sayHello = "Hello Stranger!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));