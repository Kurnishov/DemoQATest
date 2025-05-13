using DemoQATest.pom;
using OpenQA.Selenium;

namespace DemoQATest.workflow;

public class WebTableWorkflow(IWebDriver driver)
{
    private readonly WebTablesPage _webTablesPage = new(driver);
    
    public void AddNewRecord(string firstName, string lastName, string email, string age, string salary, string department)
    {
        _webTablesPage.ClickAddRowButton();
        _webTablesPage.SetFirstName(firstName);
        _webTablesPage.SetLastName(lastName);
        _webTablesPage.SetEmail(email);
        _webTablesPage.SetAge(age);
        _webTablesPage.SetSalary(salary);
        _webTablesPage.SetDepartment(department);
        _webTablesPage.Submit();
    }

    public void EditSalaryByName(string name, string salary)
    {
        _webTablesPage.ClickEditButton(name);
        _webTablesPage.SetSalary(salary);
        _webTablesPage.Submit();
    }

    public void DeleteRowByName(string name)
    {
        if (_webTablesPage.GetRowByName(name) != null)
        {
            _webTablesPage.ClickDeleteButton(name);
        }
    }
}