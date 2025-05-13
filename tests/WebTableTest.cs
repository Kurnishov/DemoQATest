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
            const string site = "https://demoqa.com/webtables";
            const string firstName = "Oleksandr";
            const string lastName = "Kurnishov";
            const string email = "a.kurnishov@gmail.com";
            const string age = "37";
            const string salary = "100000";
            const string updatedSalary = "123456";
            const string department = "Engineering";
            
            var workflow = new WebTableWorkflow(Driver);
            
            // Navigate to site
            NavigateToUrl(site);
            
            // Add new record
            workflow.AddNewRecord(firstName, lastName, email, age, salary, department);

            // Verify record added
            Assert.Contains(firstName, WaitForTableRowData(firstName));

            // Edit record
            workflow.EditSalaryByName(firstName, updatedSalary);
            Assert.Contains(updatedSalary, WaitForTableRowData(updatedSalary));
            
            // Delete record
            workflow.DeleteRowByName(firstName);
            Assert.False(WaitForTableRowDeletion(firstName));
        }
    }
}