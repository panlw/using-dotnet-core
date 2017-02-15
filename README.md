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

### Extensions

- C#

### Files in `.vscode`

- [`tasks.json`](https://code.visualstudio.com/Docs/editor/tasks)
- [`launch.json`](https://code.visualstudio.com/Docs/editor/debugging)
