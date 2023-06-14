# R5T.F0135
MSBuild location operator.

NOTE: To do a basic Roslyn semantics operation, you need three packages:

1. Microsoft.CodeAnalysis.Workspaces.MSBuild (R5T.NG0020) - The actual Roslyn workspaces packages that allows you to open a .NET project file.
2. Microsoft.Build.Locator (R5T.NG0021) - Contains the MSBuildLocator type needed to locate MSBuild assemblies on the local machine.
	Required since the MSBuild Microsoft.CodeAnalysis.Workspaces package was used.
3. Microsoft.CodeAnalysis (R5T.NG0019) - Contains the Microsoft.CodeAnalysis.CSharp package, needed to open a C# projet file.
	Required since the project file is a C# project file.

These operations supplies only #2; you will need to supply #1 and #3 from elsewhere.


## Prior Work

* R5T.L0012.T001.X001 - Previous extension method base extensions of the same functionality.
* R5T.E0070 - Roslyn semantics experiment.
* R5T.E0030 - Great usage of MSBuildLocator.
* R5T.E0029 - First usage of MSBuildLocator.