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

    public void ClickAddRowButton()
    {
        AddButton.Click();
    }
    
    public void SetFirstName(string firstName)
    {
        FirstNameInput.SendKeys(firstName);
    }
    
    public void SetLastName(string lastName)
    {
        LastNameInput.SendKeys(lastName);
    }
    
    public void SetEmail(string email)
    {
        EmailInput.SendKeys(email);
    }
    
    public void SetAge(string age)
    {
        AgeInput.SendKeys(age);
    }
    
    public void SetSalary(string salary)
    {
        SalaryInput.SendKeys(salary);
    }
    
    public void SetDepartment(string department)
    {
        DepartmentInput.SendKeys(department);
    }
    
    public void Submit()
    {
        SubmitButton.Click();
    }
}