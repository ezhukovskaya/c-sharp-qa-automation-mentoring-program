# BaseTest

## Description

In this homework task, you will practice implementing BaseTest.

## Materials

1. Official Selenium Website:
    - [SeleniumHQ](https://www.selenium.dev/): The official website of Selenium provides documentation, downloads, and other essential resources.
2. Selenium Documentation:
    - [Selenium Documentation](https://www.selenium.dev/documentation/en/): The official documentation covers all aspects of Selenium, including guides, APIs, and best practices.
3. NUnit Framework:
    - [NUnit Official Website](https://nunit.org/): NUnit is a popular testing framework for C# projects and is ideal for Selenium test automation.

## Home Task

Your task is automate the test cases below and implement **BaseTest** fixture.
Think what methods and expressions can be moved to BaseTest to avoid code duplication.

**NOTE**: There are can be various BaseTest(s) in your structure. You may create as many suits as it possible and 
logically proved

### Pre-Conditions
1. Create one more ``.cs`` file for the new test suit

### Scenario 1: Verify Product Sorting Functionality
1. Navigate to the "https://www.saucedemo.com/" URL. 
2. Log in with valid credentials:
   - Username: standard_user 
   - Password: secret_sauce
3. Click the "Login" button to log in. 
4. After successful login, verify that you are redirected to the "https://www.saucedemo.com/inventory.html" URL. 
5. On the inventory page, find the product sorting dropdown and select "Price (low to high)."
6. Retrieve the list of product prices displayed on the page. 
7. Validate that the products are sorted in ascending order of price using NUnit assertions.

### Scenario 2: Add Product to Cart
1. Navigate to the "https://www.saucedemo.com/" URL.
2. Log in with valid credentials:
   - Username: standard_user
   - Password: secret_sauce
3. Click the "Login" button to log in.
4. After successful login, verify that you are redirected to the "https://www.saucedemo.com/inventory.html" URL.
5. On the inventory page, find and click on any product to view its details.
6. Click the "Add to Cart" button for the selected product.
7. Verify that the cart icon in the top-right corner displays the correct number of items added (e.g., 1 item).

### Scenario 3: Remove Product from Cart
1. Navigate to the "https://www.saucedemo.com/" URL.
2. Log in with valid credentials:
   - Username: standard_user
   - Password: secret_sauce
3. Click the "Login" button to log in.
4. After successful login, verify that you are redirected to the "https://www.saucedemo.com/inventory.html" URL.
5. On the inventory page, find and click on any product to view its details.
6. Click the "Add to Cart" button for the selected product.
7. Verify that the cart icon in the top-right corner displays the correct number of items added (e.g., 1 item).
8. Click the cart icon to navigate to the cart page.
9. On the cart page, find and click the "Remove" button for the added product.
10. Verify that the cart is now empty"

### Scenario 4: Logout Functionality
1. Navigate to the "https://www.saucedemo.com/" URL.
2. Log in with valid credentials:
   - Username: standard_user
   - Password: secret_sauce
3. Click the "Login" button to log in. 
4. After successful login, verify that you are redirected to the "https://www.saucedemo.com/inventory.html" URL.
5. On the inventory page, find the menu icon (three horizontal bars) and click it to open the side menu.
6. In the side menu, find and click the "Logout" button.
7. Verify that you are redirected to the login page "https://www.saucedemo.com/" after logout.

### After all check list

1. Make screenshot that your test passes successfully
2. Create Pull Request with name `Module-4-{TaskName}`
3. Add screenshot to PR description
4. Notify your mentor about completing the task

### Evaluation Criteria
Your homework will be evaluated based on the following criteria:

- Correct implementation of BaseTest. 
- Proper organization and structure of the test code. 
- Appropriate use of assertions to verify the expected outcomes. 

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
