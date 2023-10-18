# Different Page Elements

## Materials

[Selenium Actions Class](https://toolsqa.com/selenium-webdriver/actions-class-in-selenium/)

## Pre-Conditions

Task from [Home Task 8](../Module8_Waiters_PHP_Booking/Hometask.md) must be done, approved and merged

## Home Task

In this task you need to automate the provided test scenarios using Actions and JavaScript instead of regular Selenium
interactions

WebSite: https://www.booking.com

### Scenario 2: Navigate to Register Page Using Keyboard

| Step                                                        | Expected Result                                                     |
|-------------------------------------------------------------|---------------------------------------------------------------------|
| 1. Launch https://www.booking.com                           | Booking.com homepage should display.                                |
| 2. Use `Tab` key repeatedly to shift focus to `Register`.   | "Register" is highlighted.                                          |
| 3. Press `Enter` key to navigate to the registration page.  | User is redirected to the registration page.                        |

### Scenario 2: Change Currency with Keyboard Navigation

| Step                                                           | Expected Result                                    |
|----------------------------------------------------------------|----------------------------------------------------|
| 1. Launch https://www.booking.com                              | Booking.com homepage should display                |
| 2. Use `Tab` key to navigate to the Currency dropdown menu.    | The Currency dropdown is highlighted               |
| 3. Press `Enter` key to see the Currency dropdown options.     | Dropdown options for different currencies display. |
| 4. Use the Arrow Keys to navigate to the last currency choice. | Individual currency choice gets highlighted.       |
| 5. Press `Enter` key to select a highlighted currency.         | The page updates to the selected currency.         |

### Scenario 3: Search for Stays in a Specific Location

| Step                                                                                                      | Expected Result                                         |
|-----------------------------------------------------------------------------------------------------------|---------------------------------------------------------|
| 1. Launch https://www.booking.com                                                                         | Booking.com homepage should display.                    |
| 2. Use `Tab` key repeatedly to shift focus onto the 'Stays' search bar.                                   | 'Stays' search bar is highlighted.                      |
| 3. Type in a location (e.g., 'New York') and use `Tab` key to navigate to the next field (Check-in date). | Location is set to 'New York'.                          |
| 4. Use `Arrow` keys to select a Check-in date and `Tab` key to navigate to Check-out date field.          | Check-In date is selected.                              |
| 5. Use `Arrow` keys to select a Check-out date and `Tab` key to navigate to 'Guests' field.               | Check-Out date is selected.                             |
| 6. Use `Arrow` keys to select number of guests and `Tab` key to navigate to 'Search' button.              | Number of guests is selected.                           |
| 7. Press `Enter` key to initiate the search.                                                              | Search results for 'Stays' in 'New York' are displayed. |

### Scenario 4: Selecting a City from AutoComplete

| Step                                                                                                                                         | Expected Result                                   |
|----------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------|
| 1. Launch https://www.booking.com                                                                                                            | Booking.com homepage should display               |
| 2. Use `Tab` key to navigate to the search field.                                                                                            | The search field is focused.                      |
| 3. Type 'New Yo' and wait for the auto-complete suggestions.                                                                                 | Suggestions should display.                       |
| 4. Use `Down Arrow` key to navigate through auto-complete suggestions and `Enter` to select 'New York All Airports' from the autocomplete.   | 'New York NYC' is selected in the dropdown field. |

### Scenario 5: Skip to Main Content

| Step                                                    | Expected Result                          |
|---------------------------------------------------------|------------------------------------------|
| 1. Launch https://www.booking.com                       | Booking.com homepage should display      |
| 2. Click `Tab` key.                                     | Skip to main content button is displayed |
| 3. Click 'Skip to main content' button using JavaScript | Booking menu is not displayed            |
| 4. Click `Shift + Tab` keys                             | Booking menu is displayed                |

## After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-9-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!