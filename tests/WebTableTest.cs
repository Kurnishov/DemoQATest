using DemoQATest.workflow;
using Xunit;

namespace DemoQATest.Tests
{
    public class WebTablesTest : BaseTest
    {
        [Fact]
        public void TestAddEditDeleteWebTableRow()
        {
            var workflow = new WebTableWorkflow(Driver);
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            // string name = "John";
            // string updatedSalary = "123456";

            // Add new row
            workflow.AddNewRecord("Oleksandr", "Kurnishov", "a.kurnishov@gmail.com", "37", "100000", "Engineering");

            // Verify added
            //WaitHelpers.WaitForTableRowData(Driver, name);
            //Assert.Contains(name, Driver.PageSource);

            // Edit row
            //workflow.EditSalaryByName(name, updatedSalary);
            //WaitHelpers.WaitForTableRowData(Driver, updatedSalary);
            //Assert.Contains(updatedSalary, Driver.PageSource);

            // Delete row
            //workflow.DeleteRowByName(name);
            //WaitHelpers.WaitForTableRowDeletion(Driver, name);
            //Assert.DoesNotContain(name, Driver.PageSource);
        }
    }
}