# Stringer.Nuget

*A lightweight C# utility library for common string operations.*

## 🚀 Features

- Convert strings to Title Case.

## 📦 Installation

1. Add the GitHub package source to your `NuGet.Config`:

   ```xml
   <configuration>
     <packageSources>
       <add key="github" value="https://nuget.pkg.github.com/YOUR_GITHUB_USERNAME/index.json" />
     </packageSources>
   </configuration>
   ```

2. Install the package using the .NET CLI:

   ```sh
   dotnet add package Stringer.Nuget --source "https://nuget.pkg.github.com/YOUR_GITHUB_USERNAME/index.json"
   ```

## 🛠️ Usage

```csharp
using Stringer.Nuget;

string title = StringFormatter.ToTitleCase("hello world");
Console.WriteLine(title); // Output: Hello World

string reversed = StringFormatter.ReverseString("hello");
Console.WriteLine(reversed); // Output: olleh
```

## 💻 Development

Clone the repository and build the project:

```sh
git clone https://github.com/YOUR_GITHUB_USERNAME/Stringer.Nuget.git
cd Stringer.Nuget
dotnet build
dotnet test
```

## ⚖️ License

Licensed under the [MIT License](LICENSE).
