Console.WriteLine("You wake up in strange room and try to remember your name. What is it?");
string userName = Console.ReadLine();

bool key = false;
bool lockpick = false;
bool art1 = false;
bool art2 = false;
bool art3 = false;
int ventTryCount = 0;
bool sucсess = false;
string noHappens = "Nothing happens";
string gotArt = "You find a beautiful artifact!";

while (sucсess == false)
{
    Console.WriteLine(userName + " has a choice:\n1. Open the door\n2. Look under the bed\n3. Open a box in the room angle\n4. Open the ventilation\n5. Look at the bedside table\n6. Look at the statue next to the door");
    string userChoice = Console.ReadLine();
    if (userChoice == "1")
    {
        if (lockpick == false)
        {
            Console.WriteLine(noHappens);
        }
        else
        {
            Console.WriteLine("Sucсess!");
            sucсess = true;
        }
    }
    else if (userChoice == "2")
    {
        if (art1 == false)
        {
            Console.WriteLine(gotArt);
            art1 = true;
        }
        else
        {
            Console.WriteLine(noHappens);
        }
    }
    else if (userChoice == "3")
    {
        if (key == false)
        {
            Console.WriteLine("You try to open a box, but fail.");
        }
        else
        {
            if (lockpick == false)
            {
                Console.WriteLine("You open a box and get a lockpick.");
                lockpick = true;
            }
            else
            {
                Console.WriteLine(noHappens);
            }
        }
    }
    else if (userChoice == "4")
    {
        if (ventTryCount < 3)
        {
            Console.WriteLine("You try to open the vent, but fail.");
            ventTryCount++;
        }
        else if (ventTryCount == 3)
        {
            Console.WriteLine(gotArt);
            art2 = true;
            ventTryCount++;
        }
        else
        {
            Console.WriteLine(noHappens);
        }
    }
    else if (userChoice == "5")
    {
        if (art3 == false)
        {
            Console.WriteLine(gotArt);
            art3 = true;
        }
        else
        {
            Console.WriteLine(noHappens);
        }
    }
    else if (userChoice == "6")
    {
        if (art1 == true & art2 == true & art3 == true)
        {
            Console.WriteLine("You activate the statue and get the key.");
            key = true;
        }
        else
        {
            Console.WriteLine(noHappens);
        }
    }
}
