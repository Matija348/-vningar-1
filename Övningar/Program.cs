//Steg 1
// if (6 >= 3)
// {
//     Console.WriteLine("Hello, World!");
// }

//Steg 2
// Console.Write("Ange användarnamn: ");
// string username = Console.ReadLine();

// if (username == "kalleanka")
// {
//     Console.WriteLine("Welcome!");
// }

//Steg 3
Console.Write("Ange användarnamn: ");
string username = Console.ReadLine();

Console.Write("Ange lösenord: ");
string password = Console.ReadLine();

if (username == "kalleanka" && password == "12345")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Wrong username or password");
}



