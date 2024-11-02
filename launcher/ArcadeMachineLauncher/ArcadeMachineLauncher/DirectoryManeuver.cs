using System.IO;

namespace ArcadeMachineLauncher;

public class DirectoryManeuver
{
    
    // GetDirectory & GetFiles shall be used
    public void DirectoryMethod()
    {
        Directory.SetCurrentDirectory(@"..\..\..\..\..\..\games");
        Console.WriteLine(Directory.GetCurrentDirectory());
        
        string[] directories = Directory.GetDirectories(@".\");
        
        foreach (var dir in directories)
        {
            Console.WriteLine(dir);
        }
    }
}