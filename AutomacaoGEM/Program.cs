using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    public static void Main(string[] args)
    {

        var opcoes = new ChromeOptions();
        opcoes.AddArguments("--start-maximized");
        opcoes.AddExcludedArgument("enable-automation");

        var driver = new ChromeDriver(opcoes);

        driver.Navigate().GoToUrl("https://musical.congregacao.org.br/");

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        var login = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[1]/input")));

        login.SendKeys("andreortune@gmail.com");

        var senha = wait.Until(drv => drv.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/input")));

        senha.SendKeys("Cris0104" + OpenQA.Selenium.Keys.Enter);

        driver.FindElement(By.XPath("html/body/div/aside/div/section/ul/li[3]")).Click();


        driver.FindElement(By.XPath("html/body/div/aside/div/section/ul/li[3]/ul/li[1]/a")).Click();

        var Aluno = wait.Until(drv => drv.FindElement(By.XPath("html/body/div/div[1]/div[1]/section[2]/div/div/div[2]/div[1]/div[2]/div/label/input")));

        Aluno.SendKeys("Daniel Correa Oselin");

        TimeSpan.FromSeconds(5);

        driver.FindElement(By.XPath("html/body/div/div[1]/div[1]/section[2]/div/div/div[2]/div[2]/div/table/tbody/tr/td[1]/input")).Click();


        driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/section[2]/div/div/div[1]/button[3]")).Click();
        ///html/body/div/div[1]/div[1]/section[2]/div/div/div[1]/button[3]


    }
}