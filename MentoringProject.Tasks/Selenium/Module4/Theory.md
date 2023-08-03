## Browser Factory pattern

### Goal of using Browser Factory Pattern
The Browser Factory Pattern is a design pattern used in test automation to create WebDriver instances in a centralized 
and flexible manner. The main goals of using the Browser Factory Pattern are:

1. **Encapsulation**: The Browser Factory encapsulates the WebDriver initialization logic, providing a single place to 
manage the instantiation of WebDriver objects. This reduces code duplication and promotes better code organization. 
2. **Flexibility**: By centralizing WebDriver instantiation, the Browser Factory allows you to switch between different 
browsers (e.g., Chrome, Firefox, Edge) or change browser configurations (e.g., headless mode) easily without modifying 
the entire test suite. 
3. **Test Parallelization**: The Browser Factory enables test parallelization by providing a thread-safe approach to create 
separate WebDriver instances for each test thread, preventing interference between test cases.

### Useful links

- [Browser Factory or WebDriver Factory](https://toolsqa.com/selenium-webdriver/c-sharp/browser-factory/):
  A comprehensive tutorial on using Selenium with C# and NUnit, including the implementation of the Browser Factory Pattern.


### What can be in BrowserFactory.cs

#### Example Structure for BrowserFactory.cs:

```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

public class BrowserFactory
{
    private static IWebDriver driver;

    public static IWebDriver GetDriver(BrowserType browserType)
    {
        if (driver == null)
        {
            driver = CreateDriverInstance(browserType);
        }
        return driver;
    }

    private static IWebDriver CreateDriverInstance(BrowserType browserType)
    {
        IWebDriver driver = null;
        switch (browserType)
        {
            case BrowserType.Chrome:
                driver = new ChromeDriver();
                break;
            case BrowserType.Firefox:
                driver = new FirefoxDriver();
                break;
            case BrowserType.Edge:
                driver = new EdgeDriver();
                break;
            // Add cases for other browsers if needed
            default:
                throw new NotSupportedException($"Browser type '{browserType}' is not supported.");
        }

        return driver;
    }

    public static void CloseDriver()
    {
        if (driver != null)
        {
            driver.Quit();
            driver = null;
        }
    }
}

public enum BrowserType
{
    Chrome,
    Firefox,
    Edge
    // Add other supported browsers here
}
```

1. The `GetDriver` method is used to retrieve the `WebDriver` instance based on the specified `BrowserType`. If the driver is 
not initialized yet, it calls the `CreateDriverInstance` method to create and initialize the WebDriver.

```csharp
public class BrowserFactory
{
    private static IWebDriver driver;

    public static IWebDriver GetDriver(BrowserType browserType)
    {
        if (driver == null)
        {
            driver = CreateDriverInstance(browserType);
        }
        return driver;
    }
```

2. In this method, `CreateDriverInstance`, we handle the instantiation of the appropriate `WebDriver` based on the 
`BrowserType` provided. Currently, it supports **Chrome**, **Firefox**, and **Edge** browsers, but you can add more 
cases for other browsers if required.

```csharp
private static IWebDriver CreateDriverInstance(BrowserType browserType)
{
    IWebDriver driver = null;
    switch (browserType)
    {
        case BrowserType.Chrome:
            driver = new ChromeDriver();
            break;
        case BrowserType.Firefox:
            driver = new FirefoxDriver();
            break;
        case BrowserType.Edge:
            driver = new EdgeDriver();
            break;
        // Add cases for other browsers if needed
        default:
            throw new NotSupportedException($"Browser type '{browserType}' is not supported.");
    }
    return driver;
}
```

3. The `CloseDriver` method is responsible for closing the `WebDriver` instance when it's no longer needed. It ensures that 
the `WebDriver` is properly terminated to free up system resources.

```csharp
public static void CloseDriver()
{
    if (driver != null)
    {
        driver.Quit();
        driver = null;
    }
}
```

4. This is an enumeration `BrowserType` that defines the supported browser options. You can add additional browsers here 
if you want to extend the supported browser types

```csharp
public enum BrowserType
{
    Chrome,
    Firefox,
    Edge
    // Add other supported browsers here
}
```

#### Example Usage:

```csharp
[TestFixture]
public class TestClass
{
    private IWebDriver driver;

    [SetUp]
    public void TestSetup()
    {
        // Choose the browser type here (e.g., BrowserType.Chrome, BrowserType.Firefox, etc.)
        driver = BrowserFactory.GetDriver(BrowserType.Chrome);
        // Other setup steps, if any
    }

    [Test]
    public void TestMethod()
    {
        // Your test code here
    }

    [TearDown]
    public void TestTeardown()
    {
        // Close the browser after the test
        BrowserFactory.CloseDriver();
    }
}
```
In this example, you have a test class `TestClass` containing a test method (`TestMethod`). In the `[SetUp]` method, 
you request the `WebDriver` instance by calling `BrowserFactory.GetDriver(BrowserType.Chrome)`, which returns 
the `WebDriver` for Chrome. The test method contains your actual test code, and in the `[TearDown]` method, 
you close the browser using `BrowserFactory.CloseDriver()`, which ensures the `WebDriver` is properly closed and 
resources are released.

### Conclusion

By using the Browser Factory Pattern as demonstrated in these examples, you can achieve a more organized and flexible 
test suite, allowing easy switching between browsers and facilitating parallel test execution with different browsers 
in your C# NUnit and Selenium test automation projects.