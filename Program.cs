// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using OnlineExercise;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Contacts;


SqlContactsManager sqlContactsManager = new SqlContactsManager();
ConsoleControler consoleControler = new ConsoleControler();
Menu menu = new Menu(sqlContactsManager, consoleControler);

while (true)
{
    menu.ShowMainMenu();
}







