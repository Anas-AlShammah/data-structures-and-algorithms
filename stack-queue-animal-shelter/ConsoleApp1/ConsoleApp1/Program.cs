// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

AnimalShelter shelter = new AnimalShelter();
shelter.Enqueue(new Dog("Buddy"));
shelter.Enqueue(new Cat("Whiskers"));
shelter.Enqueue(new Dog("Max"));
shelter.Enqueue(new Cat("Mittens"));
Animal dogPreference = shelter.Dequeue("dog");
Console.WriteLine($"Adopted dog: {dogPreference?.Name}");
Animal catPreference = shelter.Dequeue("cat");
Console.WriteLine($"Adopted cat: {catPreference?.Name}");
Animal invalidPreference = shelter.Dequeue("fish");
Console.WriteLine($"Invalid preference: {invalidPreference?.Name}");
shelter.Enqueue(new Cat("Luna"));
shelter.Enqueue(new Dog("Rocky"));
Animal nextAnimal = shelter.Dequeue("dog");
Console.WriteLine($"Next animal: {nextAnimal?.Name}");

