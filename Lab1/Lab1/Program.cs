// See https://aka.ms/new-console-template for more information

//Generates random number:
Random rnd = new Random();

//EXERSIES 1:
//Names...
string heroName = "Shurla";
string villanName = "Fishy";

//Powers...
int heroPower = rnd.Next(1, 100);
int villanPower = rnd.Next(1, 100);

//function: display the bigger power...
if (heroPower > villanPower)
{
    Console.WriteLine("\n \t Shurla is Stronger!! ");
}
else if (heroPower < villanPower)
{
    Console.WriteLine("\n \t Fishy is Stronger!! ");

}
else
{
    Console.WriteLine("\n \t Both have the same power!! ");
}

Console.WriteLine("\n \t-------------------------------------");

//EXERSIES 2:
float PlayerSpeed = rnd.Next(1, 5);

SetSpeed(2.5f);


void SetSpeed(float speed)
{//Function that does not return a value..But Changes the Speed
    Console.WriteLine("\n\t Player's Old Speed: " + PlayerSpeed);
    float new_PlayerSpeed = speed;
    Console.WriteLine("\t Player's New Speed: "+ new_PlayerSpeed);
}

CompareSpeeds(2.5f);

void CompareSpeeds(float speed)
{//Function that does not return a value..But Compares Speeds
    if (speed > PlayerSpeed)
    {
        Console.WriteLine("\n\t Fastest Speed: " + speed);
    }
    else if (speed < PlayerSpeed)
    {
        Console.WriteLine("\n\t Fastest Speed: " + PlayerSpeed);
    }
    else {
        Console.WriteLine("\n\t Both playesr have the same Speed!! ");
    }
}

