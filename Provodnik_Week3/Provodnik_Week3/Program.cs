using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Provodnik_Week3
{
    class Program
    {
        static void ShowInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            int index = 0;
            foreach (FileSystemInfo fInfo in directory.GetFileSystemInfos())
           { 
                if (index == cursor)
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                else
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                index++;
                if (fInfo.GetType() == typeof(FileInfo))
                    Console.Write("File: ");
                else
                    Console.Write("Directory: ");
                Console.WriteLine(fInfo.Name);
            }

        }
        static void Main(string[] args)
        {
            int cursor = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\WebServers");
            while (true)
            {
                Console.Clear();
                ShowInfo(directory, cursor);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                    if (cursor > 0)
                        cursor--;
                if (pressedKey.Key == ConsoleKey.DownArrow)
                    if (cursor < directory.GetFileSystemInfos().Length - 1)
                        cursor++;
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fi = directory.GetFileSystemInfos()[cursor];
                    directory = new DirectoryInfo(fi.FullName);
                }
                if (pressedKey.Key == ConsoleKey.Backspace)
                {
                        directory = Directory.GetParent(directory.FullName);
                }
                if (pressedKey.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
