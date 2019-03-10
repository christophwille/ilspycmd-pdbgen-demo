# How-To Generate a PDB on Build with ilspycmd

ilspycmd: https://github.com/icsharpcode/ILSpy/tree/master/ICSharpCode.Decompiler.Console

## A simple PDB generation scenario

To properly fake an assembly without PDB, the Sample3rdPartyDemoLibrary project copies the output dll to
the root of the solution  (see [copy code](/src/Sample3rdPartyDemoLibrary/Sample3rdPartyDemoLibrary.csproj#L11)).
The DemoApp project references the assembly from this location, and it has an [AfterBuild](/src/DemoApp/DemoApp.csproj#L18)
task that uses [ilspycmd](https://www.nuget.org/packages/ilspycmd/) to generate the PDB.

Program.cs in DemoApp has a Debugger.Break statement, so simply F5-ing is fine after build. You should be able to [step into Add](/src/DemoApp/Program.cs#L14).
