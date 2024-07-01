cd C:\Vulcan\Github\Prism-MAUI-Template\src

C:\temp\nuget.exe pack C:\Vulcan\Github\Prism-MAUI-Template\Vulcan.Maui.Template.nuspec -outputdirectory C:\temp

dotnet new uninstall Vulcan.Maui.Template

dotnet new install C:\temp\Vulcan.Maui.Template.0.5.3.nupkg

