using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_10
{
   
class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Document Management System!");
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Read a file");
                Console.WriteLine("3. Append to a file");
                Console.WriteLine("4. Delete a file");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the file name:");
                        string createFileName = Console.ReadLine();
                        Console.WriteLine("Enter the file content:");
                        string createFileContent = Console.ReadLine();
                        CreateFile(createFileName, createFileContent);
                        break;
                    case 2:
                        Console.WriteLine("Enter the file name to read:");
                        string readFile = Console.ReadLine();
                        ReadFile(readFile);
                        break;
                    case 3:
                        Console.WriteLine("Enter the file name to append:");
                        string appendFileName = Console.ReadLine();
                        Console.WriteLine("Enter the content to append:");
                        string appendContent = Console.ReadLine();
                        AppendToFile(appendFileName, appendContent);
                        break;
                    case 4:
                        Console.WriteLine("Enter the file name to delete:");
                        string deleteFileName = Console.ReadLine();
                        DeleteFile(deleteFileName);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            static void CreateFile(string fileName, string content)
            {
                try
                {
                    using (StreamWriter writer = File.CreateText(fileName))
                    {
                        writer.Write(content);
                    }
                    Console.WriteLine("File created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating file: " + ex.Message);
                }
            }

            static void ReadFile(string fileName)
            {
                try
                {
                    string fileContent = File.ReadAllText(fileName);
                    Console.WriteLine("File content:");
                    Console.WriteLine(fileContent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading file: " + ex.Message);
                }
            }

            static void AppendToFile(string fileName, string content)
            {
                try
                {
                    using (StreamWriter writer = File.AppendText(fileName))
                    {
                        writer.Write(content);
                    }
                    Console.WriteLine("Content appended to the file successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error appending to file: " + ex.Message);
                }
            }

            static void DeleteFile(string fileName)
            {
                try
                {
                    File.Delete(fileName);
                    Console.WriteLine("File deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting file: " + ex.Message);
                }
            }
        }
    }
   

