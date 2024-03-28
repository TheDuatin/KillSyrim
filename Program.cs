using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        foreach (var process in Process.GetProcessesByName("SkyrimSE"))
        {
            process.Kill();
        }
    }
}
