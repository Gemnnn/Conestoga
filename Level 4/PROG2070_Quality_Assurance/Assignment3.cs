// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DefaultSuiteTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void assignment3AllValidInputValuesAllInputAccepted() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1067, 839);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q7");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2020");
    driver.FindElement(By.CssSelector("button")).Click();
    driver.FindElement(By.Id("jdPower")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".heading-xxl")).Text, Is.EqualTo("2020 Audi Q7"));
  }
  [Test]
  public void assignment3InvalidPhoneInputDetectInvalidPhone() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q7");
    driver.FindElement(By.CssSelector("div:nth-child(4) > .form-control:nth-child(3)")).Click();
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2020");
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Phone is not valid"));
  }
  [Test]
  public void assignment3InvalidPostalCodeInputDetectInvalidPostalCode() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.CssSelector(".form-control:nth-child(6)")).Click();
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("AAAAAA");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q7");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2020");
    driver.FindElement(By.CssSelector("button")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Postal code is not valid"));
  }
  [Test]
  public void assignment3InvalidVehicleInformationInputNotfound() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("dd");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("sonata");
    driver.FindElement(By.CssSelector("div:nth-child(4) > .form-control:nth-child(2)")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("dd");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("1990");
    driver.FindElement(By.CssSelector("button")).Click();
    driver.FindElement(By.Id("jdPower")).Click();
    Assert.That(driver.FindElement(By.CssSelector("h1")).Text, Is.EqualTo("404 - Page Not Found"));
  }
  [Test]
  public void assignment3InvalidYearInputDetectInvalidYear() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("31");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("aa");
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Year is not valid"));
  }
  [Test]
  public void assignment3NoInputCityDetectNoInput() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.CssSelector(".form-control:nth-child(4)")).Click();
    driver.FindElement(By.Id("txtCity")).SendKeys(" ");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("hyundai");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("328i");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2000");
    driver.FindElement(By.CssSelector("button")).Click();
    {
      var element = driver.FindElement(By.CssSelector("button"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("City is required"));
  }
  [Test]
  public void assignment3NoInputFirstNameDetectNoInput() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.CssSelector("div:nth-child(4) > .form-control:nth-child(1)")).Click();
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q7");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2017");
    driver.FindElement(By.CssSelector("div:nth-child(2) > .form-control:nth-child(1)")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys(" ");
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("First name is required"));
  }
  [Test]
  public void assignment3NoInputLastNameDetectNoInput() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("Audi");
    driver.FindElement(By.CssSelector("div:nth-child(4) > .form-control:nth-child(2)")).Click();
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q8");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2012");
    driver.FindElement(By.CssSelector("div:nth-child(2) > .form-control:nth-child(2)")).Click();
    driver.FindElement(By.Id("txtLastName")).SendKeys(" ");
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Last name is required"));
  }
  [Test]
  public void assignment3NoInputMakeDetectNoInput() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.CssSelector("div:nth-child(2) > .form-control:nth-child(1)")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("dd");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("1990");
    driver.FindElement(By.CssSelector("button")).Click();
    {
      var element = driver.FindElement(By.CssSelector("button"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Make is required"));
  }
  [Test]
  public void assignment3NoInputAddressDetectNoInput() {
    driver.Navigate().GoToUrl("http://localhost/AS3_Test/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("Add new vechicle")).Click();
    driver.FindElement(By.Id("txtFirstName")).Click();
    driver.FindElement(By.Id("txtFirstName")).SendKeys("Byounguk");
    driver.FindElement(By.Id("txtLastName")).SendKeys("Min");
    driver.FindElement(By.Id("txtAddress")).SendKeys("50 Wellesley St East");
    driver.FindElement(By.Id("txtCity")).SendKeys("Toronto");
    driver.FindElement(By.Id("txtPostalCode")).SendKeys("M4Y 0C8");
    driver.FindElement(By.Id("txtPhone")).SendKeys("6478910841");
    driver.FindElement(By.Id("txtEmail")).SendKeys("brandenmin@gmail.com");
    driver.FindElement(By.CssSelector("div:nth-child(2) > .form-control:nth-child(3)")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).Click();
    driver.FindElement(By.Id("txtPhone")).SendKeys("647-891-0841");
    driver.FindElement(By.Id("txtMake")).Click();
    driver.FindElement(By.Id("txtMake")).SendKeys("BMW");
    driver.FindElement(By.Id("txtModel")).Click();
    driver.FindElement(By.Id("txtModel")).SendKeys("Q8");
    driver.FindElement(By.Id("txtYear")).Click();
    driver.FindElement(By.Id("txtYear")).SendKeys("2000");
    driver.FindElement(By.CssSelector("button")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".error")).Text, Is.EqualTo("Address is required"));
  }
}