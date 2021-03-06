# How-To Generate a PDB on Build with ilspycmd

ilspycmd: https://github.com/icsharpcode/ILSpy/tree/master/ICSharpCode.Decompiler.Console

## A simple PDB generation scenario

To properly fake an assembly without PDB, the Sample3rdPartyDemoLibrary project copies the output dll to
the root of the solution  (see [copy code](/src/Sample3rdPartyDemoLibrary/Sample3rdPartyDemoLibrary.csproj#L11)).
The DemoApp project references the assembly from this location, and it has an [AfterBuild](/src/DemoApp/DemoApp.csproj#L18)
task that uses [ilspycmd](https://www.nuget.org/packages/ilspycmd/) to generate the PDB.

NOTE: You must install https://www.nuget.org/packages/ilspycmd/5.0.0-preview1 as a global tool at the moment!

`dotnet tool install --global ilspycmd --version 5.0.0-preview1`

Program.cs in DemoApp has a Debugger.Break statement, so simply F5-ing is fine after build. You should be able to [step into Add](/src/DemoApp/Program.cs#L14).

## The Real World

You would use ilspycmd to pre-generate the PDB, and not do it on every build.
