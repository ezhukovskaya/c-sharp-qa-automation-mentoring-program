## BaseTest

### Goal of using BaseTest

BaseTest provides a reusable template for writing test scripts in test automation. Its goals include code reusability, 
maintaining consistency, managing test configurations, and handling errors. The primary goals of using BaseTest are:

1. **Code Reusability**: BaseTest allows developers to encapsulate common functionalities and configurations required 
for setting up the test environment. This promotes code reuse and reduces duplication in test scripts, leading to more 
maintainable and scalable test suites.
2. **Consistency and Maintainability**: By centralizing common test setup and teardown operations in BaseTest, 
the test cases can focus on specific scenarios and business logic. This improves the overall consistency and 
maintainability of the test codebase.
3. **Test Configuration Management**: BaseTest can handle test configuration management, such as initializing the 
Selenium WebDriver, setting up the browser, handling timeouts, and other environment-specific settings. 
This ensures that test cases run consistently across different test environments.
4. **Error Handling and Reporting**: BaseTest can implement error handling mechanisms and provide consistent reporting 
for test failures. This aids in troubleshooting and diagnosing issues during test execution.

### Useful links

- [Test Fixture (NUnit Documentation)](https://docs.nunit.org/articles/nunit/writing-tests/attributes/testfixture.html): 
Understand the concept of Test Fixtures, which is the class containing your test methods, often derived from BaseTest, in NUnit.


### What can be in BaseTest

1. **Setup and Teardown**: BaseTest typically contains methods for setting up the test environment before executing 
each test case and cleaning up resources afterward. This may include initializing WebDriver, navigating to the 
application under test, and closing the browser after the test is complete.

```csharp
public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void TestSetup()
    {
        // Initialize WebDriver and navigate to the application
        // Code for browser setup goes here
    }

    [TearDown]
    public void TestTeardown()
    {
        // Close the browser and clean up resources
        driver.Quit();
    }
}
```
2. **Utility Methods**: BaseTest can include utility methods that are commonly used across test cases. These methods 
might perform actions like logging into the application, capturing screenshots, handling alerts, or waiting for specific 
conditions.

```csharp
public class BaseTest
{
    // Other code omitted for brevity

    public void Login(string username, string password)
    {
        // Code to log in to the application
    }

    public void CaptureScreenshot(string fileName)
    {
        // Code to capture a screenshot and save it with the given file name
    }
}
```
3. **Test Data Management**: BaseTest can provide mechanisms for managing test data, such as loading test data from 
external sources (e.g., Excel files, databases) or generating test data programmatically.

```csharp
public class BaseTest
{
    // Other code omitted for brevity

    public string GetTestData(string key)
    {
        // Code to retrieve test data using the provided key
    }
}
```

4. **Test Configuration**: BaseTest can handle test configuration parameters, such as URLs, browser types, timeouts, 
etc., allowing flexibility in test execution across different environments.

```csharp
public class BaseTest
{
    // Other code omitted for brevity

    public string GetApplicationURL()
    {
        // Code to retrieve the application URL from the configuration file
    }

    public TimeSpan GetElementTimeout()
    {
        // Code to retrieve the element timeout value from the configuration file
    }
}
```

By utilizing a well-structured BaseTest, test automation developers can build a strong foundation for their test cases, 
resulting in more efficient, maintainable, and reliable test suites.

Simple example of common BaseTest usage is provided in the following folder: [test](test)