using System;
using System.Threading.Tasks;
using System.IO;

namespace AsyncAwaitConsoleApp
{

    class Program
    {
        static async Task<string>ReadTxtFile()
        {
            using var sr = new StreamReader(File.Open("test.txt", FileMode.Open));
            await Task.Delay(1000);
            return await sr.ReadToEndAsync();
        }
        static async Task<string> ReadFile1()
        {
            await Task.Delay(3000);
            return "file1";
        }

        static async Task<string> ReadFile2()
        {
            await Task.Delay(4000);
            return "file2";
        }

        static async Task<string> ReadFile3()
        {
            await Task.Delay(2000);
            return "file3";
        }

        static async Task<int> Sum(int a, int b)
        {
            var result = await Task.FromResult(a + b); //create task given value
            return result;
        }

        //another way to do
        static async Task<int> Sum2(int a, int b)
        {
            var result = await Task.Run(() =>
            {
                return a + b;
            });
            return result;
        }

        static async Task DoSomething()
        {
            await Task.Delay(2000);
        }


        static void Main()
        {
            var task1 = ReadFile1();
            var task2 = ReadFile2();
            var task3 = ReadFile3();
            var taskRead = ReadTxtFile();

            var start = DateTime.Now;
            var taskSum = Sum(2, 2);
            var taskSum2 = Sum2(3, 5);
            var taskDelay = DoSomething();

            Task.WaitAny(task1, task2, task3);
            Console.WriteLine("Task1, completed: {0}", task1.IsCompleted);
            Console.WriteLine("Task2, completed: {0}", task2.IsCompleted);
            Console.WriteLine("Task2, completed: {0}", task3.IsCompleted);
            Console.WriteLine("Task3, completed: {0}", task3.Result);

            Console.WriteLine("taskRead, completed: {0}",taskRead.IsCompleted);
            Console.WriteLine("taskRead completed result: {0}", taskRead.Result);

            Task.WaitAll(taskSum, taskSum2, taskDelay);

            var twoTasks = Task.WhenAll(taskSum, taskDelay);
            var end = DateTime.Now;
            Console.WriteLine("Time taken! {0}", end - start);
        }
    }
}
