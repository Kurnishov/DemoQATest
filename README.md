DemoQA Web Tables Test Automation (C# + Selenium)

This project automates test cases for the [DemoQA Web Tables page](https://demoqa.com/webtables) using C#, Selenium WebDriver, and xUnit, and follows a Page Object Model (POM) structure.

Features

- Add, edit, and delete a row in the web table.
- Wait and validate changes using dynamic waits.
- Take screenshots after each test step.
- Organized using Page Object Model (POM) and workflows.
- Designed to run inside **JetBrains Rider** or **Visual Studio**.

---

Project Structure

DemoQATest/
│
├── config/                  # Driver context setup
│   └── DriverContext.cs
│
├── helpers/                 # Utilities for wait, click, screenshot
│   ├── Clicker.cs
│   ├── Waiter.cs
│   └── Screenshoter.cs
│
├── pom/                     # Page Object Model classes
│   └── WebTablesPage.cs
│
├── workflow/                # Workflow layer for test actions
│   └── WebTableWorkflow.cs
│
├── tests/
│   ├── BaseTest.cs          # Base test setup and teardown
│   └── WebTablesTest.cs     # Main test class with Add/Edit/Delete test
│
├── DemoQATest.csproj        # Project file
└── README.md                # This file


🛠️ Prerequisites
	•	.NET SDK 6.0+
	•	JetBrains Rider or Visual Studio 2022+
	•	Chrome browser installed
	•	NuGet packages:
	•	Selenium.WebDriver
	•	Selenium.WebDriver.ChromeDriver
	•	Selenium.Support
	•	xUnit

 🚀 How to Run
	1.	Clone the repository or unzip the project folder.
	2.	Open the project in Rider or Visual Studio.
	3.	Restore NuGet packages (Rider will prompt this or you can run dotnet restore).
	4.	Run the test from the Test Explorer or using the command: dotnet test
  	5.	Screenshots will be saved in the DemoQATest/bin/Debug/net9.0/Screenshots directory automatically after each step.
