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
| Choose date from the date picker                                                                        | The selected date should be reflected in the date input box           |
| Click on the "Search" button                                                                            | A list of available cars in the selected location should be displayed |

### Scenario 4: Tour Booking

| Step                                                                                                          | Expected Result                                                         |
|---------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                            | The PHP Travels homepage should be displayed                            |
| Click on the "Tours" menu item                                                                                | The "Tours" page should be displayed                                    |
| Enter a location in the search box and select a location from the dropdown auto-complete list                 | The selected location should be filled in the search box                |
| Choose Check-in date from the date picker                                                                     | The selected date should be reflected in the date input box             |
| Select number of adults and children from the dropdown                                                        | The selected number should be reflected in the respective input box     |
| Click on the "Search" button                                                                                  | A list of available tours in the selected location should be displayed  |

### Scenario 5: Language Selection and Validation

| Step                                                                                                                                                  | Expected Result                                                     |
|-------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                                                                    | The PHP Travels homepage should be displayed                        |
| From the top right corner, click on the language dropdown and select a different language                                                             | The website content should change to the selected language          |
| Verify the translation of some key words or phrases on the page (like "Hotels", "Flights", "Tours", etc.)                                             | The translated words or phrases should match the selected language  |

### Scenario 6: Checking the Social Media Links

| Step                                                                   | Expected Result                                                      |
|------------------------------------------------------------------------|----------------------------------------------------------------------|
| Navigate to https://phptravels.net                                     | The PHP Travels homepage should be displayed                         |
| Scroll down to the bottom of the page                                  | The footer section should be displayed                               |
| Click on each of the social media icons                                | The respective social media page should open up in a new browser tab |

### Scenario 7: Navigation Test

| Step                                                                                           | Expected Result                                                       |
|------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                             | The PHP Travels homepage should be displayed                          |
| Navigate using the menu bar to each of the different pages (like Flights, Hotels, Tours, etc.) | Each page is successfully displayed without any errors or load issues |

### Scenario 8: Verify Error Message for Invalid Login

| Step                                                                                                             | Expected Result                                                         |
|------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                                               | The PHP Travels homepage should be displayed                            |
| Click on 'My Account' and then 'Login'                                                                           | The login page should be displayed                                      |
| Input invalid or unregistered email addresses in the 'Email' field and any password in the 'Password' field      | An error message should appear, indicating a failure in user login      |

### Scenario 9: Currency Change

| Step                                                                                      | Expected Result                                                                     |
|-------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                        | The PHP Travels homepage should be displayed                                        |
| From the top right corner, click on the currency dropdown and select a different currency | The displayed prices on the page should change to the unit of the selected currency |
| Check some prices before and after the change for validation                              | The prices should match with the currency conversion rate                           |

### Scenario 10: Checking the Hotel Booking Process

| Step                                                                                          | Expected Result                                                                                            |
|-----------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------|
| Navigate to https://phptravels.net                                                            | The PHP Travels homepage should be displayed                                                               |
| Click on the "Hotels" menu item                                                               | The "Hotels" page should be displayed                                                                      |
| Enter a location in the search box and select a location from the dropdown auto-complete list | The selected location should be filled in the search box                                                   |
| Choose Check-in and Check-out dates from the date picker                                      | The selected dates should be reflected in the date input boxes                                             |
| Select the number of rooms and adults                                                         | The selected number should be displayed in the rooms and adults input box                                  |
| Click on the "Search" button                                                                  | A list of available hotels in the selected location should be displayed                                    |
| Select a suitable hotel and select a room via clicking Book Now                               | Hotel Booking form is open                                                                                 |
| Fill in Personal information and in Payments methods select Pay Later                         |                                                                                                            |
| Check I agree to all Terms & Conditions and Confirm booking                                   | Invoice document page is open and all data corresponds to the information you entered in the previous step |
| Click Download as PDF                                                                         | Confirm that pdf contains correct data                                                                     |

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
