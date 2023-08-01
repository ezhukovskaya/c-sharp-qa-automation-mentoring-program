## Preconditions / Post conditions

### What is Preconditions / Post conditions?

Preconditions and post conditions are vital in software testing and development to ensure certain conditions are met before and after executing a test case or code block. In C#, NUnit, and Selenium automation, preconditions set up the initial state, and post conditions define the expected state after the test. They enhance test reliability, repeatability, and help identify and fix defects.

### Useful links

- [NUnit Documentation - [OneTimeSetUp]](https://docs.nunit.org/articles/nunit/writing-tests/attributes/onetimesetup.html)
- [NUnit Documentation - [OneTimeTearDown]](https://docs.nunit.org/articles/nunit/writing-tests/attributes/onetimeteardown.html)
- [NUnit Documentation - [SetUp]](https://docs.nunit.org/articles/nunit/writing-tests/attributes/setup.html)
- [NUnit Documentation - [TearDown]](https://docs.nunit.org/articles/nunit/writing-tests/attributes/teardown.html)

### Profit from usage of Preconditions / Post conditions constructions

In NUnit, there are two important attributes that can be used to set up and tear down test fixtures and tests:

- **[SetUp]**: This attribute is used to denote a method that will be executed before each test method in the test fixture. It helps in preparing the necessary test data and environment before each test execution.
- **[TearDown]**: This attribute is used to denote a method that will be executed after each test method in the test fixture. It helps in cleaning up the test environment and resources after each test execution.

<table style="width: 200%;">
  <tr>
    <td align="center">Without Conditions</td>
    <td align="center">With Conditions</td>
  </tr>
  <tr>
    <td valign="top">
      <pre><code>using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
<br>
[TestFixture]
public class WithoutSetUpAndTearDownExample
{
  private IWebDriver driver;

    [Test]
    public void Test1()
    {
        // Initialize the WebDriver
        driver = new ChromeDriver();

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("NUnit Selenium");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsTrue(driver.Title.Contains("NUnit Selenium"));

        // Close the browser
        driver.Quit();
    }

    [Test]
    public void Test2()
    {
        // Initialize the WebDriver
        driver = new ChromeDriver();

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("2");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsFalse(driver.Title.Contains("NUnit Selenium"));

        // Close the browser
        driver.Quit();
    }
}
</code></pre>
</td>
<td>
   <pre><code>using NUnit.Framework;using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
<br>
[TestFixture]
public class WithSetUpAndTearDownExample
{
  private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        // This method is executed before each test method.

        // Initialize the WebDriver
        driver = new ChromeDriver();
    }

    [TearDown]
    public void Teardown()
    {
        // This method is executed after each test method.

        // Close the browser
        driver.Quit();
    }

    [Test]
    public void Test1()
    {
        // No need to explicitly initialize WebDriver here, it's done in SetUp.

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("NUnit Selenium");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsTrue(driver.Title.Contains("NUnit Selenium"));
    }

    [Test]
    public void Test2()
    {
        // No need to explicitly initialize WebDriver here, it's done in SetUp.

        // Navigate to another website or perform different actions
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("2");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsFalse(driver.Title.Contains("NUnit Selenium"));
    }
}
</td>
  </tr>
</table>

#### Without SetUp and TearDown:

In this approach, the test setup and teardown are explicitly repeated within each test method. It can lead to code duplication and maintenance challenges.

#### With SetUp and TearDown:

In this approach, the SetUp method is executed before each test method, and the TearDown method is executed after each test method. It reduces code duplication and ensures a clean setup and teardown for each test, promoting consistency in test execution.

- **[OneTimeSetUp]**: This attribute is used to denote a method that will be executed only once and before all tests the suit in the test fixture. It helps in preparing the necessary test data and environment before each test execution.
- **[OneTimeTearDown]**: This attribute is used to denote a method that will be executed only once and after all tests the suit in the test fixture. It helps in cleaning up the test environment and resources after each test execution.

<table style="width: 200%;">
  <tr>
    <td align="center">Without Conditions</td>
    <td align="center">With Conditions</td>
  </tr>
  <tr>
    <td valign = "top">
      <pre><code>using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
<br>
[TestFixture]
public class WithoutSetUpAndTearDownExample
{
  private IWebDriver driver;

    [Test]
    public void Test1()
    {
        // Initialize the WebDriver
        driver = new ChromeDriver();

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("NUnit Selenium");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsTrue(driver.Title.Contains("NUnit Selenium"));

        // Close the browser
        driver.Quit();
    }

    [Test]
    public void Test2()
    {
        // Initialize the WebDriver
        driver = new ChromeDriver();

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("2");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsFalse(driver.Title.Contains("NUnit Selenium"));

        // Close the browser
        driver.Quit();
    }
}
</code></pre>
</td>
<td>
   <pre><code>using NUnit.Framework;using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
<br>
[TestFixture]
public class WithSetUpAndTearDownExample
{
  private IWebDriver driver;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        // This method is executed once before all test methods.

        // Initialize the WebDriver
        driver = new ChromeDriver();
    }

    [SetUp]
    public void Setup()
    {
        // This method is executed before each test method.

        // Navigate to the website
        driver.Navigate().GoToUrl("https://www.example.com");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        // This method is executed once after all test methods.

        // Close the browser
        driver.Quit();
    }

    [Test]
    public void Test1()
    {
        // No need to explicitly initialize WebDriver here, it's done in SetUp.
        // No need to navigate to the website.

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("NUnit Selenium");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsTrue(driver.Title.Contains("NUnit Selenium"));
    }

    [Test]
    public void Test2()
    {
        // No need to explicitly initialize WebDriver here, it's done in SetUp.
        // No need to navigate to the website.

        // Perform test actions using driver
        // For example, find elements and interact with them:
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("2");
        searchInput.Submit();

        // Assert the test results
        // For example, verify if the search results page is displayed:
        Assert.IsFalse(driver.Title.Contains("NUnit Selenium"));
    }
}
</td>
  </tr>
</table>

#### Without OneTimeSetUp and OneTimeTearDown:

In this approach, the test setup and teardown are explicitly repeated within each test method. It can lead to code duplication and maintenance challenges.

#### With SetUp and TearDown:

- **Reduced Code Duplication**: WebDriver initialization and website navigation are performed once for all test methods, reducing redundancy.
- **Faster Test Execution**: Single initialization speeds up test runs by avoiding redundant browser setups. 
- **Isolated Test Methods**: Each test focuses solely on its actions without interfering with others. 
- **Reliable Test Results**: Ensures a clean browser state before and after each test for consistent results. 
- **Clearer Test Intentions**: Separates one-time setup from per-test setup for better code readability. 
- **Efficient Browser Teardown**: Closes the browser only once after all test methods finish execution.

### Using these attributes provides several benefits:

- **Test Isolation**: Each test is executed in its own isolated environment, ensuring that any changes made by one test do not affect subsequent tests.
- **Reusability**: Common setup and teardown steps can be encapsulated in methods and reused across multiple test cases, reducing code duplication.
- **Readability**: Separating setup and teardown logic from the actual test code improves the readability and maintainability of test cases.


