# 擴充與客製化 Prism-MAUI 的專案樣板

會用到的指令為

cd D:\Vulcan\GitHub\Prism-MAUI-Template\src

d:\nuget.exe pack D:\Vulcan\GitHub\Prism-MAUI-Template\Vulcan.Maui.Template.nuspec -outputdirectory d:\temp

dotnet new install d:\temp\Vulcan.Maui.Template.0.1.5.nupkg

dotnet new Vulcan-Maui -o d:\Temp\MyApp

dotnet new uninstall Vulcan.Maui.Template
