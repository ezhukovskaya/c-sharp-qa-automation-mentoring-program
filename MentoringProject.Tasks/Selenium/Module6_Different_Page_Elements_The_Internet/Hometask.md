# Different Page Elements

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.

## Home Task

You are tasked with testing various functionalities of the website "https://www.the-internet.herokuapp.com" using C# Selenium with
NUnit. Your goal is to create automated test scenarios to ensure that different features of the website are working as
expected. You should avoid using Thread.Sleep for waits and instead use explicit waits, such as WebDriverWait,
to ensure reliable and stable test execution.

Test website: http://the-internet.herokuapp.com/

### Test Scenario 1: Handling Simple Alert

| Step                                 | Expected Result                      |
|--------------------------------------|--------------------------------------|
| Open the website                     | Website is loaded successfully       |
| Click "JavaScript Alerts" link       | "JavaScript Alerts" page is shown    |
| Click "Click for JS Alert" button    | Simple alert dialog is displayed     |
| Accept the alert                     | Alert is accepted and closed         |
| Verify result message                | Alert acceptance message is shown    |

### Test Scenario 2: Handling Confirmation Alert

| Step                                 | Expected Result                          |
|--------------------------------------|------------------------------------------|
| Open the website                     | Website is loaded successfully           |
| Click "JavaScript Alerts" link       | "JavaScript Alerts" page is shown        |
| Click "Click for JS Confirm" button  | Confirmation alert dialog is displayed   |
| Dismiss the confirmation alert       | Alert is dismissed                       |
| Verify result message                | Alert dismissal message is shown         |

### Test Scenario 3: Handling Prompt Alert

| Step                                   | Expected Result                         |
|----------------------------------------|-----------------------------------------|
| Open the website                       | Website is loaded successfully          |
| Click "JavaScript Alerts" link         | "JavaScript Alerts" page is shown       |
| Click "Click for JS Prompt" button     | Prompt alert dialog is displayed        |
| Enter text and accept the alert        | Alert is accepted and closed            |
| Verify entered text in result message  | Entered text is displayed in message    |

### Test Scenario 4: Switching to an Iframe

| Step                                 | Expected Result                             |
|--------------------------------------|---------------------------------------------|
| Open the website                     | Website is loaded successfully              |
| Click "Frames" link                  | "Frames" page is shown                      |
| Click "iFrame" link                  | "iFrame" page is shown                      |
| Switch to the iframe                 | Context is switched to the iframe           |
| Verify heading within the iframe     | Heading within the iframe is visible        |

### Test Scenario 5: Interacting with Select Element

| Step                                 | Expected Result                                |
|--------------------------------------|------------------------------------------------|
| Open the website                     | Website is loaded successfully                 |
| Click "Dropdown" link                | "Dropdown" page is shown                       |
| Select an option from the dropdown   | Selected option is displayed in the dropdown   |
| Verify selected option               | Selected option matches the expected option    |

### Test Scenario 6: Interacting with Checkbox Element

| Step                                  | Expected Result                        |
|---------------------------------------|----------------------------------------|
| Open the website                      | Website is loaded successfully         |
| Click "Checkboxes" link               | "Checkboxes" page is shown             |
| Click checkbox labeled "checkbox 1"   | Checkbox 1 is checked                  |
| Verify checkbox state                 | Checkbox 1 is confirmed as checked     |

### Test Scenario 7: Interacting with Range Element

| Step                                 | Expected Result                    |
|--------------------------------------|------------------------------------|
| Open the website                     | Website is loaded successfully     |
| Click "Horizontal Slider" link       | "Horizontal Slider" page is shown  |
| Set a value in the range input       | Range input displays the value     |
| Verify entered value                 | Entered value matches displayed    |

### Test Scenario 8: Interacting with Text Input Element

| Step                                 | Expected Result                      |
|--------------------------------------|--------------------------------------|
| Open the website                     | Website is loaded successfully       |
| Click "Inputs" link                  | "Inputs" page is shown               |
| Enter text in the text input         | Text input displays the entered text |
| Verify entered text                  | Entered text matches displayed text  |

### Test Scenario 9: Interacting with Basic Auth

| Step                                 | Expected Result                          |
|--------------------------------------|------------------------------------------|
| Open the website                     | Website is loaded successfully           |
| Click "Basic Auth" link              | Basic Auth prompt is displayed           |
| Enter valid credentials and press OK | Secure Area page is displayed            |
| Verify Secure Area page is displayed | User is authenticated and page is shown  |

### Test Scenario 10: Downloading a File

| Step                                 | Expected Result                    |
|--------------------------------------|------------------------------------|
| Open the website                     | Website is loaded successfully     |
| Click "File Download" link           | "File Download" page is shown      |
| Click the file link                  | File download dialog is displayed  |
| Verify downloaded file               | Downloaded file matches expected   |

### Test Scenario 11: Validate data sorted by First Name

| Step                                                           | Expected Result                                                  |
|----------------------------------------------------------------|------------------------------------------------------------------|
| Click 'Sortable Data Tables' link from the homepage            | 'Sortable Data Tables' page is displayed                         |
| Click on the header of the 'First Name' column                 | The data in the 'First Name' column gets sorted                  |
| Verify that the data are sorted correctly                      | The data in the 'First Name' column is sorted in ascending order |

### Test Scenario 12: Test sorting toggle functionality for Last Name

| Step                                                           | Expected Result                                                               |
|----------------------------------------------------------------|-------------------------------------------------------------------------------|
| Click 'Sortable Data Tables' link from the homepage            | 'Sortable Data Tables' page is displayed                                      |
| Click on the 'Last Name' header twice                          | The 'Last Name' column sorting toggles between ascending and descending order |

### Test Scenario 13: Validate row data

| Step                                                           | Expected Result                                                                  |
|----------------------------------------------------------------|----------------------------------------------------------------------------------|
| Click 'Sortable Data Tables' link from the homepage            | 'Sortable Data Tables' page is displayed                                         |
| Check the first data row and validate column-value pairing     | The data in the first row corresponds correctly to the respective column headers |

### Test Scenario 14: Test navigation and return to Page

| Step                                                                           | Expected Result                                                                                 |
|--------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------|
| Click 'Sortable Data Tables' link from the homepage                            | 'Sortable Data Tables' page is displayed                                                        |
| Navigate to another page from 'Sortable Data Tables' page and then return back | The 'Sortable Data Tables' page loads as fresh and any sorting of columns done earlier is reset |

### Test Scenario 15: Validate data sorted by Due column

| Step                                                           | Expected Result                                                                                                                                  |
|----------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------|
| Click 'Sortable Data Tables' link from the homepage            | 'Sortable Data Tables' page is displayed                                                                                                         |
| Click on the header of the 'Due' column                        | The data in the 'Due' column gets sorted                                                                                                         |
| Verify that the data are sorted correctly                      | The data in the 'Due' column is sorted in ascending order objects may not be sorted in regular number or alphabetic order as they represent date |


## After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-6-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
