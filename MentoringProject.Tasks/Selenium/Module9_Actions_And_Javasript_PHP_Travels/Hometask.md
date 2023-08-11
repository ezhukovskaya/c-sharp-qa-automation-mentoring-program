# Different Page Elements

## Materials

[Selenium Actions Class](https://toolsqa.com/selenium-webdriver/actions-class-in-selenium/)

## Pre-Conditions

Task from [Home Task 7](Hometask.md) must be done, approved and merged

## Home Task

In this task you need to automate the provided test scenarios using Actions and JavaScript instead of regular Selenium 
interactions

WebSite: https://phptravels.net

### Scenario 1: Carousel Navigation

| Step                                                                    | Expected Result                                         |
|-------------------------------------------------------------------------|---------------------------------------------------------|
| 1. Launch https://phptravels.net                                        | PHP Travels homepage should display.                    |
| 2. Use `Tab` key to change focus to 'Hotels' menu item.                 | 'Hotels' menu item is highlighted.                      |
| 3. Use `Enter` key to navigate to 'Hotels' page.                        | 'Hotels' page opens.                                    |
| 4. Use arrow keys to navigate the Carousel images on the 'Hotels' page. | Carousel images cycle through when Arrow keys are used. |

### Scenario 2: Open Account Drop Down and Select Login

| Step                                                                             | Expected Result                                |
|----------------------------------------------------------------------------------|------------------------------------------------|
| 1. Launch https://phptravels.net                                                 | PHP Travels homepage should display            |
| 2. Use `Tab` key repeatedly to shift focus onto the 'My Account' drop down menu. | 'My Account' dropdown menu is highlighted.     |
| 3. Press `Enter` key to see the 'My Account' dropdown options.                   | Dropdown options - 'Sign up', 'Login' display. |
| 4. With dropdown opened, use `Tab` to highlight 'Login' and press `Enter`.       | User is redirected to the Login page.          |

### Scenario 3: Open a Blog Post through Keyboard Navigation

| Step                                                                  | Expected Result                                            |
|-----------------------------------------------------------------------|------------------------------------------------------------|
| 1. Launch https://phptravels.net                                      | PHP Travels homepage should display                        |
| 2. Use `Tab` key to navigate to "Blog" menu and `Enter` to select it. | "Blog" page opens.                                         |
| 3. Use `Tab` key repeatedly to scroll through the blog posts.         | Each blog post gets highlighted as keyboard focus changes. |
| 4. Press `Enter` key at any blog post.                                | Focused blog post page is opened.                          |

### Scenario 4: Navigate the Footer Links

| Step                                                                | Expected Result                                          |
|---------------------------------------------------------------------|----------------------------------------------------------|
| 1. Launch https://phptravels.net                                    | PHP Travels homepage should display.                     |
| 2. Use `Tab` key repeatedly till you reach one of the footer links. | Footer link is focused.                                  |
| 3. Use the Arrow Keys to navigate through the footer links.         | Individual footer links can be highlighted.              |
| 4. Press `Enter` key to navigate to the highlighted link's page.    | The webpage associated with the footer link should open. |

### Scenario 5: Selecting a City from AutoComplete

| Step                                                                                                    | Expected Result                             |
|---------------------------------------------------------------------------------------------------------|---------------------------------------------|
| 1. Launch https://phptravels.net                                                                        | PHP Travels homepage should display         |
| 2. Use `Tab` key to navigate to the search field.                                                       | The search field is focused.                |
| 3. Type 'New Yo' and wait for the auto-complete suggestions.                                            | Suggestions should display.                 |
| 4. Use `Down Arrow` key to navigate through auto-complete suggestions and `Enter` to select 'New York'. | 'New York' is selected in the search field. |


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
