# LearningNunit
#### To make the tests run in parallel the attribute below is used
```csharp
 [Parallelizable(ParallelScope.All)]
```
#### The following code tells that  Driver instance is unique for each thread
#### which will help to close all brower instances properply while parallel execution
```csharp
  [ThreadStatic]
  private static IWebDriver Driver;
```
#### To limit threads add the following to AssembleInfo.cs

```csharp
  [assembly: LevelOfParallelism(3)]
```
