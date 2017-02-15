# Using .NET Core

## Guide

- [.NET Docs](https://docs.microsoft.com/zh-cn/dotnet/)
- [.NET Core API](https://docs.microsoft.com/zh-cn/dotnet/core/api/)
- [C# Guide](https://www.microsoft.com/net/tutorials/csharp/getting-started)


## Articles

- [Reducing Package Dependencies with project.json](https://docs.microsoft.com/en-us/dotnet/articles/core/deploying/reducing-dependencies)


## Examples

- [Inheritance Inversion](https://www.codeproject.com/tips/860271/inheritance-inversion)
    ```csharp
    public class WeekDaysChron : AbstractSingletonList<Day, WeekDaysChron> { /* ... */ }

    WeekDaysChron.All.ForEach(day => Console.WriteLine(day));
    ```


## [VSCode Guide](https://code.visualstudio.com/Docs/)

### [Install for macOS 10.11+](https://www.microsoft.com/net/core#macos)

1. Install pre-requisites
    ```sh
    brew update
    brew install openssl
    mkdir -p /usr/local/lib
    ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
    ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/
    ```
1. Install .NET Core SDK
    [Download .NET Core SDK](https://go.microsoft.com/fwlink/?LinkID=835011)
1. Initialize some code
    ```sh
    mkdir using-dotnet-core
    cd using-dotnet-core
    dotnet new
    ```
1. Run the app
    ```sh
    dotnet restore
    dotnet run
    ```

### Extensions

- C#
    ```sh
    code --install-extension ms-vscode.csharp
    ```

### Files in `.vscode`

- [`tasks.json`](https://code.visualstudio.com/Docs/editor/tasks)
- [`launch.json`](https://code.visualstudio.com/Docs/editor/debugging)


## Tools

### markdownlint

- [markdownlint demo](https://dlaa.me/markdownlint/)
- [markdownlint rules](https://github.com/DavidAnson/markdownlint/blob/master/doc/Rules.md)
- [markdownlint extension for vscode](https://github.com/DavidAnson/vscode-markdownlint/)
    ```sh
    code --install-extension DavidAnson.vscode-markdownlint
    ```
