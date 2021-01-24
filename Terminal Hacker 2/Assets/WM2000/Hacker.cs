using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Configuration Data

    string[] Place = { "school", "nursery", "factory" };
    string[] Level1Passwords = { "ball", "swing", "crayon", "paint", "play" };
    string[] Level2Passwords = { "succulent", "garden", "bamboo", "orchid", "manure" };
    string[] Level3Passwords = { "pasteurization", "curdling", "tyrosemiophilia", "mozzarella", "cheesemonger" };

    // Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;
    string password;

    // Start is called before the first frame update
    void Start()
    {

        // ShowMainMenu("Andrew");
        ShowMainMenu();

    }

    void ShowMainMenu(/*string name*/)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();

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
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        
    }

    void RunMainMenu(string input)
    {
        bool IsValidLevel = (input == "1" || input == "2" || input == "3");
        if (IsValidLevel)
        {
            level = int.Parse(input);
            StartGame();    
        }
        else if (input == "007") // easter egg
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
        currentScreen = Screen.Password;
        switch(level)
        {
            case 1:
                password = Level1Passwords[0];
                break;
            case 2:
                password = Level2Passwords[0];
                break;
            case 3:
                password = Level3Passwords[0];
                break;
            default:
                Debug.LogError("Invalid level number.");
                break;
        }
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen to hack the " + Place[level-1]);
        Terminal.WriteLine("Please enter the password: ");
    }

    void CheckPassword(string input)
    {
        if (input == password)
            {
            currentScreen = Screen.Win;
            Terminal.WriteLine("Access granted.");
        }
        else
        {
            Terminal.WriteLine("Incorrect password. Try again.");
        }
    }
}
