# Diploma Project

## Description
The diploma project aims to automate the testing process for the website 
[https://opensource-demo.orangehrmlive.com/](https://opensource-demo.orangehrmlive.com/).
It will use [C#](https://docs.microsoft.com/en-us/dotnet/csharp/), [NUnit](https://nunit.org/) 
and [Selenium WebDriver](https://www.selenium.dev/documentation/en/). Throughout this project, 
you should adhere strictly to the [Page Object Model (POM)](https://www.selenium.dev/documentation/en/guidelines_and_recommendations/page_object_models/) 
principles and implement a browser factory.

## Pre-Conditions

1. Install [JetBrains Rider](https://www.jetbrains.com/rider/)/[Visual Studio](https://visualstudio.microsoft.com/downloads/) with the latest version.
2. Setup [.NET Core 7.0](https://dotnet.microsoft.com/download) along with [C# 11.0](https://devblogs.microsoft.com/dotnet/csharp-11-standardization-plan/) support.
3. Setup [NUnit](https://www.nunit.org/) test framework.
4. Setup [Selenium WebDriver](https://www.selenium.dev/downloads/).
5. Understanding about [Page Object Model](https://www.selenium.dev/documentation/en/guidelines_and_recommendations/page_object_models/).
6. Understanding about implementing a [Browser Factory](https://toolsqa.com/selenium-webdriver/c-sharp/browser-factory/).
7. Knowledge in writing different levels of test scenarios.

## Test Scenarios
**(Mock test data: Username: "Admin", Password: "admin123")**

### Scenario 1: Validate Successful Login

| Steps                     | Expected Result                                              |
|---------------------------|--------------------------------------------------------------|
| 1. Launch the application | The login page opens                                         |
| 2. Enter valid username   | Username is in the username field                            |
| 3. Enter valid password   | Password is in the password field                            |
| 4. Click on login button  | User gets logged in and gets redirected to their dashboard   |

### Scenario 2: Validate Successful Logout

| Steps                                 | Expected Result                                            |
|---------------------------------------|------------------------------------------------------------|
| 1. Launch the application             | The login page opens                                       |
| 2. Enter valid username               | Username is in the username field                          |
| 3. Enter valid password               | Password is in the password field                          |
| 4. Click on login button              | User gets logged in and gets redirected to their dashboard |
| 5. Click on the user profile dropdown | Dropdown options appear                                    |
| 6. Click on the 'Logout' button       | User gets logged out and redirected to the login page      |

### Scenario 3: Validate Add New Employee

| Steps                                                       | Expected Result                                            |
|-------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                   | The login page opens                                       |
| 2. Enter valid username                                     | Username is in the username field                          |
| 3. Enter valid password                                     | Password is in the password field                          |
| 4. Click on login button                                    | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to PIM from the menu                            | PIM options get displayed                                  |
| 6. Click on the 'Add Employee' tab                          | 'Add Employee' form gets displayed                         |
| 7. Fill in the necessary details                            | Details get entered into the respective fields             |
| 8. Click on 'Save' button                                   | Form gets submitted                                        |
| 9. Validate that the employee is shown in the Employee List | The new employee details appear in the Employee List       |

### Scenario 4: Validate Search Functionality

| Steps                                              | Expected Result                                            |
|----------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                          | The login page opens                                       |
| 2. Enter valid username                            | Username is in the username field                          |
| 3. Enter valid password                            | Password is in the password field                          |
| 4. Click on login button                           | User gets logged in and gets redirected to their dashboard |
| 5. Enter a keyword in the search box               | Keyword has been entered                                   |
| 6. Click the search button                         | Search results get displayed                               |
| 7. Verify if the results match the entered keyword | Results match the entered keyword                          |
| 8. Logout from the user profile dropdown           | User is logged out                                         |

### Scenario 5: Validate Performance Management Functionality

| Steps                                                                                 | Expected Result                                                  |
|---------------------------------------------------------------------------------------|------------------------------------------------------------------|
| 1. Launch the application                                                             | The login page opens                                             |
| 2. Enter valid username                                                               | Username is in the username field                                |
| 3. Enter valid password                                                               | Password is in the password field                                |
| 4. Click on login button                                                              | User gets logged in and gets redirected to their dashboard       |
| 5. Navigate to 'Performance => Configure => Key Performance Indicators' from the menu | Key Performance Indicators page is displayed                     |
| 6. Click on the 'Add' button                                                          | 'Add Key Performance Indicator' form page is displayed           |
| 7. Fill in the necessary details and click 'Save'                                     | Form gets submitted and the new indicator is saved               |
| 8. Validate the new performance indicator is listed in the KPI list                   | The new performance indicator is listed in the KPI list          |
| 9. Choose a Key Performance Indicator, click on the checkbox                          | The checkbox is selected and 'Delete Selected' button displays   |
| 10. Click on 'Delete Selected'                                                        | Confirmation pop-up is displayed                                 |
| 11. Confirm the deletion                                                              | The indicator is deleted                                         |
| 12. Validate the KPI record got deleted in the KPI list                               | The indicator is not listed in the KPI list                      |

### Scenario 6: Validate Admin Function

| Steps                                         | Expected Result                                            |
|-----------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                     | The login page opens                                       |
| 2. Enter valid username                       | Username is in the username field                          |
| 3. Enter valid password                       | Password is in the password field                          |
| 4. Click on login button                      | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'Admin' on the menu               | Admin options are displayed                                |
| 6. Validate the presence of user management   | User Management options are available                      |
| 7. Click on 'Job' link under Admin            | Job options are displayed                                  |
| 8. Validate that 'Job Titles' link is present | 'Job Titles' link is available                             |

### Scenario 7: Edit Nationality

| Step                                                                          | Expected Result                                            |
|-------------------------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                                     | The login page opens                                       |
| 2. Enter valid username                                                       | Username is in the username field                          |
| 3. Enter valid password                                                       | Password is in the password field                          |
| 4. Click on login button                                                      | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to the 'Admin => More => Nationalities' panel                     | Nationalities table is displayed                           |
| 7. Click on 'Edit' button on any nationality and change the necessary details | Details are updated                                        |
| 8. Click on 'Save'                                                            | The changes are saved and displayed                        | 

### Scenario 8: Validate Dashboard Access

| Steps                                                | Expected Result                                               |
|------------------------------------------------------|---------------------------------------------------------------|
| 1. Launch the application                            | The login page opens                                          |
| 2. Enter valid username                              | Username is in the username field                             |
| 3. Enter valid password                              | Password is in the password field                             |
| 4. Click on login button                             | User gets logged in and gets redirected to their dashboard    |
| 5. Click on 'Dashboard' on the menu                  | Dashboard page is displayed                                   |
| 6. Validate the presence of the dashboard's elements | Dashboard elements such as quick launch toolbar are available |

### Scenario 9: Validate Recruitment Management Functionality

| Steps                                                            | Expected Result                                             |
|------------------------------------------------------------------|-------------------------------------------------------------|
| 1. Launch the application                                        | The login page opens                                        |
| 2. Enter valid username                                          | Username is in the username field                           |
| 3. Enter valid password                                          | Password is in the password field                           |
| 4. Click on login button                                         | User gets logged in and gets redirected to their dashboard  |
| 5. Navigate to 'Recruitment => Vacancies' from the main menu     | Vacancies page is displayed                                 |
| 6. Click on 'Add' button                                         | 'Add Job Vacancy' form page is displayed                    |
| 7. Fill in the necessary details and click 'Save'                | Form gets submitted and the new vacancy is saved            |
| 8. Navigate back to 'Recruitment => Vacancies'                   | Vacancies page is displayed                                 |
| 9. Validate the new vacancy is listed in the job vacancies       | The new vacancy is listed in the job vacancies              |
| 10. Click on 'Delete' button                                     | Confirmation pop-up is displayed                            |
| 11. Confirm the deletion                                         | The vacancy is deleted                                      |
| 12. Navigate back to 'Recruitment => Vacancies'                  | Vacancies page is displayed                                 |
| 13. Validate the vacancy record got deleted in the job vacancies | The Vacancy is not listed in the job vacancies              |

### Scenario 10: Assign Leave

#### Preconditions: create employee

| Steps                                                                        | Expected Result                                                |
|------------------------------------------------------------------------------|----------------------------------------------------------------|
| 1. Launch the application                                                    | The login page opens                                           |
| 2. Enter valid username                                                      | Username is in the username field                              |
| 3. Enter valid password                                                      | Password is in the password field                              |
| 4. Click on login button                                                     | User gets logged in and gets redirected to their dashboard     |
| 5. Click on 'Leave' on the main menu                                         | Leave options are displayed                                    |
| 6. Click on 'More' on the Leave menu                                         |                                                                |
| 7. Click on 'Assign Leave' from dropdown menu                                | 'Assign Leave' page is displayed                               |
| 8. Enter employee name from preconditions, types of leave, date and comments | Corresponding fields are filled                                |
| 9. Click 'Assign' button                                                     | Confirmation popup with title 'Confirm Leave Assignment' opens |
| 10. Click Ok                                                                 | Leave gets assigned for the specified employee                 |

### Scenario 11: Add Job Title

| Step                                                       | Expected Result                                            |
|------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                  | The login page opens                                       |
| 2. Enter valid username                                    | Username is in the username field                          |
| 3. Enter valid password                                    | Password is in the password field                          |
| 4. Click on login button                                   | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to 'Admin => Job' panel                        | Job options are displayed                                  |
| 6. Click on 'Job Titles'                                   | Job Titles table is visible                                |
| 7. Click on 'Add' button and fill in the necessary details | Details are entered                                        |
| 8. Click on 'Save'                                         | The new title is saved and displayed                       | 

### Scenario 12: Search Employee

#### Preconditions: create employee

| Step                                                          | Expected Result                                            |
|---------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                     | The login page opens                                       |
| 2. Enter valid username                                       | Username is in the username field                          |
| 3. Enter valid password                                       | Password is in the password field                          |
| 4. Click on login button                                      | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'PIM' on the menu                                 | PIM options are displayed                                  |
| 6. Click on 'Employee List'                                   | Employee list is visible                                   |
| 7. Enter a search parameter as an employee from preconditions | Parameter is entered                                       |
| 8. Click on 'Search'                                          | Search results are displayed                               |
| 8. Enter a search parameter as '1234567'                      |                                                            |
| 8. Click on 'Search'                                          | 'Results not found' appears                                |
| 9. Log out from the user profile dropdown                     | User is logged out                                         | 

### Scenario 13: Edit Employee Details

| Step                                                        | Expected Result                                            |
|-------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                   | The login page opens                                       |
| 2. Enter valid username                                     | Username is in the username field                          |
| 3. Enter valid password                                     | Password is in the password field                          |
| 4. Click on login button                                    | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'PIM' on the menu                               | PIM options are displayed                                  |
| 6. Click on 'Employee List'                                 | Employee list is visible                                   |
| 7. Enter a search parameter in the search bar               | Parameter is entered                                       |
| 8. Click on 'Search'                                        | Search results are displayed                               |
| 9. Click on an employee from the results list               | Employee's personal details are displayed                  |
| 10. Click on 'Edit' button and change the necessary details | Details are updated                                        |
| 11. Click on 'Save'                                         | Changes are saved and displayed                            |
| 12. Log out from the user profile dropdown                  | User is logged out                                         |

### Scenario 14: Delete Employee

| Step                                          | Expected Result                                            |
|-----------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                     | The login page opens                                       |
| 2. Enter valid username                       | Username is in the username field                          |
| 3. Enter valid password                       | Password is in the password field                          |
| 4. Click on login button                      | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'PIM' on the menu                 | PIM options are displayed                                  |
| 6. Click on 'Employee List'                   | Employee list is visible                                   |
| 7. Enter a search parameter in the search bar | Parameter is entered                                       |
| 8. Click on 'Search'                          | Search results are displayed                               |
| 9. Click on an employee from the results list | Employee's personal details are displayed                  |
| 10. Click 'Delete'                            | A confirmation box is displayed                            |
| 11. Confirm the deletion                      | The employee is deleted                                    |
| 12. Log out from the user profile dropdown    | User is logged out                                         |

### Scenario 15: Search Admin

#### Preconditions: Create user in Admin -> User Management

| Step                                                                                    | Expected Result                                            |
|-----------------------------------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                                               | The login page opens                                       |
| 2. Enter valid username                                                                 | Username is in the username field                          |
| 3. Enter valid password                                                                 | Password is in the password field                          |
| 4. Click on login button                                                                | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to the 'Admin => User Management => Users' panel                            | Users list is visible                                      |
| 6. Enter a search parameter in the search field Username -> username from preconditions | Parameter is entered                                       |
| 7. Click on 'Search'                                                                    | Search results are displayed                               | 
| 8. Click on an employee from the results list                                           | Employee's personal details are displayed                  |
| 9. Log out from the user profile dropdown                                               | User is logged out                                         |

### Scenario 16: Validate Candidate Management in Recruitment Functionality

| Steps                                                            | Expected Result                                          |
|------------------------------------------------------------------|----------------------------------------------------------|
| 1. Launch the application                                        | The login page opens                                     |
| 2. Enter valid username                                          | Username is entered in the username field                |
| 3. Enter valid password                                          | Password is entered in the password field                |
| 4. Click on login button                                         | User is logged in and redirected to the dashboard        |
| 5. Navigate to 'Recruitment => Candidates' from the main menu    | 'Candidates' page is displayed                           |
| 6. Click on the 'Add' button                                     | 'Add Candidate' form is displayed                        |
| 7. Fill out the form with candidate details and click 'Save'     | The form is submitted and the new candidate is added     |
| 8. Validate the new candidate is listed in the 'Candidates' list | The new candidate is visible in the list                 |
| 9. Choose the newly added candidate, click on the checkbox       | The checkbox next to the candidate's details is selected |
| 10. Click on 'Delete Selected'                                   | Confirmation pop-up is displayed                         |
| 11. Confirm the deletion                                         | The selected candidate is deleted                        |
| 12. Validate the candidate is removed from the 'Candidates' list | The candidate's details are removed from the list        |

### Scenario 17: Reset Password

#### Preconditions: Create user in Admin -> User Management

| Step                                 | Expected Result                                      |
|--------------------------------------|------------------------------------------------------|
| 1. Launch the application            | The login page opens                                 |
| 2. Click "Forgot your password" link | Redirect to password reset page                      |
| 3. Enter username from preconditions | Username is entered                                  |
| 4. Click on Reset Password button    | Confirmation message for password reset is displayed |

### Scenario 18: Validate Job Titles Management Functionality

| Steps                                                          | Expected Result                                          |
|----------------------------------------------------------------|----------------------------------------------------------|
| 1. Launch the application                                      | The login page opens                                     |
| 2. Enter valid username                                        | Username is in the username field                        |
| 3. Enter valid password                                        | Password is in the password field                        |
| 4. Click on login button                                       | User gets logged in and is redirected to their dashboard |
| 5. Navigate to 'Admin => Job => Job Titles' from the main menu | 'Job Titles' page is displayed                           |
| 6. Click on the 'Add' button                                   | 'Add Job Title' form page is displayed                   |
| 7. Fill in the necessary details and click 'Save'              | Form gets submitted and the new job title is saved       |
| 8. Validate the new job title in the job titles list           | The new job title is listed                              |
| 9. Choose a job title, click on the checkbox                   | The checkbox is selected                                 |
| 10. Click on 'Delete' button                                   | Confirmation pop-up is displayed                         |
| 11. Confirm the deletion                                       | The job title is deleted                                 |
| 12. Validate the job title got deleted from the list           | The job title is not in the list anymore                 |

### Scenario 19: Validate Add Custom Fields to Employee Profile

| Steps                                                               | Expected Result                                            |
|---------------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                           | The login page opens                                       |
| 2. Enter valid username                                             | Username is in the username field                          |
| 3. Enter valid password                                             | Password is in the password field                          |
| 4. Click on login button                                            | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to 'PIM > Configuration > Custom Fields'                | Custom Fields page gets displayed                          |
| 6. Click on 'Add' button                                            | 'Add Custom Field' form gets displayed                     |
| 7. Fill in the form and click 'Save' button                         | Custom field is saved                                      |
| 8. Navigate to 'PIM > Employee List' page                           | Employee List page gets displayed                          |
| 9. Select any employee and click on 'Edit' button                   | Employee edit options get opened                           |
| 10. Check if the custom field appears in the respective section     | Custom field is available in the respective section        |
| 11. Enter information into the custom field and click 'Save' button | Custom field information gets saved                        |
| 12. Validate custom field in the employee profile                   | Custom field information appears in the employee profile   |

### Scenario 20: Validate Assign Skill to Employee Profile

| Steps                                       | Expected Result                                            |
|---------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                   | The login page opens                                       |
| 2. Enter valid username                     | Username is in the username field                          |
| 3. Enter valid password                     | Password is in the password field                          |
| 4. Click on login button                    | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to 'PIM > Employee List' page   | Employee List page gets displayed                          |
| 6. Click Edit on an employee                | Employee Profile page gets displayed                       |
| 7. Navigate to 'Qualifications' tab         | Qualifications tab is opened                               |
| 8. Click on 'Add' button in Skill section   | Skill form gets displayed                                  |
| 9. Fill in the form and click 'Save' button | Skill is added                                             |
| 10. Validate skill in the skill list        | New skill appears in the skill list                        |

### After all check list

1. Make two screenshots that your test passes successfully for both browsers (Chrome, Firefox)
2. Create Pull Request with name `Module-{TaskName}`
3. Add screenshots to PR description
4. Notify your mentor about completing the task

### Evaluation Criteria

Your homework will be evaluated based on the following criteria:

- Correct implementation of POM and Browser Factory.
- Proper organization and structure of the test code.
- Appropriate use of assertions to verify the expected outcomes.

#### Good luck with your homework! If you have any questions, feel free to reach out for clarification. Happy coding!