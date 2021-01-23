using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;




    // Start is called before the first frame update
    void Start()
    {

        // ShowMainMenu("Andrew");
        ShowMainMenu();

    }

    void ShowMainMenu(/*string name*/)
    {
        /**
        Terminal.WriteLine("Wifi has been slow so you check the router and see some unwanted neighborhood visitors have been limiting your streaming capacity! To get back to bingeing The Office again, you need to hack in and reroute them to your annoying neighbor Steve.");
        Terminal.WriteLine("Who do you hack first?");
        Terminal.WriteLine("1. Hack into local Kindergaden.");
        Terminal.WriteLine("2. Hack into the plant nursery next door.");
        Terminal.WriteLine("3. Hack into the cheese factory across the street.");
        Terminal.WriteLine("Enter your selection: ");
        **/
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        /**var greeting = "Hello Andrew";
        Terminal.WriteLine(greeting);**/
       // Terminal.WriteLine("Hello " + name);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 to hack into Kindergarden.");
        Terminal.WriteLine("Press 2 to hack into plant nursery.");
        Terminal.WriteLine("Press 3 to hack into cheese factory.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // We can always go straight to Main Menu
        {
            ShowMainMenu(); 
        } 
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr. Bond.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
        currentScreen = Screen.Password;
    }
}
