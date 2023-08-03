# Page Object pattern

## Description

In this homework task, you will practice implementing Page Object pattern.

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.
4. Page Object pattern:
   - [Page Object Pattern (Selenium Documentation)](https://www.selenium.dev/documentation/en/guidelines_and_recommendations/page_object_models/): Official documentation on using the Page Object Pattern with Selenium WebDriver in different programming languages, including C#.

## Home Task

For this homework, you are required to create four unique test scenarios for three pages of the website using the Page 
Object Pattern. Use C#, NUnit, and Selenium to implement the test cases. Make sure to create separate Page Object 
classes for each page and follow best practices of the Page Object Pattern.

Test website: http://the-internet.herokuapp.com/

**NOTE**: Don't forget to set up the WebDriver in the BrowserFactory.cs (as shown in the previous examples) to 
instantiate the browser for your test scenarios. Make sure your code follows best practices and is well-structured 
with meaningful comments for better understanding. Happy testing!

### Login Page:

#### Scenario 1: Valid Login


| Step                               | Expected result                                                        |
| ---------------------------------- | ---------------------------------------------------------------------- |
| Go to the Login page.              | Login page is displayed.                                               |
| Enter valid username and password. | Username and password fields are filled with valid credentials.        |
| Click the Login button.            | User is successfully logged in and redirected to the Secure Area page. |

#### Scenario 2: Invalid Login


| Step                                 | Expected result                                                   |
| ------------------------------------ | ----------------------------------------------------------------- |
| Go to the Login page.                | Login page is displayed.                                          |
| Enter invalid username and password. | Username and password fields are filled with invalid credentials. |
| Click the Login button.              | An error message is displayed indicating missing credentials.     |

#### Scenario 3: Logout after Login


| Step                               | Expected result                                                        |
| ---------------------------------- | ---------------------------------------------------------------------- |
| Go to the Login page.              | Login page is displayed.                                               |
| Enter valid username and password. | Username and password fields are filled with valid credentials.        |
| Click the Login button.            | User is successfully logged in and redirected to the Secure Area page. |
| Click the Logout button.           | Verify that the user is successfully logged out                        |

#### Scenario 4: Login with Empty Credentials


| Step                                          | Expected result                                               |
| --------------------------------------------- | ------------------------------------------------------------- |
| Go to the Login page.                         | Login page is displayed.                                      |
| Leave the username and password fields empty. | Username and password fields are empty.                       |
| Click the Login button.                       | An error message is displayed indicating missing credentials. |

### Checkboxes Page:

#### Scenario 1: Toggle Checkbox


| Step                        | Expected result                                 |
| --------------------------- | ----------------------------------------------- |
| Go to the Checkboxes page.  | Verify that there are two checkboxes displayed. |
| Check the first checkbox.   | Verify that the first checkbox is checked.      |
| Uncheck the first checkbox. | Verify that the first checkbox is unchecked.    |

#### Scenario 2: Check Both Checkboxes


| Step                       | Expected result                                 |
| -------------------------- | ----------------------------------------------- |
| Go to the Checkboxes page. | Verify that there are two checkboxes displayed. |
| Check both checkboxes.     | Verify that both checkboxes are checked.        |

#### Scenario 3: Uncheck Both Checkboxes


| Step                       | Expected result                                 |
| -------------------------- | ----------------------------------------------- |
| Go to the Checkboxes page. | Verify that there are two checkboxes displayed. |
| Check both checkboxes.     | Verify that both checkboxes are checked.        |
| Uncheck both checkboxes.   | Verify that both checkboxes are unchecked.      |

#### Scenario 4: Toggle Checkboxes Repeatedly


| Step                                                            | Expected result                                                         |
| --------------------------------------------------------------- | ----------------------------------------------------------------------- |
| Go to the Checkboxes page.                                      | Verify that there are two checkboxes displayed.                         |
| Toggle the first checkbox multiple times (Check-Uncheck-Check). | Verify that the first checkbox is checked.                              |
| Uncheck the first checkbox.                                     | Verify that the first checkbox status is as expected after each toggle. |

### Dropdown Page:

#### Scenario 1: Select Option from Dropdown


| Step                                     | Expected result                                   |
| ---------------------------------------- | ------------------------------------------------- |
| Go to the Dropdown page.                 | Dropdown page is displayed..                      |
| Select an option from the dropdown list. | The selected option is displayed in the dropdown. |

#### Scenario 2: Select Different Options from Dropdown


| Step                                      | Expected result                                     |
| ----------------------------------------- | --------------------------------------------------- |
| Go to the Dropdown page.                  | Dropdown page is displayed..                        |
| Select an option from the dropdown list.  | The selected option is displayed in the dropdown.   |
| Repeat the process for different options. | The selected options are displayed in the dropdown. |

#### Scenario 3: Validate Dropdown Options


| Step                                                 | Expected result                        |
| ---------------------------------------------------- | -------------------------------------- |
| Go to the Dropdown page.                             | Dropdown page is displayed..           |
| Get the list of available options from the dropdown. | The list matches the expected options. |

#### Scenario 4: Select Random Option from Dropdown


| Step                                           | Expected result                                   |
| ---------------------------------------------- | ------------------------------------------------- |
| Go to the Dropdown page.                       | Dropdown page is displayed..                      |
| Select a random option from the dropdown list. | The selected option is displayed in the dropdown. |

### After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-5-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

### Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of Page Object pattern.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
