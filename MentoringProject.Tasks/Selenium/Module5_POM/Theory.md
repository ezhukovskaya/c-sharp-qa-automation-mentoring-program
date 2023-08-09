## Page Object pattern

### Goal of using Page Object Pattern
The Page Object Pattern is a design pattern commonly used in test automation to create a separation between the test 
code and the web elements of a web application. The main goals of using the Page Object Pattern are:

1. **Enhanced Readability and Maintainability**: By encapsulating the web elements and their interactions in separate 
Page Object classes, the test code becomes more readable and easier to maintain. Any changes to the UI can be localized 
to the corresponding Page Object, reducing the impact on test scripts.
2. **Code Reusability**: Page Object classes promote code reusability by providing reusable methods to interact with 
web elements across different test scenarios. When the web application changes, only the Page Object needs to be 
updated, rather than modifying multiple test cases.
3. **Improved Collaboration**: Page Objects act as a communication bridge between testers and developers. 
Testers can work on test scripts using Page Objects, while developers focus on maintaining the Page Object classes to 
reflect changes in the application.
4. **Parallel Test Execution**: Page Objects enable parallel test execution by providing thread-safe methods to 
interact with web elements, allowing multiple tests to run simultaneously without interference.

### Useful links

- [Page Object Pattern (Selenium Documentation)](https://www.selenium.dev/documentation/en/guidelines_and_recommendations/page_object_models/): Official documentation on using the Page Object Pattern with Selenium WebDriver in different programming languages, including C#.


### How it looks like

1. The Page Object Pattern is implemented by creating a separate Page Object class for each page or section of the web application. 
2. Each Page Object contains locators (e.g., XPath, CSS selectors) and methods to interact with the web elements on that page. 
3. The test scripts then use these Page Objects to perform actions on the web application.

#### Example Structure for LoginPage.cs (Page Object for Login Page):

```csharp
using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    // Locators for web elements on the Login page
    private readonly By usernameInput = By.Id("username");
    private readonly By passwordInput = By.Id("password");
    private readonly By loginButton = By.Id("loginButton");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Methods to interact with web elements on the Login page
    public void EnterUsername(string username) => driver.FindElement(usernameInput).SendKeys(username);

    public void EnterPassword(string password) => driver.FindElement(passwordInput).SendKeys(password);

    public void ClickLoginButton() => driver.FindElement(loginButton).Click();
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
        // Initialize WebDriver (not shown here)
        driver = new ChromeDriver();
    }

    [Test]
    public void TestLogin()
    {
        // Navigate to the login page
        driver.Navigate().GoToUrl("https://example.com/login");

        // Create LoginPage object
        var loginPage = new LoginPage(driver);

        // Perform login actions using Page Object methods
        loginPage.EnterUsername("testuser");
        loginPage.EnterPassword("testpassword");
        loginPage.ClickLoginButton();

        // Assert login success or any other verification steps
    }

    [TearDown]
    public void TestTeardown()
    {
        // Close the browser after the test
        driver.Quit();
    }
}
```

In this example, we have a Page Object class `LoginPage` that encapsulates the web elements and actions on the login page. 
The test class `TestClass` uses the LoginPage object to perform login actions. By doing so, we keep the test code clean 
and separate from the web elements, enhancing readability and maintainability.

### Structure

100% you will have a lot of pages on your website. Let's consider the following example:
There are some pages: Login page, LogOut page, Catalogue page and Product page. All of them is the part of Page Object
Model. So that means that we must create structure according to logic of these pages. Let's see the example below

#### Example Structure for Page Objects with Multiple Pages:
```markdown
Project Folder
│
├── Pages
│   ├── Authorization
│   │   ├── LoginPage.cs
│   │   └── LogOutPage.cs
│   │
│   └── Catalogue
│       ├── CataloguePage.cs
│       └── ProductPage.cs
│
├── Tests
│   ├── BaseTest.cs
│   ├── AuthorizationTests.cs
│   └── CatalogueTests.cs
│
└── Utilities
    └── BrowserFactory.cs
```

#### Pages
1. The Pages folder contains subfolders for different sections of the web application, such as **Authorization** and **Catalogue**.
2. Inside each subfolder, there is a separate Page Object class for each page of that section. 
For example, in the **Authorization** folder, there are `LoginPage.cs` and `LogOutPage.cs`, while in the **Catalogue** folder, 
there are `CataloguePage.cs` and `ProductPage.cs`.
3. Each Page Object class contains locators and methods to interact with the web elements specific to that page. 
For instance, `LoginPage.cs` will have methods related to entering username, password, and clicking the login button, 
while `CataloguePage.cs` will have methods to select products and navigate to the product details page.
```markdown
Pages
├── Authorization
│   ├── LoginPage.cs
│   ├── LogOutPage.cs
│   │
└── Catalogue
    ├── CataloguePage.cs
    └── ProductPage.cs
```

#### Tests

1. The Tests folder contains test classes related to different sections of the application, 
such as `AuthorizationTests.cs`, `CatalogueTests.cs` and `BaseTest.cs`.
2. In the test classes, you initialize the WebDriver and navigate to the respective pages using the BrowserFactory. 
Then, you create instances of the respective Page Objects to perform actions on the web elements.
```markdown
Tests
├── BaseTest.cs
├── AuthorizationTests.cs
└── CatalogueTests.cs
```

#### Utilities

1. The Utilities folder contains common utility classes, such as the `BrowserFactory.cs`, 
which handles the creation of the WebDriver instance using the [Browser Factory Pattern](../Module4/Theory.md).
```markdown
Utilities
└── BrowserFactory.cs
```

#### Example Structure for multiple pages:
```csharp
using NUnit.Framework;
using OpenQA.Selenium;

namespace Project.Tests
{
    [TestFixture]
    public class AuthorizationTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private LogOutPage logOutPage;

        [SetUp]
        public void TestSetup()
        {
            driver = BrowserFactory.GetDriver(BrowserType.Chrome);
            loginPage = new LoginPage(driver);
            logOutPage = new LogOutPage(driver);
        }

        [Test]
        public void TestLoginAndLogout()
        {
            driver.Navigate().GoToUrl("https://example.com/login");

            // Perform login using LoginPage
            loginPage.EnterUsername("testuser");
            loginPage.EnterPassword("testpassword");
            loginPage.ClickLoginButton();

            // Assert login success or perform other verification steps

            // Perform logout using LogOutPage
            logOutPage.ClickLogoutButton();

            // Assert logout success or perform other verification steps
        }

        [TearDown]
        public void TestTeardown()
        {
            BrowserFactory.CloseDriver();
        }
    }
}
```

