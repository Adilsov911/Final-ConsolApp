using Core.Constant;
using Core.Helpers;
using DrugStrore.Controllers;
using Menage.Contreoller;
using System;

namespace Menage
{
    public class Program
    {
        static void Main(string[] args)
        {

            OwnerController ownerController = new OwnerController();
            DrugController drugController = new DrugController();
            DruggistController druggistController = new DruggistController();
            DrugStoreController drugStoreController = new DrugStoreController();
            AdminController admincontroller = new AdminController();

        Admin: var admin = admincontroller.Authenticade();

            if (admin != null)
            {
                Helper.WriteTextWithColor(ConsoleColor.Green, $"Welcome, {admin.Username}");
                Helper.WriteTextWithColor(ConsoleColor.White, "------");

                while (true)
                {
                    Helper.WriteTextWithColor(ConsoleColor.Blue, "Main Menu:");
                    Helper.WriteTextWithColor(ConsoleColor.Cyan, "Owner Menu - 1");
                    Helper.WriteTextWithColor(ConsoleColor.Cyan, "DrugStore Menu - 2");
                    Helper.WriteTextWithColor(ConsoleColor.Cyan, "Druggist Menu - 3");
                    Helper.WriteTextWithColor(ConsoleColor.Cyan, "Drug Menu - 4");


                    Console.WriteLine("--------------------------------------------------");

                    Helper.WriteTextWithColor(ConsoleColor.Magenta, "Select Options:");
                    string number = Console.ReadLine();
                    int selectedNumber;
                    bool result = int.TryParse(number, out selectedNumber);


                    if (result)
                    {
                        if (selectedNumber == 1)
                        {
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Owner");

                            Helper.WriteTextWithColor(ConsoleColor.Magenta, "Select Options:");
                            number = Console.ReadLine();


                            result = int.TryParse(number, out selectedNumber);
                            if (selectedNumber >= 0 && selectedNumber <= 6)
                            {
                                switch (selectedNumber)
                                {

                                    case (int)OwnerOptions.CreateOwner:
                                        ownerController.Creat();
                                        break;


                                }
                            }
                            else
                            {
                                Helper.WriteTextWithColor(ConsoleColor.Red, "Please enter correct number");
                            }
                        }

                        else if (selectedNumber == 2)
                        {
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Student");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Student");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Student");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "4 - Get All Student By Group");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Student By Group");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "6 - Back Main Menu");
                            Helper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                            Helper.WriteTextWithColor(ConsoleColor.Magenta, "Select Options:");
                            number = Console.ReadLine();


                            result = int.TryParse(number, out selectedNumber);
                            if (selectedNumber >= 0 && selectedNumber <= 6)
                            {
                            }
                            else
                            {
                                Helper.WriteTextWithColor(ConsoleColor.Red, "please enter correct number");
                            }
                        }
                        else if (selectedNumber == 3)
                        {
                            Helper.WriteTextWithColor(ConsoleColor.Green, "1 - Creat Teacher");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "2 - Update Teacher");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "3 - Delete Teacher");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "4 - Get All Teacher");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "5 - Add Teacher To Group");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "6 - All Groups Of Teachers");
                            Helper.WriteTextWithColor(ConsoleColor.Green, "0 - Exit");
                            number = Console.ReadLine();

                            result = int.TryParse(number, out selectedNumber);
                            if (selectedNumber >= 0 && selectedNumber <= 6)
                            {

                            }
                            else
                            {
                                Helper.WriteTextWithColor(ConsoleColor.Red, "please enter correct number");
                            }
                        }
                        else
                        {
                            Helper.WriteTextWithColor(ConsoleColor.Red, "Please, Select Correct Options...");
                        }
                    }
                    else
                    {
                        Helper.WriteTextWithColor(ConsoleColor.Red, "Please, Select Correct Options...");
                    }

                }
            }
            else
            {
                Helper.WriteTextWithColor(ConsoleColor.Red, "Username or Password incorrect");
                goto Admin;
            }






        }
    }
}
