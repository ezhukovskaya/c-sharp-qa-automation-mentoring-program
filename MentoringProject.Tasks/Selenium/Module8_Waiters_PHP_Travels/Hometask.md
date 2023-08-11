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

### Scenario 6: Check Offer Details

| Step                                                                                             | Expected Result                                                                       |
|--------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                               | The PHP Travels homepage should be displayed                                          |
| Click on the "Offers" menu item                                                                  | The "Offers" page should be displayed                                                 |
| Click on one of the offers listed                                                                | The chosen offer detail page is displayed                                             |
| Verify all the details of the offer presented (such as pricing, number of nights, details, etc.) | All the details should be correctly displayed and should match with the offer listing |

### Scenario 7: Navigation Test

| Step                                                                                           | Expected Result                                                       |
|------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                             | The PHP Travels homepage should be displayed                          |
| Navigate using the menu bar to each of the different pages (like Flights, Hotels, Tours, etc.) | Each page is successfully displayed without any errors or load issues |

### Scenario 8: Contact Us Form

| Step                                                                                     | Expected Result                                                      |
|------------------------------------------------------------------------------------------|----------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                       | The PHP Travels homepage should be displayed                         |
| Click on the "Contact Us" menu item                                                      | The "Contact Us" page should be displayed                            |
| Fill in the required fields (Name, Email, Subject, Message) and click on "Submit" button | A success message should be shown indicating the message is received |

### Scenario 9: Currency Change

| Step                                                                                      | Expected Result                                                                     |
|-------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                        | The PHP Travels homepage should be displayed                                        |
| From the top right corner, click on the currency dropdown and select a different currency | The displayed prices on the page should change to the unit of the selected currency |
| Check some prices before and after the change for validation                              | The prices should match with the currency conversion rate                           |

### Scenario 10: Newsletter Subscription

| Step                                                                                                                    | Expected Result                                                           |
|-------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                                      | The PHP Travels homepage should be displayed                              |
| Scroll down to the bottom of the page, enter a valid email address in the 'Subscribe' input field and click 'Subscribe' | A success alert should be shown indicating subscription to the Newsletter |

## After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-8-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of Explicit/Implicit/Fluent waits.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!
