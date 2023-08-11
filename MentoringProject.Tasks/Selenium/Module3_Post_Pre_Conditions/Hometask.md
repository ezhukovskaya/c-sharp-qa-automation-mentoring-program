# Preconditions / Post conditions

## Description

In this homework task, you will practice writing Postconditions and Preconditions for your C# Selenium NUnit test cases. Understanding and implementing these conditions are essential for creating robust and reliable automated tests.

## Materials

1. Official Selenium Website:
    - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
    - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
    - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.

## Home Task

Your task is to create Selenium test scripts using C#, NUnit, and Visual Studio to perform the following test scenarios on the "Sauce Labs Demo" website.
New tests must be added to the same `.cs` file created in [First Selenium Test](../Module1_First_Selenium_Test/Hometask.md) home task.

- You need to automate provided scenarios
- You need to refactor you code using conditions attributes from NUnit

### Scenario 1: Unsuccessful Login with Empty Credentials

1. Navigate to the "https://www.saucedemo.com/" URL. 
2. Find the username and password input fields and leave them empty. 
3. Click the "Login" button to attempt the login. 
4. Verify that an error message is displayed indicating the need to provide valid login credentials. 
5. Use NUnit assertions to validate the presence of the error message and its correctness. 
6. Close the browser and end the test.

### Scenario 2: Unsuccessful Login with Invalid Credentials

1. Navigate to the "https://www.saucedemo.com/" URL. 
2. Find the username and password input fields and enter incorrect login credentials:
   - Username: invalid_user
   - Password: invalid_password 
3. Click the "Login" button to attempt the login. 
4. Verify that an error message is displayed indicating a failed login attempt. 
5. Use NUnit assertions to validate the presence of the error message and its correctness. 
6. Close the browser and end the test.

### After all check list

1. Make screenshot that your test passes successfully
2. Create Pull Request with name `Module-3-{TaskName}`
3. Add screenshot to PR description
4. Notify your mentor about completing the task

### Evaluation Criteria
Your homework will be evaluated based on the following criteria:

- Correct implementation of test cases with Postconditions and Preconditions. 
- Proper organization and structure of the test code. 
- Appropriate use of assertions to verify the expected outcomes. 

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
