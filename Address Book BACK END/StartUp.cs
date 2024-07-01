
// You may delete this if you want, it is just a file checker to make sure everything run well. I would still advise you to run the whole program before even trying
// to delete this
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Initializer
{
    internal static void _INIT()
    {
        if(!Directory.Exists($"{Directory.GetCurrentDirectory()}\\Core Files")) throw new DirectoryNotFoundException("\'Core Files\' directory cannot be found");
        string _coreFolder = $"{Directory.GetCurrentDirectory()}\\Core Files";
        if(!File.Exists(String.Concat(_coreFolder + "\\AddressBook.cs"))) throw new FileNotFoundException("Required file \'AddressBook.cs\' cannot be found");
        if(!File.Exists(String.Concat(_coreFolder + "\\CheckFile.cs"))) throw new FileNotFoundException("Required file \'CheckFile.cs\' cannot be found");
        //if(!File.Exists(String.Concat(_coreFolder + "\\Process.cs"))) throw new FileNotFoundException("Required file \'Process.cs\' cannot be found");
        if(!File.Exists(String.Concat(_coreFolder + "\\RequireDependencies.cs"))) throw new FileNotFoundException("Required file \'RequireDependencies.cs\' cannot be found");
    }
}