using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MentoringProject.Tasks.Selenium.Module3.Test;

internal abstract class BaseTest
{
    protected IWebDriver Driver;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Driver = new ChromeDriver();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Driver.Quit();
    }
}