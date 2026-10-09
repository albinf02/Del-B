// Skapa kurser och studenter

Course english = new Course("English", 2);

Student Albin = new Student("Albin");
Student Filip = new Student("Filip");

// Anmälan och dubbelanmälan

bool firstRegistration = Albin.Join(english);
bool secondRegistration = Albin.Join(english);

Console.WriteLine($"First registration: {firstRegistration}");
Console.WriteLine($"Second registration: {secondRegistration}");

english.Enroll(Filip);

Student Tomas = new Student("Tomas");

bool added = english.Enroll(Tomas);

Console.WriteLine($"Tomas added: {added}");

english.RollCall();

// Avanmälan, även av någon som inte är anmäld

bool removed = english.Remove(Albin);
Console.WriteLine($"Albin removed: {removed}");

Albin.Schedule();
english.RollCall();

bool removedTomas = english.Remove(Tomas);
Console.WriteLine($"Tomas removed: {removedTomas}");

Filip.Schedule();
Console.WriteLine(english);

english.RollCall();

bool left = Filip.Leave(english);
Console.WriteLine($"Filip left: {left}");

bool leftAgain = Filip.Leave(english);
Console.WriteLine($"Filip left again: {leftAgain}");

Filip.Schedule();
english.RollCall();

// Flera kurser

Course math = new Course("Math", 3);

Albin.Join(english);
math.Enroll(Albin);

Albin.Schedule();
Console.WriteLine(english);
Console.WriteLine(math);

// dubbelanmälan och full kurs från båda hållen

bool filipEnrolled = english.Enroll(Filip);
Console.WriteLine($"Filip enrolled: {filipEnrolled}");

bool filipAgain = english.Enroll(Filip);
Console.WriteLine($"Filip enrolled again: {filipAgain}");

bool tomasJoined = Tomas.Join(english);
Console.WriteLine($"Tomas joined: {tomasJoined}");

english.RollCall();
Tomas.Schedule();
