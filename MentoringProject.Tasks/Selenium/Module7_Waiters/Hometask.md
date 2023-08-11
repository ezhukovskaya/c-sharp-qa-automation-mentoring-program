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

You are tasked with testing various functionalities of the website "https://phptravels.net" using C# Selenium with
NUnit. Your goal is to create automated test scenarios to ensure that different features of the website are working as
expected. You should avoid using Thread.Sleep for waits and instead use explicit waits, such as WebDriverWait,
to ensure reliable and stable test execution.

Test website: https://phptravels.net

### Scenario 1: Search Hotels

| Step                                                                                          | Expected Result                                               |
|-----------------------------------------------------------------------------------------------|---------------------------------------------------------------|
| Navigate to https://phptravels.net                                                            | The PHP Travels homepage should be displayed                  |
| Click on the "Hotels" menu item                                                               | The "Hotels" page should be displayed                         |
| Enter a location in the search box and select a location from the dropdown auto-complete list | The selected location should be filled in the search box      |
| Choose Check-in and Check-out dates from the date picker                                      | The selected dates should be reflected in the date input box  |
| Click on the "Search" button                                                                  | A list of hotels in the selected location should be displayed |

### Scenario 2: Book a Flight

| Step                                                                                                                      | Expected Result                                                                                      |
|---------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                                        | The PHP Travels homepage is displayed                                                                |
| Click on the "Flights" menu item                                                                                          | The "Flights" page is displayed                                                                      |
| Enter the departure and destination locations in the search box and select locations from the dropdown auto-complete list | The selected locations are filled in the search box                                                  |
| Choose departure and return dates from the date picker                                                                    | The selected dates are reflected in the date input box                                               |
| Click on the "Search" button                                                                                              | A list of available flights between the selected locations on the selected dates should be displayed |

### Scenario 3: Car Booking

| Step                                                                                                    | Expected Result                                                       |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                      | The PHP Travels homepage should be displayed                          |
| Click on the "Cars" menu item                                                                           | The "Cars" page should be displayed                                   |
| Enter the pick up location in the search box and select a location from the dropdown auto-complete list | The selected location should be filled in the search box              |
| Choose pick-up and drop-off dates from the date picker                                                  | The selected dates should be reflected in the date input box          |
| Click on the "Search" button                                                                            | A list of available cars in the selected location should be displayed |

### Scenario 4: Blog Post Review

| Step                                                                              | Expected Result                                            |
|-----------------------------------------------------------------------------------|------------------------------------------------------------|
| Navigate to https://phptravels.net                                                | The PHP Travels homepage should be displayed               |
| Click on "Blog" menu item                                                         | The "Blog" page should be displayed                        |
| Click on one of the blog posts                                                    | The chosen blog post page is displayed                     |
| Scroll down to the comments section                                               | The comments section should be displayed                   |
| Post a comment in the "Leave a Reply" text box and click on "Post Comment" button | The posted comment should be displayed below the blog post |

### Scenario 5: Sign Up

| Step                                                                                                  | Expected result                                                                  |
|-------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                    | The PHP Travels homepage should be displayed                                     |
| Click on 'My Account' and then 'Sign Up'                                                              | The 'Join us for FREE and get access to all features.' page should be displayed  |
| Fill in the required fields (First Name, Last Name, Mobile Number, Email, Password, Confirm Password) | The entered data should be filled in the respective fields                       |
| Click on the 'CREATE AN ACCOUNT' button                                                               | A user account should be successfully created and confirmation message displayed |

## After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-7-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of Explicit/Implicit/Fluent waits.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
