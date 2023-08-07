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

## Scenario 6: Add New User Group

| Steps                                           | Expected Result                                            |
|-------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                       | The login page opens                                       |
| 2. Enter valid username                         | Username is in the username field                          |
| 3. Enter valid password                         | Password is in the password field                          |
| 4. Click on login button                        | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to User Management from the menu    | User Management options are displayed                      |
| 6. Click on 'User Groups'                       | User Groups is opened                                      |
| 7. Click on 'Add' button                        | Redirected to 'Add User Group' form                        |
| 8. Enter necessary information and click 'Save' | New user group is saved                                    |
| 9. Verify the new group is in the list          | New group is visible on the list                           |

### Scenario 7: Edit Nationality

| Step                                                       | Expected Result                                            |
|------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                  | The login page opens                                       |
| 2. Enter valid username                                    | Username is in the username field                          |
| 3. Enter valid password                                    | Password is in the password field                          |
| 4. Click on login button                                   | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to the 'Admin => Nationalities' panel          | Nationalities table is displayed                           |
| 6. Click on an available nationality                       | The details of the nationality are visible                 |
| 7. Click on 'Edit' button and change the necessary details | Details are updated                                        |
| 8. Click on 'Save'                                         | The changes are saved and displayed                        | 

### Scenario 8: Logout

| Step                                                       | Expected Result                                            |
|------------------------------------------------------------|------------------------------------------------------------|
| 1. Open the website                                        | Website's login page is visible                            |
| 2. Log in to the application                               | User is logged in                                          |
| 3. Click on the 'Logout' button                            | User is logged out and redirected to the login page        |

### Scenario 9: Add New Employee

| Step                                               | Expected Result                                            |
|----------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                          | The login page opens                                       |
| 2. Enter valid username                            | Username is in the username field                          |
| 3. Enter valid password                            | Password is in the password field                          |
| 4. Click on login button                           | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'PIM' on the menu                      | PIM options are displayed                                  |
| 6. Click on 'Add Employee'                         | Add Employee form is visible                               |
| 7. Fill in the necessary details                   | Details are entered in respective fields                   |
| 8. Click on 'Save' button                          | The new employee is saved and displayed                    | 

### Scenario 10: Assign Leave

| Step                                        | Expected Result                                            |
|---------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                   | The login page opens                                       |
| 2. Enter valid username                     | Username is in the username field                          |
| 3. Enter valid password                     | Password is in the password field                          |
| 4. Click on login button                    | User gets logged in and gets redirected to their dashboard |
| 5. Click on 'Leave' on the menu             | Leave options are displayed                                |
| 6. Click on 'Assign Leave'                  | Assign leave form is visible                               |
| 7. Fill in the necessary details            | Details are entered                                        |
| 8. Click on 'Assign'                        | Leave is assigned                                          | 

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
| 9. Log out from the user profile dropdown     | User is logged out                                         | 

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
| 9. Log out from the user profile dropdown                   | User is logged out                                         | 
| 10. Click on an employee from the results list              | Employee's personal details are displayed                  |
| 11. Click on 'Edit' button and change the necessary details | Details are updated                                        |
| 12. Click on 'Save'                                         | Changes are saved and displayed                            |
| 13. Log out from the user profile dropdown                  | User is logged out                                         |

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

| Step                                                         | Expected Result                                            |
|--------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                    | The login page opens                                       |
| 2. Enter valid username                                      | Username is in the username field                          |
| 3. Enter valid password                                      | Password is in the password field                          |
| 4. Click on login button                                     | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to the 'Admin => User Management => Users' panel | Users list is visible                                      |
| 6. Enter a search parameter in the search bar                | Parameter is entered                                       |
| 7. Click on 'Search'                                         | Search results are displayed                               | 
| 8. Click on an employee from the results list                | Employee's personal details are displayed                  |
| 9. Log out from the user profile dropdown                    | User is logged out                                         |

### Scenario 16: Verify Search Functionality

| Step                                        | Expected Result                                            |
|---------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                   | The login page opens                                       |
| 2. Enter valid username                     | Username is in the username field                          |
| 3. Enter valid password                     | Password is in the password field                          |
| 4. Click on login button                    | User gets logged in and gets redirected to their dashboard |
| 5. Enter a keyword in the search box        | Keyword is entered                                         |
| 6. Click search button                      | Search results are displayed                               |
| 7. Verify results match the entered keyword | Results matched with the entered keyword                   |

### Scenario 17: Reset Password

| Step                                 | Expected Result                                      |
|--------------------------------------|------------------------------------------------------|
| 1. Launch the application            | The login page opens                                 |
| 2. Click "Forgot your password" link | Redirect to password reset page                      |
| 3. Enter registered email            | Email is entered                                     |
| 4. Click on submit button            | Confirmation message for password reset is displayed |

### Scenario 18: Validate Pagination

| Step                                                             | Expected Result                                            |
|------------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                                        | The login page opens                                       |
| 2. Enter valid username                                          | Username is in the username field                          |
| 3. Enter valid password                                          | Password is in the password field                          |
| 4. Click on login button                                         | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to a page that has pagination (e.g., Employee List)  | Page with pagination is displayed                          |
| 6. Click on the previous button of pagination                    | Previous page is loaded                                    |
| 7. Click on the last page button of pagination                   | Last page is loaded                                        |
| 8. Click on the first page button of pagination                  | First page is loaded                                       |

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
| 8. Go to the employee profile page and click on 'Edit' button       | Employee edit options get opened                           |
| 9. Check if the custom field appears in the respective section      | Custom field is available in the respective section        |
| 10. Enter information into the custom field and click 'Save' button | Custom field information gets saved                        |
| 11. Validate custom field in the employee profile                   | Custom field information appears in the employee profile   |

### Scenario 20: Validate Assign Skill to Employee Profile

| Steps                                       | Expected Result                                            |
|---------------------------------------------|------------------------------------------------------------|
| 1. Launch the application                   | The login page opens                                       |
| 2. Enter valid username                     | Username is in the username field                          |
| 3. Enter valid password                     | Password is in the password field                          |
| 4. Click on login button                    | User gets logged in and gets redirected to their dashboard |
| 5. Navigate to 'PIM > Employee List' page   | Employee List page gets displayed                          |
| 6. Click on an employee                     | Employee Profile page gets displayed                       |
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