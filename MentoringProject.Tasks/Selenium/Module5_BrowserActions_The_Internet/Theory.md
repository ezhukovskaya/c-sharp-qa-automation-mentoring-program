# Browser Actions

## Driver Actions

### Working with Windows (Tabs)

You can use the `WindowHandles` property to handle multiple windows or tabs opened by the driver. Here's an example:

```csharp
string currentWindowHandle = driver.CurrentWindowHandle;
foreach (string windowHandle in driver.WindowHandles)
{
    if (windowHandle != currentWindowHandle)
    {
        driver.SwitchTo().Window(windowHandle);
        // Perform actions on the new window/tab
    }
}
```

If you want to close the just one tab. You need to switch to it and call `driver.Close()`:

```csharp
driver.SwitchTo().Window(driver.WindowHandles.Last());
driver.Close();
```

If there is the only tab and you call `driver.Close()`, the whole browser is going to be closed.

### Handling Alerts

You can accept, dismiss, or interact with JavaScript alerts using the SwitchTo().Alert() method. Here's an example:

```csharp
IAlert alert = driver.SwitchTo().Alert();
string alertText = alert.Text;
alert.Accept(); // or alert.Dismiss();
```

### Navigating

You can navigate to a URL using the `Navigate().GoToUrl()` method:

```csharp
driver.Navigate().GoToUrl("https://www.example.com");
```

If you want to get the current Url, so you need to use `driver.Url`:

```csharp
var currentUrl = driver.Url; // "https://www.example.com"
```

You can navigate to Previous or Next page according to your web surfing history:

```csharp
driver.Navigate().Back(); // goes to the previous page
driver.Navigate().Forward(); // goes to the next page
```

You can refresh the page using `Navigate().Refresh()`:

```csharp
driver.Navigate().Refresh();
```

### Window Size

You can set the size of the browser window using the `Manage().Window.Size` property:

```csharp
driver.Manage().Window.Size = new System.Drawing.Size(width, height);
```

You can maximize the browser window using the `Manage().Window.Maximize()` method:

```csharp
driver.Manage().Window.Maximize();
```

## ChromeOptions

### Managing ChromeOptions

#### What are ChromeOptions?
ChromeOptions is a class in Selenium that allows you to customize the behavior of the Chrome browser when launching it 
via WebDriver. It provides a way to set various preferences and command-line arguments that control the browser's behavior.

#### Adding Arguments

You can add command-line arguments to Chrome using ChromeOptions:

```csharp
ChromeOptions options = new ChromeOptions();
options.AddArgument("--headless"); // Run Chrome in headless mode
options.AddArgument("--disable-gpu"); // Disable GPU acceleration
```

#### Setting Preferences

You can set preferences for Chrome using ChromeOptions:

```csharp
ChromeOptions options = new ChromeOptions();
options.AddUserProfilePreference("download.default_directory", "C:\\Downloads");
options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
```

## Useful links:
- [Working with windows and tabs](https://www.selenium.dev/documentation/webdriver/interactions/windows/)
- [Browser navigation](https://www.selenium.dev/documentation/webdriver/interactions/navigation/)
- [Browser Options](https://www.selenium.dev/documentation/webdriver/drivers/options/)


