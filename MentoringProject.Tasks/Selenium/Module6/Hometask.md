# Waiters

## Description

Practicing using Explicit/Implicit/Fluent waits

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.
4. Waiting Strategies:
   - [Waiting Strategies](https://www.selenium.dev/documentation/webdriver/waits/): Official documentation on using the Page Object Pattern with Selenium WebDriver in different programming languages, including C#.

## Home Task

You are tasked with testing various functionalities of the website "https://www.the-internet.herokuapp.com" using C# Selenium with
NUnit. Your goal is to create automated test scenarios to ensure that different features of the website are working as
expected. You should avoid using Thread.Sleep for waits and instead use explicit waits, such as WebDriverWait,
to ensure reliable and stable test execution.

Test website: http://the-internet.herokuapp.com/

### Login Page:

### Scenario 1: Form Authentication - Failed Login

| Step Description                                     | Expected Result                                                |
|------------------------------------------------------|----------------------------------------------------------------|
| Navigate to the Login page.                          | The Login page is displayed.                                   |
| Enter invalid credentials (username and password).   | The username and password fields are filled with invalid data. |
| Click the Login button.                              | An error message is displayed indicating failed login attempt. |

### Scenario 2: Dynamic Loading - Element Rendered

| Step Description                                               | Expected Result                                          |
|----------------------------------------------------------------|----------------------------------------------------------|
| Navigate to the Dynamic Loading page.                          | The Dynamic Loading page is displayed.                   |
| Click on the "Example 1: Element on page that is hidden" link. | The Example 1 page is displayed.                         |
| Click the "Start" button to trigger the loading.               | The loading spinner or message is displayed.             |
| Wait for the element to be visible.                            | The hidden element is now visible on the page.           |

### Scenario 3: Checkboxes - Toggle Selection

| Step Description                                       | Expected Result                                 |
|--------------------------------------------------------|-------------------------------------------------|
| Navigate to the Checkboxes page.                       | The Checkboxes page is displayed.               |
| Verify the initial state of the checkboxes.            | The checkboxes are unchecked by default.        |
| Click the first checkbox to toggle its selection.      | The first checkbox becomes checked.             |
| Click the second checkbox to toggle its selection.     | The second checkbox becomes checked.            |
| Verify that both checkboxes can be toggled on/off.     | Both checkboxes can be checked or unchecked.    |

### Scenario 4: File Upload - Successful Upload

| Step Description                              | Expected Result                                                                     |
|-----------------------------------------------|-------------------------------------------------------------------------------------|
| Navigate to the File Upload page.             | The File Upload page is displayed.                                                  |
| Upload a file using the "Choose File" button. | The file is selected for upload.                                                    |
| Click the "Upload" button.                    | The file upload is successful, and the uploaded file name is displayed on the page. |

### Scenario 5: Dynamic Controls - Checkbox Enable/Disable

| Step Description                                      | Expected Result                                                                            |
|-------------------------------------------------------|--------------------------------------------------------------------------------------------|
| Navigate to the Dynamic Controls page.                | The Dynamic Controls page is displayed.                                                    |
| Click the "Remove" button to remove the checkbox.     | The checkbox is removed from the page.                                                     |
| Wait for the checkbox to disappear.                   | The checkbox is no longer visible on the page.                                             |
| Click the "Add" button to add the checkbox back.      | The checkbox is added back to the page.                                                    |
| Wait for the checkbox to appear and become clickable. | The checkbox is visible and enabled, ready to be interacted with (selected or deselected). |


## After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-6-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of Explicit/Implicit/Fluent waits.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
