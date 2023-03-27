using February2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

//Open chrome browser

IWebDriver driver = new ChromeDriver(@"c:/February2023");

//login page object initialization and definition

LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

//Home page object initialization and definition

HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

//TM Page object initialization and definition

TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

//Edit TM

tmPageObj.EditTM(driver);

//delete 

tmPageObj.DeleteTM(driver);



