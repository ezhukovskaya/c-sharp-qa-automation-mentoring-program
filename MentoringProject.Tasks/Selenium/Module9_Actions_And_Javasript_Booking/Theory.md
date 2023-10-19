# Additional Interactions With Web Elements

In this section, we'll explore additional interactions with web elements using Selenium and JavaScript. We'll cover
popular interactions and provide examples for each. Sometimes regular clicks, send keys and etc. are not working with
web elements. So, that means we need to use additional interactions.

## Selenium Actions

Selenium's `Actions` class provides a way to perform complex interactions by chaining actions together.

### Click and Hold

Perform a click-and-hold action on an element, useful for drag-and-drop scenarios.

```csharp
Actions actions = new Actions(driver);
IWebElement sourceElement = driver.FindElement(By.Id("source"));
IWebElement targetElement = driver.FindElement(By.Id("target"));
actions.ClickAndHold(sourceElement)  // Click and hold the source element
       .MoveToElement(targetElement) // Move to the target element while holding
       .Release()                    // Release the mouse button
       .Perform();                   // Perform the actions
```

### Context Click (Right-Click)

Simulate a right-click (context click) on an element.

```csharp
Actions actions = new Actions(driver);
IWebElement element = driver.FindElement(By.Id("contextElement"));
actions.ContextClick(element) // Right-click on the element
       .Perform();             // Perform the context click action
```

### Double Click

Simulate a double-click action on an element.

```csharp
Actions actions = new Actions(driver);
IWebElement element = driver.FindElement(By.Id("doubleClickElement"));
actions.DoubleClick(element) // Double-click on the element
       .Perform();           // Perform the double click action
```

### Drag and Drop

Perform a drag-and-drop action between two elements.

```csharp
Actions actions = new Actions(driver);
IWebElement sourceElement = driver.FindElement(By.Id("source"));
IWebElement targetElement = driver.FindElement(By.Id("target"));
actions.DragAndDrop(sourceElement, targetElement) // Drag the source to the target
       .Perform();                                // Perform the drag and drop action
```

### Key Down and Key Up

Simulate pressing and releasing a specific key.

```csharp
Actions actions = new Actions(driver);
actions.KeyDown(Keys.Control)   // Press the Control key
       .Click(someElement)       // Perform a click action
       .KeyUp(Keys.Control)     // Release the Control key
       .Perform();             // Perform the actions
```

Here, we use the `Keys` class to specify the keys we want to press and release. In this example, we press the Control key
while performing an action on an element and then release the Control key.

## JavaScript Interactions

JavaScript interactions provide greater control over elements and actions that are not directly supported by Selenium.

### Script Execution with `IJavaScriptExecutor`

For more advanced JavaScript interactions, you can use the IJavaScriptExecutor interface in Selenium. This allows you
to execute custom JavaScript code on the page.

```csharp
IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

// Example: Scroll to the bottom of the page
jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

// Example: Change element visibility
jsExecutor.ExecuteScript("document.getElementById('hiddenElement').style.display = 'block';");
```

The executeScript method definition looks like below

```csharp
ExecuteScript(string script, params object[] args)
```

**script** - Javascript to perform the actions.

**args** - The arguments to the script, this can be empty based on the javascript we pass.

With `IJavaScriptExecutor`, you can perform actions that might not be easily achievable through other means.
Just be cautious and ensure your JavaScript code is well-tested.

### Changing Element Content

Use to dynamically change the content of an element.

```javascript
var element = document.getElementById("contentElement");
element.textContent = "New content"; // Update the element's text content
```

### Element Highlighting

Use for visually emphasizing elements during testing or debugging.

```javascript
var element = document.getElementById("highlightMe");
element.style.border = "2px solid red"; // Add a red border to highlight the element
```

### Element Scroll

Use to navigate to specific elements that are not visible on the screen.

```javascript
var scrollToElement = document.getElementById("scrollTarget");
scrollToElement.scrollIntoView({ behavior: "smooth" }); // Scroll smoothly to the element
```

**OR**

```javascript
window.scrollTo(0, document.body.scrollHeight);
```

### Element Click

Use to navigate to click elements that are not reachable

```javascript
document.getElementById('myButton').click(); // Click the element
```

## Useful Links

- [Selenium Actions Class](https://toolsqa.com/selenium-webdriver/actions-class-in-selenium/)

It's important to choose the appropriate method based on the complexity of the interaction and the behavior you want
to simulate. While Actions provide a higher-level API for interacting with web elements, JavaScript interactions offer more flexibility for custom interactions and validations.

Remember to ensure that you have appropriate waits and synchronization mechanisms in place to handle dynamic elements.

By leveraging these interactions, you can enhance your Selenium test automation and perform advanced actions on web
elements.
