cd C:\Vulcan\Github\Prism-MAUI-Template\src

dotnet new uninstall Vulcan.Maui.Template

C:\temp\nuget.exe pack C:\Vulcan\Github\Prism-MAUI-Template\Vulcan.Maui.Template.nuspec -outputdirectory C:\temp

dotnet new install C:\temp\Vulcan.Maui.Template.0.5.5.nupkg

