using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MentoringProject.tasks.selenium.module1.task1.test;

public class FirstSeleniumTest
{
    [Test]
    public void InvalidLoginTest()
    {
        // Set up the ChromeDriver (Make sure you have chromedriver.exe in your project folder)
        var driver = new ChromeDriver();
        driver.Url = "https://accounts.spotify.com/en/login/";
        driver.Manage().Window.Maximize();

        // Find the email and password input fields
        var emailInput = driver.FindElement(By.Id("login-username"));
        var passwordInput = driver.FindElement(By.Id("login-password"));

        // Enter invalid credentials
        emailInput.SendKeys("invalid_username");
        passwordInput.SendKeys("invalid_password");

        // Find and click the login button
        var loginButton = driver.FindElement(By.Id("login-button"));
        loginButton.Click();

        // Check for an error message indicating invalid login
        Thread.Sleep(3000);
        var errorMessage = driver.FindElement(By.CssSelector(".encore-negative-set span"));
        Assert.IsTrue(errorMessage.Text.Contains("Incorrect username or password."));
        driver.Quit();
        driver.Dispose();
    }
}