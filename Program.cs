//using constructor;
//using System.Runtime.ExceptionServices;

using constructor;

Baby firstBaby = new Baby(); //Default Constructor.
firstBaby.name = "Daisy";
firstBaby.lastname = "Petty";
Console.WriteLine(firstBaby.name + firstBaby.lastname + firstBaby.birthDate + " is born");

Baby secondBaby = new Baby("Daisy", "Petty"); //Alternative Constructor.
Console.Write(secondBaby.name + secondBaby.lastname + secondBaby.birthDate + " is born");


