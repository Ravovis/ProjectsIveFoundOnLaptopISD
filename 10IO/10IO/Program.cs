using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace _10IO
{
    class Program
    {
        static class Task_1
        {
            public static void Execute()
            {
                Task_1_Creating();
                Task_1_Deleting();
            }
            static void Task_1_Creating()
            {
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (Directory.Exists("Folder_" + i))
                        {
                            Console.WriteLine("That path exists already:\t\t" + "Folder_" + i);
                            continue;
                        }
                        else
                        {
                            Directory.CreateDirectory("Folder_" + i);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            static void Task_1_Deleting()
            {
                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (Directory.Exists("Folder_" + i))
                        {
                            Directory.Delete("Folder_" + i);
                           
                           
                        }
                        else
                        {
                            Console.WriteLine("That path doesn't exists:\t\t" + "Folder_" + i);
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }


        static class Task_2
        {
            public static void Execute()
            {
                Task_2_Write();
                Task_2_Read();
            }
            static void Task_2_Write()
            {
                try
                {
                    if( File.Exists("task_2.txt") )
                    {
                        File.Delete("task_2.txt");
                    }
                    FileStream file1 = new FileStream("task_2.txt", FileMode.CreateNew);
                    StreamWriter writer = new StreamWriter(file1);
                    writer.Write("O, HI, JOHNY!");
                    writer.Close();

                }
                catch (Exception ex)
                {
                    
                }
            }
            static void Task_2_Read()
            {
                try
                {
                    if (File.Exists("task_2.txt"))
                    {
                        FileStream file1 = new FileStream("task_2.txt", FileMode.Open);
                        StreamReader reader = new StreamReader(file1);
                        Console.WriteLine(reader.ReadToEnd());
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        static class Task_3
        {
            public static void Execute()
            {
                try
                {
                    Console.WriteLine("Enter a path:");
                    string path = Console.ReadLine();
                    Console.WriteLine("What do you want to find?");
                    string pattern = Console.ReadLine();
                    string[] results = Directory.GetFiles(path, pattern);
                    Console.WriteLine("Results");
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine(results[i]);
                        FileStream file1 = new FileStream(results[i], FileMode.Open);
                        StreamReader reader = new StreamReader(file1);
                        Console.WriteLine(reader.ReadToEnd());
                        reader.Close();
                        Console.WriteLine("---------------------------------------");
                        

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception: " + ex);
                }
                    
            }
        }

        static void Main(string[] args)
        {
            Task_1.Execute();
            Task_2.Execute();
            Task_3.Execute();
        }
    }
}
