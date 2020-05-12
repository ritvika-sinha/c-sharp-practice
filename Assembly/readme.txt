As a .NET language, C# compiles code into assemblies. 

An assembly is a reusable piece of code, packaged into either an .exe or .dll file.  It contains IL (Intermediate Language) code that the CLR (Common Language Runtime) will compile into machine code at runtime.

An assembly contains a manifest, which defines high-level attributes of the assembly including its name, version, copyright information and an optional strong name that uniquely identifies it.

Assemblies also contain metadata, representing a complete description of all of the contained types.  

The metadata includes a description of each method and property of each type implemented in the assembly, along with information about the parameters and return type.  An assembly also includes a list of other assemblies that it references.

An assembly is typically packaged as a single .exe or .dll file, but can also be spread across more than one file.

When you execute a .NET program, the CLR (Common Language Runtime) loads the assembly located in the executable and then starts executing the code in the function defined as the entry point for that assembly.

If your assembly references a second assembly, that second assembly will only get loaded if its code is invoked at runtime.

This means that it makes sense to partition your application into assemblies, based on functionality and expected use.  If running a program typically only results in 20% of its code being executed, the most efficient partitioning would be to have the remaining 80% of the code in one or more assemblies other than the main assembly.  If code in one of these assemblies is never called, the assembly is never loaded.

Loading as few assemblies as possible is desirable, because this results in a smaller memory footprint for your program.