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
// Console.Write("Ange användarnamn: ");
// string username = Console.ReadLine();

// Console.Write("Ange lösenord: ");
// string password = Console.ReadLine();

// if (username == "kalleanka" && password == "12345")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

//Steg 4
// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World");
// }



//Steg 5
// string correctPassword = "12345";
// string inputPassword;

// do
// {
//     Console.Write("Ange lösenord: ");
//     inputPassword = Console.ReadLine();
// } 
// while (inputPassword != correctPassword);

// Console.WriteLine("Rätt lösenord!");

//Steg 6
// for (int i = 0; i < 5; i++)
// {
//     Console.Write("Skriv in ett tal: ");
//     int number = int.Parse(Console.ReadLine());

//     if (number > 5)
//     {
//         Console.WriteLine("högre än 5!");
//     }
// }

//Steg 7
// string input;

// do
// {
//     Console.Write("Ange ett heltal: ");
//     input = Console.ReadLine();
// } 
// while (!int.TryParse(input, out _));

// Console.WriteLine("Du angav ett korrekt tal.");

//Steg 8
Random random = new Random();
int secretNumber = random.Next(1, 101);  
int guess = -1;

Console.WriteLine("Gissa siffran (mellan 1 och 100)!");

while (guess != secretNumber)
{
    Console.Write("Ange din gissning: ");
    string input = Console.ReadLine();

    // Kontrollera att inmatningen är ett heltal
    if (int.TryParse(input, out guess))
    {
        if (guess < secretNumber)
        {
            Console.WriteLine("För lågt! Försök igen.");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("För högt! Försök igen.");
        }
        else
        {
            Console.WriteLine("Grattis! Du gissade rätt!");
        }
    }
    else
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
    }
}

Console.ReadLine();

