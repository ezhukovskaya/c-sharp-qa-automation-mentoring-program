# Parallel Test Execution

## Introduction

Parallel Test Execution is a process of distributing the execution of tests on different subsystems to reduce the test 
time. It's a great way to improve the overall test execution speed, especially when the test suite grows large. Selenium
4 introduced new features for this process, making it easier in C#.

>  WARNING:
> When tests are run in parallel, you are responsible for the thread safety of your tests. Tests that run at the same
time and modify instance fields or properties without locks will cause unexpected behavior as they would in any
multi-threaded program.

## Useful Links

- [Official Selenium Documentation](https://www.selenium.dev/documentation/)
- [Framework Parallel Test Execution](https://docs.nunit.org/articles/nunit/technical-notes/usage/Framework-Parallel-Test-Execution.html)
- [Managed threading best practices](https://learn.microsoft.com/en-us/dotnet/standard/threading/managed-threading-best-practices)

## NUnit Parallelizable Attributes

### `ParallelizableAttribute`

`ParallelizableAttribute` marks test fixtures and methods to be run in parallel with others. 
This attribute can be applied at the assembly, class (`TestFixture`), and method (`Test`) level.

#### Example Usages of `ParallelizableAttribute`

```csharp
[TestFixture]
[Parallelizable]
public class TestClass
{
    [Test]
    public void TestMethod1() { /*...*/ }
    
    [Test]
    [Parallelizable]
    public void TestMethod2() { /*...*/ }
}
```
In the above example, TestMethod2 will run in parallel with other marked tests or classes. 
Providing no arguments to Parallelizable is equivalent to specifying `ParallelScope.Self`.

### `NonParallelizableAttribute`

`NonParallelizableAttribute` marks test fixtures and methods that must not be run in parallel with others. 
This attribute also can be applied at the assembly, class, and method level.

#### Example Usage of `NonParallelizableAttribute`
```csharp
[TestFixture]
[NonParallelizable]
public class TestClass
{
    [Test]
    public void TestMethod1() { /*...*/ }
    
    [Test]
    public void TestMethod2() { /*...*/ }
}
```
In the above example, no tests in `TestClass` will run in parallel due to the `NonParallelizableAttribute`.

### ParallelScope Enumeration

ParallelScope is an enumeration that has multiple options which can provide different levels of parallelism:
- `ParallelScope.None`: No tests within the scope may be run in parallel. 
- `ParallelScope.Self`: The test itself may be run in parallel with other top-level tests. 
- `ParallelScope.Children`: Descendant tests may be run in parallel with each other. 
- `ParallelScope.Fixtures`: Test fixtures may be run in parallel with each other. 
- `ParallelScope.All`: Equivalent to `ParallelScope.Self | ParallelScope.Children`, i.e., 
the test and its descendants may be run in parallel.

#### Example Usage of `ParallelScope` Enumeration

```csharp
[TestFixture]
[Parallelizable(ParallelScope.Children)]
public class TestClass
{
    [Test]
    public void TestMethod1() { /*...*/ }
    
    [Test]
    public void TestMethod2() { /*...*/ }
}
```
In the above example, `TestMethod1` and `TestMethod2` will run in parallel.

### `LevelOfParallelismAttribute`

`LevelOfParallelismAttribute` sets the maximum level of parallelism. It's an assembly-level attribute.

`LevelOfParallelism` is an assembly level attribute. This means that it should be placed in a `*.cs` file in your project 
which will apply to the entire assembly (your project). This file is often the `AssemblyInfo.cs` file.
The `AssemblyInfo.cs` resides in the Properties folder of your project. If you can't find this file, you can manually 
create a new one. Follow these steps:
1. In the Solution Explorer, right-click your project. 
2. Click “Add” and then select “New Item”. 
3. In the Add New Item dialog box, select “Assembly Information File”.

Now, you have the AssemblyInfo.cs file in your project. Open this file and add the LevelOfParallelism attribute as follows:
```csharp
[assembly: LevelOfParallelism(3)]
```
The number 3 indicates the max number of concurrent threads that NUnit may use to run the tests. You can replace 3 
with any number based on your system's capacity.
A more direct approach is to add it under any *.cs file within the root of the namespace. Because this is an assembly 
level attribute, it doesn't matter much where it is placed as long as it's within the namespace scope.
But, keeping it inside AssemblyInfo.cs is a common practice as it provides a central location for all assembly level 
metadata. This way, it becomes easier to manage this information.
Remember to add this line at the top of your file to use `[assembly: LevelOfParallelism(n)]`:
```csharp
using NUnit.Framework;
```

## Thread Safety

Test execution can involve various threads, each one possibly interacting with the WebDriver. 
This brings the necessity for thread safety to avoid conflicts. A thread-safe code ensures that the shared 
data structure manipulate in a manner that ensures the correct execution of the program. This is accomplished in 
Selenium by using `ThreadStatic` or `ConcurrentDictionary`.
Benefits of thread safety include:

- Preventing race conditions 
- Providing consistent test results 
- Allowing maximum utilization of resources through parallel test execution

### `ThreadStatic`

#### What is ThreadStatic?
ThreadStatic is an attribute in .NET that enables you to have one version of a variable for each thread. 
It indicates that the value of a static field is unique for each thread.

#### Why use ThreadStatic?

In the context of parallel testing, you might have multiple threads that each need their own WebDriver. Without 
`ThreadStatic`, you would have multiple threads trying to use a single WebDriver instance, which can cause conflicts. 
`ThreadStatic` helps avoid these conflicts by giving each thread its own WebDriver instance.

```csharp
[ThreadStatic]
private static IWebDriver driver;

public static IWebDriver Driver
{
    get
    {
        if (driver == null)
        {
            driver = new ChromeDriver();
        }
        return driver;
    }
}
```
In the above example, the Driver property ensures that each thread gets its own ChromeDriver instance. This is because 
driver is marked with the `[ThreadStatic]` attribute, which means a separate value is maintained for each thread.

#### Advantages
1. Simplicity: `ThreadStatic` is easy to use with simpler code as it becomes just a matter of adding an attribute to the 
variable declaration. 
2. Performance: It has slightly better performance as compared to ConcurrentDictionary as there's no overhead of 
maintaining a dictionary of values.

#### Disadvantages
1. Logic encapsulation: With ThreadStatic you have to ensure that the initialization code for the variable is run in 
every thread which uses it. For example, if you rely on a constructor to initialize a `ThreadStatic` variable, that 
constructor is called only once per application, not once per thread.
2. Cleanup: Cleaning up resources properly requires additional careful coding. You would need to manually close and 
cleanup the WebDriver for each thread that opens one.

### `ConcurrentDictionary`

#### What is ConcurrentDictionary?
ConcurrentDictionary is a thread-safe dictionary provided by .NET, allowing multiple threads to safely add or remove 
items without needing to lock the entire collection.

#### Why use ConcurrentDictionary?
In our case, it can be used to store a WebDriver instance associated with the id of a given thread or some different 
value like TestFixture. This allows your tests to run without interfering with each other since each thread has its own WebDriver.

```csharp
private static ConcurrentDictionary<int, IWebDriver> DriverCollection = 
    new ConcurrentDictionary<int, IWebDriver>();

public static IWebDriver Driver => DriverCollection.GetOrAdd(Thread.CurrentThread.ManagedThreadId, id => new ChromeDriver());
```

**OR**

```csharp
private static ConcurrentDictionary<string, IWebDriver> DriverCollection = 
    new ConcurrentDictionary<string, IWebDriver>();

public static IWebDriver Driver => DriverCollection.GetOrAdd(TestContext.CurrentContext.Test.ClassName, id => new ChromeDriver());
```

> **NOTE**: `TestContext.CurrentContext.Test.ClassName` is part of the NUnit testing framework, not Selenium itself. 
> It's used to access information about the current test being executed. Here's a detailed explanation of what it 
> is and how it works:
> 
> - `TestContext` is a class provided by NUnit that allows you to access information about the current test being executed.
> - `TestContext.CurrentContext` is a static property of the TestContext class. It provides access to the context of the 
> currently executing test. You can use it to retrieve information about the test being run.
> - `TestContext.CurrentContext.Test` is a property of the CurrentContext object, and it represents the test being executed. 
> It provides various properties and methods to access information about the current test, such as the test name, 
> test status, test case properties, and more.

In the above example, whenever a WebDriver is requested, the Driver property retrieves the WebDriver associated with 
the current thread's id or class name. If no such WebDriver exists, it creates a new one. This ensures that each thread gets its 
own WebDriver and can operate independently of other threads.

#### Advantages

1. Flexibility: `ConcurrentDictionary` is more flexible than `ThreadStatic` because it does not confine you to just working 
with threads. It can be used with Task or any other type of object as a key.
2. Explicit lifecycle control: It allows you to manage the lifecycle of WebDriver instances explicitly. You can start, 
stop, maintain, and clean up each WebDriver instance by just removing the key-value pair from the dictionary.

#### Disadvantages
1. Performance: `ConcurrentDictionary` has a bit of overhead because it needs to maintain a dictionary and deal with hashing and equality.
2. Complexity: The `ConcurrentDictionary` requires more complex code than using `ThreadStatic`.

In both examples, the goal is to allow each thread to have its own instance of WebDriver, allowing tests to run 
concurrently without interfering with each other. They provide thread safety in multithreading execution environments 
such as parallel test execution.