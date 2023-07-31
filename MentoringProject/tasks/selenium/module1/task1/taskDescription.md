# First Selenium Test

## Theme of the Topic

In this tutorial, we will cover the basics of Selenium and how to create your first Selenium test using C#, Selenium WebDriver, Visual Studio, and NUnit. Selenium is a powerful open-source automation tool widely used for web testing and automating web browsers.

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.

## Hometask

Your task is to create Selenium test scripts using C#, NUnit, and Visual Studio to perform the following test scenarios on the "Sauce Labs Demo" website

### Pre-Conditions

1. Set up a new C# project in Visual Studio for your Selenium tests. Project must be Class Library type
2. Create and checkout to the branch with name `module-1-branch`
2. Add the necessary Selenium and NUnit packages to your C# project using NuGet Package Manager.

### Scenario 1: Successful Login with Valid Credentials

1. Create a new C# test class for your Selenium test.
2. Set up the Selenium WebDriver with the Chrome or Firefox browser
3. Navigate to the "https://www.saucedemo.com/" URL.
4. Find the username and password input fields and enter the following login credentials:
   - Username: standard_user
   - Password: secret_sauce
5. Click the "Login" button to log in.
6. After successful login, verify that you are redirected to the "https://www.saucedemo.com/inventory.html" URL.
7. On the inventory page, find and click on any product to view its details.
8. Use NUnit assertions to validate that the product details are displayed correctly.
9. Close the browser and end the test.

### Scenario 2: Unsuccessful Login with Empty Credentials

1. Create a new C# test class for your Selenium test.
2. Set up the Selenium WebDriver with the Chrome or Firefox browser and
3. Navigate to the "https://www.saucedemo.com/" URL.
4. Find the username and password input fields and leave them empty.
5. Click the "Login" button to attempt the login.
6. Verify that an error message is displayed indicating the need to provide valid login credentials.
7. Use NUnit assertions to validate the presence of the error message and its correctness.
8. Close the browser and end the test.

### Scenario 3: Unsuccessful Login with Invalid Credentials

1. Create a new C# test class for your Selenium test.
2. Set up the Selenium WebDriver with the Chrome or Firefox browser and
3. Navigate to the "https://www.saucedemo.com/" URL.
4. Find the username and password input fields and enter incorrect login credentials:

   - Username: invalid_user
   - Password: invalid_password
5. Click the "Login" button to attempt the login.
6. Verify that an error message is displayed indicating a failed login attempt.
7. Use NUnit assertions to validate the presence of the error message and its correctness.
8. Close the browser and end the test.

### After all check list

1. Make screenshot that your test passes successfully
2. Create Pull Request with name `Module-1-{TaskName}`
3. Add screenshot to PR description
4. Notify your mentor about completing the task
