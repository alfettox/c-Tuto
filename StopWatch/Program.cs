using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Press any key to launch the timer");
        Console.ReadKey();

        var stopWatch = new StopWatch();

        try
        {
            var stopTask = stopWatch.StartAsync();

            Console.WriteLine("Press any key to stop the timer");
            Console.ReadKey();

            await stopWatch.StopAsync(stopTask);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("Press any key to list all elapsed times");
        Console.ReadKey();
        printListElapsedTimes(stopWatch.GetTimers());
    }

    private static void printListElapsedTimes(IEnumerable<TimeSpan> timers)
    {
        foreach (var timer in timers)
        {
            Console.WriteLine(timer.ToString());
        }
    }
}

class StopWatch
{
    private DateTime _startTime;
    private bool _isRunning;
    private readonly List<TimeSpan> _timers = new List<TimeSpan>();
    private CancellationTokenSource _cancellationTokenSource;

    public IEnumerable<TimeSpan> GetTimers()
    {
        return new List<TimeSpan>(_timers);
    }

    public async Task StartAsync()
    {
        if (_isRunning)
        {
            throw new InvalidOperationException("ALREADY RUNNING");
        }

        _startTime = DateTime.Now;
        _isRunning = true;

        _cancellationTokenSource = new CancellationTokenSource();

        // Run the timer and animation asynchronously
        await Task.Run(async () =>
        {
            while (_isRunning)
            {
                Animation();
                await Task.Delay(500);
            }
        }, _cancellationTokenSource.Token);
    }

    private void Animation()
    {
        Console.Write(".");
    }

    public async Task StopAsync(Task animationTask)
    {
        if (!_isRunning)
        {
            throw new InvalidOperationException("Timer is not running");
        }

        _isRunning = false;
        _cancellationTokenSource.Cancel();

        // Wait for the animation task to complete
        await animationTask;

        TimeSpan elapsedTime = GetInterval(_startTime);
        _timers.Add(elapsedTime);
        PrintTime(elapsedTime);
    }

    public TimeSpan GetInterval(DateTime startTime)
    {
        DateTime endTime = DateTime.Now;
        return endTime - startTime;
    }

    public void PrintTime(TimeSpan elapsedTime)
    {
        Console.WriteLine($"Elapsed Time: {elapsedTime.TotalMilliseconds} milliseconds");
    }
}
