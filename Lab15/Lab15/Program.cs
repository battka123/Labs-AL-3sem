using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

// Интерфейс, определяющий метод, вызываемый при изменении состояния директории
public interface IFileSystemObserver
{
    void OnFileSystemChanged(string path);
}

// Реализация аналога класса FileSystemWatcher
public class FileSystemWatcherObserver : IFileSystemObserver
{
    private readonly string path;
    private readonly Timer timer;

    private Dictionary<string, DateTime> previousState;

    public event EventHandler<FileSystemChangedEventArgs> FileSystemChanged;

    public FileSystemWatcherObserver(string path, double timerIntervalInMilliseconds)
    {
        this.path = path;
        this.timer = new Timer(timerIntervalInMilliseconds);
        this.timer.Elapsed += TimerElapsed;

        previousState = new Dictionary<string, DateTime>();
    }

    public void Start()
    {
        timer.Start();
    }

    public void Stop()
    {
        timer.Stop();
    }

    public void OnFileSystemChanged(string changedPath)
    {
        var handler = FileSystemChanged;
        handler?.Invoke(this, new FileSystemChangedEventArgs(changedPath));
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        var currentState = new Dictionary<string, DateTime>();

        // Проверяем все файлы и директории в указанной директории
        foreach (var entry in Directory.GetFileSystemEntries(path))
        {
            var lastWriteTime = File.GetLastWriteTime(entry);
            currentState.Add(entry, lastWriteTime);

            // Если состояние файла/директории изменилось, вызываем событие
            if (!previousState.ContainsKey(entry) || previousState[entry] != lastWriteTime)
            {
                OnFileSystemChanged(entry);
            }
        }

        previousState = currentState;
    }
}

// Пользовательский класс, который подписывается на события FileSystemChanged
public class MyObserver : IFileSystemObserver
{
    public void OnFileSystemChanged(string path)
    {
        Console.WriteLine($"Изменено состояние файловой системы: {path}");
    }
}

// Аргументы события FileSystemChanged
public class FileSystemChangedEventArgs : EventArgs
{
    public string ChangedPath { get; }

    public FileSystemChangedEventArgs(string changedPath)
    {
        ChangedPath = changedPath;
    }
}

// Пример использования
class Program
{
    static void Main(string[] args)
    {
        var path = "C:\\Users\\hp\\Documents";

        var observer = new FileSystemWatcherObserver(path, 1000);
        observer.FileSystemChanged += OnFileSystemChanged;

        observer.Start();

        Console.WriteLine("Прослушивание начато. Нажмите Enter для остановки...");
        Console.ReadLine();

        observer.Stop();
    }

    private static void OnFileSystemChanged(object sender, FileSystemChangedEventArgs e)
    {
        Console.WriteLine($"Изменено состояние файловой системы: {e.ChangedPath}");
    }
}
