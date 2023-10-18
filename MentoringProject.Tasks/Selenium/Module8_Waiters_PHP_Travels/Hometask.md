# Waiters

## Description

Practicing using Explicit/Implicit/Fluent waits

## Materials

1. Official Selenium Website:
   - [SeleniumHQ](https://www.selenium.dev/)
2. Selenium Documentation:
   - [Selenium Documentation](https://www.selenium.dev/documentation/en/)
3. NUnit Framework:
   - [NUnit Official Website](https://nunit.org/)
4. Waiting Strategies:
   - [Waiting Strategies](https://www.selenium.dev/documentation/webdriver/waits/)

## Home Task

Your task is to test various functionalities of the website "https://booking.com" using C# Selenium with NUnit. Your goal is to create automated test scenarios to ensure different features of the website are working as expected. You should avoid using Thread.Sleep for waits and instead, use explicit waits such as WebDriverWait, to ensure reliable and stable test execution.

Test website: https://booking.com

### Scenario 1: Search Hotels

| Step                                                                                          | Expected Result                                |
|-----------------------------------------------------------------------------------------------|------------------------------------------------|
| Navigate to https://booking.com                                                               | The Booking.com homepage should be displayed   |
| Enter a destination in the search box                                                         | The selected destination should be filled in   |
| Choose Check-in and Check-out dates from the date picker                                      | The selected dates should be displayed         |
| Click on the "Search" button                                                                  | A list of hotels should be displayed           |

### Scenario 2: Searching for Attractions in a Specific City

| Step                                                                                                                            | Expected Result                                                                         |
|---------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| Navigate to https://booking.com                                                                                                 | The Booking.com homepage is displayed                                                   |
| Click on the "Attractions" menu item                                                                                            | The "Attractions" search page is displayed                                              |
| Enter a specific city in the search box                                                                                         | The selected city should be auto-filled in the search box                               |
| Select the desired dates for visiting the attraction                                                                            | The selected dates should be filled in                                                  |
| Click on the "Search" button                                                                                                    | A list of attractions in the specific city available on the selected dates is displayed |
| Click on an attraction from the list                                                                                            | The details page for the selected attraction is displayed                               |
| Check the availability and times for the selected attraction                                                                    | Available times and dates for the selected attraction are displayed                     |

### Scenario 3: Negative Checks for Car Rentals

| Step                                                                                                       | Expected Result                                                   |
|------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------|
| Navigate to https://booking.com                                                                            | The Booking.com homepage is displayed                             |
| Click on the "Car rentals" menu item                                                                       | The "Car rentals" page is displayed                               |
| Leave the 'Pick-up Location' field empty and click the "Search" button                                     | An error message is shown, advising to enter the pick-up location |
| Input invalid data (non-existent location) into the 'Pick-up Location' field and click the "Search" button | An error message is shown, advising to enter the pick-up location |
| Select a valid pick-up date but select a return date earlier than the pick-up date                         | Pick-up date = Drop-off date - 1 day                              |

### Scenario 4: Multi-City Flight Search

| Step                                                                        | Expected Result                                                              |
|-----------------------------------------------------------------------------|------------------------------------------------------------------------------|
| Navigate to https://booking.com                                             | The Booking.com homepage is displayed                                        |
| Click on the "Flights" menu item                                            | The "Flights" page is displayed                                              |
| Select "Multi-city" mode                                                    | The search forms for multiple destinations appear (must be 3 legs)           |
| Enter the departure and arrival destinations for all legs of the journey    | The selected destinations are filled in                                      |
| Select the flight departure date for the all legs of the journey            | The selected dates should be displayed                                       |
| Click on the 'Add' button to add another leg to the journey                 | An additional form for the next leg of the journey appears                   |
| Enter the departure and arrival destinations for the 4th leg of the journey | The selected destinations are filled in                                      |
| Select the flight departure date for the 4th leg                            | The selected date should be displayed                                        |
| Click 'Remove' button                                                       | Recently added leg of the journey is not displayed                           |
| Click on the "Search" button                                                | A list of available flights should be displayed for all legs of the journey  |

### Scenario 5: Searching for Hotels in a specific City with Filters

| Step                                                            | Expected Result                                                                            |
|-----------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| Navigate to https://booking.com                                 | The Booking.com homepage is displayed                                                      |
| Enter a specific city in the search box                         | The selected city is auto-filled in search box                                             |
| Click on the "Check-in" and "Check-out" date field              | The calendar for date selection should appear                                              |
| Select the check-in and check-out dates                         | The selected dates should be filled in                                                     |
| Select the number of adults, children, and rooms                | The selected numbers should be filled in                                                   |
| Click on the "Search" button                                    | A list of hotels in the specific city with availability on the selected dates is displayed |
| Apply filter for 'Property rating' and select '5 stars'         | The list updates to display only 5-star hotels                                             |
| Select 'Price (lowest first)' from 'Sort' dropdown              | The list updates to display hotels sorted by lowest price first                            |
| Apply filter for 'Hotel Facilities' and select 'Fitness Centre' | The list updates to display only hotels with a fitness centre                              |

### Scenario 6: Search, Select, and Attempt to Book a Hotel

| Step                                                                                                                                   | Expected Result                                                                                          |
|----------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------|
| Navigate to https://booking.com                                                                                                        | The Booking.com homepage is displayed                                                                    |
| Enter a city in the search box                                                                                                         | The entered city is auto-filled in search box                                                            |
| Click on the "Check-in" and "Check-out" date field                                                                                     | The calendar for date selection should appear                                                            |
| Select the check-in and check-out dates                                                                                                | The selected dates should be filled in                                                                   |
| Select the number of adults, children, and rooms                                                                                       | The selected numbers should be filled in                                                                 |
| Click on the "Search" button                                                                                                           | A list of hotels in the selected city is displayed with availability on the selected dates               |
| Select one of the hotels from the list                                                                                                 | The page for the selected hotel is displayed                                                             |
| On the hotel page, choose a suitable room under "Choose your room"                                                                     | The chosen room's details should be displayed                                                            |
| Click on the "I'll reserve" or "Reserve now" button                                                                                    | A final review and personal details entry page is displayed                                              |
| Enter personal detail placeholders. For example, `John Doe` as name, `john.doe@email.com` as email, and `555-555-5555` as phone number | The placeholders are entered as personal details                                                         |
| Click 'Next: Final details' button                                                                                                     | Payments details page is displayed                                                                       |
| Click 'Check your booking' button                                                                                                      | Verify that your booking data is correct and 'Book with commitment to pay' button is available for click |

### Scenario 7: Verifying Language Change

| Step                                                                                                     | Expected Result                                  |
|----------------------------------------------------------------------------------------------------------|--------------------------------------------------|
| Navigate to https://booking.com                                                                          | The Booking.com homepage should be displayed     |
| Choose a different language from the dropdown menu                                                       | The site should reload in the selected language  |

### Scenario 8: Booking an Airport Taxi

| Step                                                                       | Expected Result                                                                              |
|----------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|
| Navigate to https://booking.com                                            | The Booking.com homepage is displayed                                                        |
| Click on the "Airport taxis" menu item                                     | The "Book your airport taxi" page is displayed                                               |
| Enter a valid Pick-up location and destination                             | Pick-up and Destination are selected                                                         |
| Enter a valid flight arrival date and time                                 | Date and time are selected                                                                   |
| Click on the "Search" button                                               | The available taxis for the entered flight arrival date and journey data should be displayed |
| Click on the most expensive taxi offer and click 'Continue' button         | The details page for the selected taxi is displayed and journey data should be displayed     |

### Scenario 9: Verify Invalid Login

| Step                                                                     | Expected Result                                                                                  |
|--------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|
| Navigate to https://booking.com                                          | The Booking.com homepage should be displayed                                                     |
| Click on the `Sign in` button                                            | The login page should be displayed                                                               |
| Enter invalid or unregistered email addresses in the 'Email' field       | Create password page is displayed. Verify 'Password' and 'Confirm Password' fields are displayed |


## Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of Explicit/Implicit/Fluent waits.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!