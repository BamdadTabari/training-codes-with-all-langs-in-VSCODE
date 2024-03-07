// See https://aka.ms/new-console-template for more information
using System.Reflection; // To use Assembly, TypeName, and so on
using static System.Console;
 
// Get the assembly that is the entry point for this app.
Assembly? myApp = Assembly.GetEntryAssembly();

// If the previous line returned nothing then end the app.
if (myApp is null) return;
// Loop through the assemblies that my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly assemblies = Assembly.Load(name);
    // Declare a variable to count the number of methods.
    int methodCount = 0;
    // Loop through all the types in the assembly.
    foreach (TypeInfo typeInfo in assemblies.DefinedTypes)
    {
        // Add up the counts of all the methods.
        methodCount += typeInfo.GetMethods().Length;
    }
    // Output the count of types and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: assemblies.DefinedTypes.Count(),
    arg1: methodCount, 
    arg2: name.Name);
}
