using ConsoleApp1;

HashMap hashMap = new HashMap(10);

hashMap.Set("Ahmad", "Civil Engineer");
hashMap.Set("Osama", "Mechanical Engineer");
hashMap.Set("Zaid", "Doctor");
hashMap.Set("Mohammad", "CS");
hashMap.Set("Bashar", "CIS");
hashMap.Set("Anas", "SE");
hashMap.Set("Ala'a", "Math");
hashMap.Set("Abdullah", "Chemistry");
hashMap.Set("Yaman", "Physics");
hashMap.Set("Said", "CS");

hashMap.Print();
var b = hashMap.Get("Anas");
Console.WriteLine(b);