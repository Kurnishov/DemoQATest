using OpenQA.Selenium;

namespace DemoQATest.pom;
public class WebTablesPage(IWebDriver driver)
{
    private IWebElement AddButton => driver.FindElement(By.Id("addNewRecordButton"));
    private IWebElement FirstNameInput => driver.FindElement(By.Id("firstName"));
    private IWebElement LastNameInput => driver.FindElement(By.Id("lastName"));
    private IWebElement EmailInput => driver.FindElement(By.Id("userEmail"));
    private IWebElement AgeInput => driver.FindElement(By.Id("age"));
    private IWebElement SalaryInput => driver.FindElement(By.Id("salary"));
    private IWebElement DepartmentInput => driver.FindElement(By.Id("department"));
    private IWebElement SubmitButton => driver.FindElement(By.Id("submit"));
    private IWebElement GetRowByName(string name) =>
        driver.FindElement(By.CssSelector("[title='Edit']"));

    public void ClickAddRowButton()
    {
        AddButton.Click();
    }
    
    public void SetFirstName(string firstName)
    {
        FirstNameInput.Clear();
        FirstNameInput.SendKeys(firstName);
    }
    
    public void SetLastName(string lastName)
    {
        LastNameInput.Clear();
        LastNameInput.SendKeys(lastName);
    }
    
    public void SetEmail(string email)
    {
        EmailInput.Clear();
        EmailInput.SendKeys(email);
    }
    
    public void SetAge(string age)
    {
        AgeInput.Clear();
        AgeInput.SendKeys(age);
    }
    
    public void SetSalary(string salary)
    {
        SalaryInput.Clear();
        SalaryInput.SendKeys(salary);
    }
    
    public void SetDepartment(string department)
    {
        DepartmentInput.Clear();
        DepartmentInput.SendKeys(department);
    }
    
    public void Submit()
    {
        SubmitButton.Click();
    }
    
    public void ClickEditButton(string name) =>
        GetRowByName(name).Click();
}