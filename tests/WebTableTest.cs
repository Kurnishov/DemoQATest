using DemoQATest.workflow;
using Xunit;
using static DemoQATest.helpers.Waiter;

namespace DemoQATest.Tests
{
    public class WebTablesTest : BaseTest
    {
        [Fact]
        public void TestAddEditDeleteWebTableRow()
        {
            var workflow = new WebTableWorkflow(Driver);
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            
            const string firstName = "Oleksandr";
            const string lastName = "Kurnishov";
            const string email = "a.kurnishov@gmail.com";
            const string age = "37";
            const string salary = "100000";
            const string updatedSalary = "123456";
            const string department = "Engineering";
            
            // Add new record
            workflow.AddNewRecord(firstName, lastName, email, age, salary, department);

            // Verify added
            Assert.Contains(firstName, WaitForTableRowData(firstName));

            // Edit row
            workflow.EditSalaryByName(firstName, updatedSalary);
            Assert.Contains(updatedSalary, WaitForTableRowData(updatedSalary));
            
            // Delete row
            workflow.DeleteRowByName(firstName);
            Assert.False(WaitForTableRowDeletion(firstName));
        }
    }
}