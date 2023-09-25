### C#

[Install .NET on Ubuntu](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-2204)

### .Net commands

check SDK + runtime version

```sh
dotnet --list-sdks
dotnet --list-runtimes
```

```sh
dotnet new console # to create a console project in .NET Core
dotnet restore # to restore packages and project dependencies
dotnet run # to execute our code.
```

run a program

```sh
dotnet run Program.cs
```

### Class Library (vscode)

1. create a solution

```sh
dotnet new sln --output FolderName # フォルダごと作成
dotnet new sln --name SolutionFileName # ファイル作成
```

2. create a class library project

```sh
dotnet new classlib -o libraryName
```
