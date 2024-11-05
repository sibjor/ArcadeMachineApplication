using System.IO;

namespace ArcadeMachineLauncher
{
    public class DirectoryManeuver
    {
        // Get directories from the games folder
        public string[] DirectoryMethod()
        {
            Directory.SetCurrentDirectory(@"..\..\..\..\..\..\games");
            return Directory.GetDirectories(@".\");
        }
    }
}