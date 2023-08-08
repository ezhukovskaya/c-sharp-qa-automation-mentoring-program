# Wrapper for IWebElement

## Description
A wrapper class is a class that encapsulates and 'wraps' primitive data types or complex entities. In the context of 
Selenium, a wrapper class around IWebElement allows for additional functionality and handling around actions performed 
on web elements, such as handling timeouts, exceptions, or providing better waiting or logging mechanisms. This results 
in improved performance, and cleaner, more maintainable test code.

Wrapper classes mimic the behavior of what they encapsulate, essentially acting like a decorated or enhanced version of the original, providing functionality that is not present in the original class.
Creating wrapper classes can be a good practice in many cases, offering benefits such as:
1. Adding additional, application-specific functionality.
2. Improving reusability and maintainability of code.
3. Enhancing code readability by abstracting complex tasks into simple, well-named methods.
4. Encouraging separation of concerns and adherence to the Single Responsibility Principle.

## Purpose of using Wrapper for IWebElement

In Selenium automation coding, we work with the `IWebElement` interface quite often. It's the core interface to interact 
with any web element. However, sometimes it would be more efficient and maintainable to create a wrapper for our web elements.

A WebElement wrapper would allow us to extend the functionalities of an `IWebElement`. Creating custom methods or 
properties specific to our application can provide very useful additional functionality. For instance, we can add 
extra waiting, logging, or exception handling logic into the wrapper methods.

Moreover, code readability also gets significantly improved when using a WebElement wrapper. Using the wrapper class, 
we can manage composite web elements as single units with appropriate naming, instead of a bunch of lines of code.

## How to Implement Wrapper for IWebElement

Custom `WebElement` class can be defined by two ways: Extension and Inheritance

**Extension**
```csharp
public class WebElement
{
    protected IWebDriver Driver => BrowserFactory.Driver;
    protected IWebElement element;

    public WebElement(By locator)
    {
        this.element = Driver.FindElements(locator).FirstOrDefault();
    }

    public string Text => this.element.Text;

    public bool Displayed => this.element.Displayed;

    public bool Enabled => this.otherFunctionEnabled();

    public void Click()
    {
        this.element.Click();
    }

   // other functions

    private bool otherFunctionEnabled()
    {
        // some other function to check whether element is enabled or not
        return true;
    }
}
```

In this example, our `WebElement` class extends IWebElement with a new method `otherFunctionEnabled`. Other properties and 
methods are similar to those in `IWebElement`. However, the difference is that we can add custom handling inside these 
methods if required.

**Inheritance**

However, please note that `IWebElement` is an interface, and you cannot inherit from it directly. Instead, you can create 
a class that implements the `IWebElement` interface.

```csharp
public class WebElement : IWebElement
{
    protected IWebDriver Driver => BrowserFactory.Driver;
    protected IWebElement element;

    public WebElement(By locator)
    {
        this.element = Driver.FindElements(locator).FirstOrDefault();
    }

    public string TagName => this.element.TagName;

    public string Text => this.element.Text;

    public bool Enabled => otherFunctionEnabled();

    public bool Selected => this.element.Selected;

    public Point Location => this.element.Location;

    public Size Size => this.element.Size;

    public bool Displayed => this.element.Displayed;

    public void Clear()
    {
        this.element.Clear();
    }

    public void Click()
    {
        this.element.Click();
    }

    // Implement other methods from IWebElement interface

    private bool otherFunctionEnabled()
    {
        // some other function to check whether element is enabled or not
        return true;
    }

    // Implement other functions

    // You need to implement other methods and properties from the IWebElement interface as needed
}
```
Keep in mind that you'll need to implement all the properties and methods of the `IWebElement` interface in your 
`WebElement` class. The example above shows a few of them as a starting point. Make sure to add the necessary 
functionality to each of these methods and properties based on your requirements.


`WebElement` class can be used in a base element sense. That allows us to inherit from it some other basic web elements
like Button, TextBox, DropDown and etc.

### Additional Examples

#### Button WebElement Wrapper

Suppose we have a custom actions associated with Button like waiting until the button becomes clickable. 
We can create a wrapper which handles it, rather than implementing it every time we deal with a Button.

```csharp
public class ButtonElement : WebElement
{
    public ButtonElement(By locator) : base(locator)
    {
    }

    public void ClickWhenReady()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        var element = wait.Until(ExpectedConditions.ElementToBeClickable(this.element));
        Click();
    }
}
```

You would use it the same way as `WebElement`, but now it carries additional method to perform safe click when element is 
ready.

#### TextBox WebElement Wrapper

For TextBox we would ideally be interested in writing some text into it and maybe clearing it before. 
We can implement this similarly:

```csharp
public class TextBoxElement : WebElement
{
    public TextBoxElement(By locator) : base(locator)
    {
    }

    public void EnterText(string text)
    {
        this.element.Clear();
        this.element.SendKeys(text);
    }
}
```

Now we have combined two operations `Clear` and `SendKeys` in one operation.

#### DropDown WebElement Wrapper

For DropDown we are mostly interested in selecting elements. Let's see how we can wrap it:

```csharp
public class DropDownElement : WebElement
{
    public DropDownElement(By locator) : base(locator)
    {
    }

    public void SelectByText(string text)
    {
        var selectElement = new SelectElement(this.element);
        selectElement.SelectByText(text);
    }

    public void SelectByValue(string value)
    {
        var selectElement = new SelectElement(this.element);
        selectElement.SelectByValue(value);
    }
}
```

In above code, method SelectByText allows us to select drop-down option by visible text and method SelectByValue allows 
us to select drop-down option by its value.

**Correspondingly, usage of these wrapper classes in your page objects provides a more cleaner, readable and maintainable 
code.**

## Usage in Tests

```csharp
[TestFixture]
public class TestLoginPage 
{
    // Assuming driver is initialized appropriately.
    private IWebDriver _driver;
    private LoginPage _loginPage;

    [SetUp]
    public void Setup()
    {
        // Assuming driver is initialized appropriately.
        this._driver = BrowserFactory.Driver;
        _loginPage = new LoginPage(_driver);
    }

    [Test]
    public void TestLoginFunctionality()
    {
        _loginPage.UsernameInput.EnterText("myusername");
        _loginPage.PasswordInput.EnterText("mypassword");
        _loginPage.RememberMeCheckBox.Check();
        _loginPage.UserRoleDropDown.SelectByText("Admin");
        _loginPage.LoginButton.ClickWhenReady();

        // continue with assertions and/or further actions
    }
   
    [TearDown]
    public void Teardown()
    {
        this._driver.Quit();
    }
}
```

This code features a test class `TestLoginPage` which has a single test `TestLoginFunctionality`. This test mimics a login 
process, where it enters a username and password, checks a checkbox to 'remember me', chooses a user role from a 
dropdown, and finally, clicks a button to log in.

Through this test, our `LoginPage` class, and each of our encapsulated WebElement classes (`ButtonElement`, `TextBoxElement`, 
`CheckBoxElement`, `DropDownElement`), have allowed us to write expressive, self-documenting test code. Namely, when the 
test reader sees `_loginPage.UsernameInput.EnterText("myusername");` they can clearly understand this line of code is 
entering `'myusername'` into the Username input box, thanks to the well-named `WebElement` wrappers and their additional 
methods.

## Useful Links

- [Official Selenium Documentation](https://www.selenium.dev/documentation/en/)
- [NUnit Framework Documentation](https://docs.nunit.org/)