# Browser Actions

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.

## Home Task

Your task is to practice working with different Browser Actions

Test website: http://the-internet.herokuapp.com/

### Scenario 1: Open New Window and Handle Tabs

1. Navigate to the website. 
2. Click on the "Multiple Windows" link.
3. Click on the "Click Here" link to open a new window. 
4. Switch to the new window. 
5. Verify that the new window content is displayed. 
6. Close the new window.

### Scenario 2: Navigate Back and Forward

1. Navigate to http://the-internet.herokuapp.com/.
2. Click on the "Form Authentication" link.
3. Log in with valid credentials.
4. Verify that successfully logged in page displayed
5. Click browser back button 
6. Verify that the login form is visible again 
7. Click browser forward button 
8. Verify that successfully logged in page displayed

### Scenario 3: Navigate to URL and Refresh

1. Navigate to the website. 
2. Click on the "Dynamic Loading" link. 
3. Click on the "Example 1: Element on page that is hidden" link. 
4. Click the "Start" button to load the hidden element. 
5. Verify that the element is displayed. 
6. Store the current URL using driver.Url. 
7. Use Navigate().GoToUrl() to go back to the homepage. 
8. Verify that the user is on the homepage. 
9. Reload the homepage.

### Scenario 4: Maximize Window and Change Window Size

1. Navigate to the website. 
2. Click on the "Large & Deep DOM" link. 
3. Scroll down until 'Powered by Elemental Selenium' is clickable. 
4. Maximize the browser window. 
5. Scroll right to the end of the table.
6. Get the latest value of the table (must be equal 50.50)
7. Change the window size. 
8. Verify that the window size changes accordingly.

### Scenario 5: Working with Chrome Options - Headless Mode

1. Launch Chrome browser in headless mode using ChromeOptions.
2. Navigate to the website.
3. Click on the "Checkboxes" link.
4. Verify that the checkboxes can still be interacted with in headless mode.

### After all check list

1. Make screenshot that your test passes successfully
2. Create Pull Request with name `Module-5-{TaskName}`
3. Add screenshot to PR description
4. Notify your mentor about completing the task
