using System;
using System.Threading;
using System.Threading.Tasks;

class SemaphoreExample
{
    private static readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
    private static bool showMessage = false;

    public static async Task Run()
    {
        Task printTask = PrintNumbersAsync();
        Task messageTask = ShowMessagePeriodicallyAsync();
        await Task.WhenAll(printTask, messageTask);
    }

    private static async Task PrintNumbersAsync()
    {
        while (true)
        {
            await semaphore.WaitAsync();
            try
            {
                if (!showMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("10");
                }
            }
            finally
            {
                semaphore.Release();
            }
            await Task.Delay(100);
        }
    }

    private static async Task ShowMessagePeriodicallyAsync()
    {
        while (true)
        {
            await Task.Delay(5000);
            await semaphore.WaitAsync();
            try
            {
                showMessage = true;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Neo, you are the chosen one");
            }
            finally
            {
                semaphore.Release();
            }

            await Task.Delay(5000);
            showMessage = false;
            Console.Clear();
        }
    }
}
