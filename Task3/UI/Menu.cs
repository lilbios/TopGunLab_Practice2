using ConsoleApp;
using ConsoleApp.Task3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.UI
{
    class Menu
    {
        private List<Page> Pages;
        private List<Country> Countries;
        public Menu()
        {
            Pages = new List<Page>();
            Countries = new Initializer().Countries;
        }

        public void DrawMenu()
        {
            int pointer = 0;
            int index = 0;
            Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine("To escape click  on 'esc'...");
                for (int i = 0; i < Pages.Count; i++)
                {
                    if (i == pointer)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(Pages[i].Title);
                        index = pointer;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Pages[i].Title);
                    }
                    Console.ResetColor();
                  

                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Pages[index].Click(Countries);
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (pointer <= 0)
                    {
                        pointer = Pages.Count - 1;

                    }
                    else
                    {
                        --pointer;
                    }

                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (pointer == Pages.Count - 1)
                    {
                        pointer = 0;
                    }
                    else
                    {
                        ++pointer;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Escape) break;
                Console.Clear();
            }


        }

        public void AddPage(Page page) => Pages.Add(page);
    }
}
