string? age;
string? name;


Console.WriteLine("Give Me your Age: ");  //erste frage an den user
age = Console.ReadLine();
bool chekup = int.TryParse(age,out int ageValue);
Console.WriteLine("Give Me your Name: ");
name = Console.ReadLine();


int birthYear = DateTime.Now.Year - ageValue;               // 18+ Checker 

if (ageValue < 18)
{
    Console.WriteLine("age could not be verifyed: please enter an age of at least 18 years old");
    return;
}
else
{
Console.WriteLine("age verifyed");
} 
if (chekup == false)                                        // check if the age is null or empty
{
    Console.WriteLine("Sorry the age you enterd is not valid, it cant be empty or null");
}
else
{
    Console.WriteLine("Age is not null");
    Console.WriteLine("Your Name is: " + name + " and your birth year is " + birthYear);     
       // output of the name and birth year

}