First, we need to download the C# extension for Visual Studio Code

You need to download .NET Core SDK

For Ubuntu 18.04, we need to run the following commands...

    - First, to register Microsoft key and feed
        - wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
        - sudo dpkg -i packages-microsoft-prod.deb
    - Now, we need to install the .NET SDK
        - sudo add-apt-repository universe
        -sudo apt-get install apt-transport-https
        -sudo apt-get update
        -sudo apt-get install dotnet-sdk-2.2
   

cd to the folder where you want your project to be in

Run the following: dotnet new console -o myapp

This creates a basic console app in a directory called 'myapp'

Type 'code .' to open the project in visual studio code

Go to terminal inside of vs code, and type 'dotnet restore'

In the terminal, type 'dotnet run' to run the app

More on this at https://channel9.msdn.com/Blogs/dotnet/Get-started-VSCode-Csharp-NET-Core-Windows

If you have more than one .cs file in a project, then go to .csproj and change the <StartupObject></ StartUpObject>: If the root folder is Assignment1, then Assignment1.DisplayPrimeNumbers will run DisplayPrimeNumbers.cs
