// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using OnlineExercise;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;



ContactsManager contactManager = new ContactsManager();
ConsoleControler consoleControler = new ConsoleControler();
Menu menu = new Menu(contactManager, consoleControler);

while (true)
{
    menu.ShowMainMenu();
}







