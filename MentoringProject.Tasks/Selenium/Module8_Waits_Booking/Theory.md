# Waits

## Description

In Selenium automation testing, waits are essential for synchronizing the test script with the application's state.
Waits allow the script to pause execution until certain conditions are met, preventing errors caused by element
visibility, availability, or other dynamic content changes.

This MD file covers various types of waits in C# Selenium.
with NUnit, including Thread.Sleep, Implicit, Explicit, and Fluent waits, their differences in theory and practice,
reasons not to use Thread.Sleep, implementation of Explicit wait using WebDriverExtension, and a home task involving
hard interacting elements.

## Thread.Sleep - Why Not

The `Thread.Sleep` method is used to introduce a static delay in the test execution. However,
it's not the ideal way to handle waits in Selenium tests for the following reasons:

- Static Delays: `Thread.Sleep` introduces fixed delays, which can lead to unnecessary waiting or insufficient time
if the element is ready before the delay ends.
- Performance Impact: Using Thread.Sleep indiscriminately can slow down the test execution, leading to longer test times.
- Brittle Tests: Tests may fail due to varying load times or network conditions, making them unreliable.

```csharp
// Avoid using Thread.Sleep
Thread.Sleep(5000); // Wait for 5 seconds (not recommended)
```

## Explicit/Implicit/Fluent waits

### Implicit Wait

Implicit waits instruct the `WebDriver` to wait for a specified amount of time before throwing an
exception when an element is not immediately found. The `WebDriver` will wait for the element to appear for the defined
duration globally.

```csharp
// Set implicit wait globally (wait up to 10 seconds)
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

// Find element - WebDriver will wait up to 10 seconds for the element to be available
IWebElement element = driver.FindElement(By.Id("elementId"));
```

In this example, we set the implicit wait to 10 seconds. If the `FindElement` method is called and the element is not
immediately found, `WebDriver` will wait up to 10 seconds before throwing a `NoSuchElementException`.

### Explicit Wait

Explicit waits allow the `WebDriver` to wait for a specific condition to be satisfied before proceeding
further in the script. It provides more granular control, waiting for a particular element with a specific condition.

```csharp
// Implementing explicit wait with ExpectedConditions
var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("elementId")));
```

In this example, we create an explicit wait with a timeout of 10 seconds. The `ExpectedConditions.ElementIsVisible`
condition waits until the element with the ID "elementId" is visible on the page. If the element is not visible within
the specified timeout, the script will throw a `TimeoutException`.

### Fluent Wait

Fluent waits are an enhancement to explicit waits, allowing a more fluent and expressive way of defining
wait conditions. They can define polling frequency and exceptions to ignore.

```csharp
// Implementing fluent wait with ExpectedConditions
var fluentWait = new DefaultWait<IWebDriver>(driver);
fluentWait.Timeout = TimeSpan.FromSeconds(20);
fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

var dynamicElement = fluentWait.Until(driver => driver.FindElement(By.XPath("//div[contains(@id, 'dynamicElement_')]")));
```

In this example, we create a fluent wait with a timeout of 20 seconds and a polling interval of 500 milliseconds.
The `IgnoreExceptionTypes` method is used to ignore the `NoSuchElementException`, which means if the element is not found
during the polling, it will continue to wait. The Until method waits until the dynamic element with an ID containing
"dynamicElement_" is found on the page.

Using Fluent waits, you have more control over the polling frequency and exception handling, making it a powerful
option for handling complex waiting scenarios.

Remember that explicit and fluent waits are more recommended than implicit waits as they provide better control over
the wait conditions and make your tests more robust and reliable.

### Why Not Always Use Implicit?

While implicit waits may seem easier to implement, they suffer from some limitations:

- Global Impact: Implicit waits apply to all elements, which can lead to unnecessarily long waits in some cases.
- Limited Flexibility: Implicit waits only allow defining a single timeout for all elements, which might not be
suitable for complex scenarios.
- Difficulty in Debugging: Debugging issues related to implicit waits can be challenging since it's applied globally.

```csharp
// Avoid using implicit wait globally
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Not recommended
```

### Implementation of Explicit Wait into WebDriverExtension class

To make explicit waits more manageable and reusable, you can create a custom WebDriverExtension class with extension
methods:

```csharp
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public static class WebDriverExtensions
{
    public static IWebElement WaitForElementVisible(this IWebDriver driver, By locator, int timeoutInSeconds)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        return wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }
}
```

In this code, we create a static class `WebDriverExtensions` to add extension methods to the `IWebDriver` interface.
The extension method `WaitForElementVisible` takes three parameters: the `IWebDriver` instance, the `By` locator to find the
element, and the `timeout` in seconds for waiting.

Inside the method, we create a new `WebDriverWait` instance with the provided timeout. We use the
`ExpectedConditions.ElementIsVisible` condition to wait until the element identified by the By locator becomes visible
on the page. If the element is not visible within the specified timeout, a `TimeoutException` will be thrown.

With this extension method, you can now use `WaitForElementVisible` directly on your `IWebDriver` instances:

```csharp
// Example usage of the extension method
var driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://www.example.com");

var element = driver.WaitForElementVisible(By.Id("elementId"), 10);
```

Now you can call `WaitForElementVisible` on any `IWebDriver` instance to wait for an element to become visible with the
specified timeout. This helps in creating more maintainable and reusable code for explicit waits in your Selenium tests.

## Useful Links

- [Official Selenium Documentation](https://www.selenium.dev/documentation/en/)
- [NUnit Framework Documentation](https://docs.nunit.org/)
- [Waiting Strategies](https://www.selenium.dev/documentation/webdriver/waits/)

Remember, efficient use of waits is crucial for creating robust and reliable Selenium tests.
Always prefer explicit and fluent waits over Thread.Sleep, and tailor the waits according to specific elements and
conditions to improve test stability and performance.
