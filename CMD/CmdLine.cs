using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CMD
{
    class CmdLine
    {
        private string CompanyIntro = "Chorrny Inc [Version 1.0]\n" +
                "(c)2021 ITStep Corporation. All rights reserved.";
        public void CMDOpen()
        {
            string action;
            Console.WriteLine($"{CompanyIntro}\n\n");
            Console.WriteLine("Enter [help] for instruction");
            do
            {
                action = Console.ReadLine();
                if (action.ToLowerInvariant() == "help")
                {
                    Help();
                }
                if (action.ToLowerInvariant() == "md")
                {
                    Console.Write("\nEnter name for directory : ");
                    string name = Console.ReadLine();
                    AddDirectory(name);
                }
                if (action.ToLowerInvariant() == "rd")
                {
                    Console.Write("Enter path :");
                    string path = Console.ReadLine();
                    RemoveDirectory(path);
                }
                if (action.ToLowerInvariant() == "cd")
                {
                    Console.Write("Enter path :"); string path = Console.ReadLine();
                    ChangeDirectory(path);
                }
                if (action.ToLowerInvariant() == "dir")
                {
                    Dir();
                }
                if (action.ToLowerInvariant() == "create")
                {
                    Console.Write("Enter name for file :");
                    string name = Console.ReadLine();
                    Console.Write("Enter message for add in file : ");
                    string mess = Console.ReadLine();
                    CreateFile(name, mess);
                }
                if (action.ToLowerInvariant() == "type")
                {
                    Console.Write("Enter name file : ");
                    string name = Console.ReadLine();
                    InfoFile(name);
                }
                if (action.ToLowerInvariant() == "copy")
                {
                    Console.Write("Enter path: "); string path = Console.ReadLine();
                    Console.Write("Enter new path: "); string newPath = Console.ReadLine();
                    CopyFile(path, newPath);
                }
                if (action.ToLowerInvariant() == "del")
                {
                    Console.Write("Enter name:"); string name = Console.ReadLine();
                    RemoveFile(name);
                }
                if (action.ToLowerInvariant() == "append")
                {
                    Console.Write("Enter name: "); string name = Console.ReadLine();
                    Console.Write("Enter message: "); string mess = Console.ReadLine();
                    ApendFile(name, mess);
                }
            } while (true);
            
            
        }
        public void Help()
        {
            Console.WriteLine("-------INSTRUCTION-------");
            Console.WriteLine("\tDIRECTORY\n");
            Console.WriteLine("[md + name] - create new directory");
            Console.WriteLine("[rd + link] - remove directory");
            Console.WriteLine("[cd + link] - change directory");
            Console.WriteLine("[dir] - info directory");
            Console.WriteLine("\tFILES\n");
            Console.WriteLine("[create + name + text] - create new file and write text");
            Console.WriteLine("[type + name] - show info file");
            Console.WriteLine("[copy + name + new name] - copy file");
            Console.WriteLine("[del + name] - remove file");
            Console.WriteLine("[append + name] - append file");
            Console.WriteLine("-------------------------");
        }

        public void Dir()
        {
            //Console.WriteLine("\n_______DIRS AND FILES");
            string[] entries = Directory.GetFileSystemEntries(".");
            foreach (var item in entries)
            {
                string info;
                if (File.GetAttributes(item) != FileAttributes.Directory)
                {
                    FileInfo fi = new FileInfo(item);
                    info = $"{fi.Length}";
                    Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");
                }
                else
                {
                    info = "<DIR>";
                }
                Console.WriteLine($" {info,-10}{Path.GetFileName(item),-35}{File.GetCreationTime(item),-15}");
            }
        }
        public void ChangeDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }
        public void RemoveDirectory(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path);
            else
                Console.WriteLine("Folder don't exist!");
        }
        public void AddDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            else
                Console.WriteLine("Folder is exist!");
        }
        public void CreateFile(string path,string message)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, message);
            else
                Console.WriteLine($"Error! Path {path} is exist!");
        }
        public void InfoFile(string path)
        {
            Console.WriteLine("\t---\tFILES\t---\t");
            string[] files = Directory.GetFiles(".");
            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);
                Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");
            }
        }
        public void CopyFile(string path,string newPath)
        {
            FileInfo fi = new FileInfo(path);
            fi.CopyTo(newPath);
        }
        public void RemoveFile(string path)
        {
            if(File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine($"Erro! Path {path} don't exists!");
        }
        public void ApendFile(string path,string str)
        {
            if(File.Exists(path))
                File.AppendAllText(path, str);
            else
                Console.WriteLine("File don't exit!");
        }

    }
}
