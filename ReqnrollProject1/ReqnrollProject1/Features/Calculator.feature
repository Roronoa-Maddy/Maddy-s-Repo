Feature: DemoQa

Simple calculator for adding two numbers



	Scenario: Verify User able to Navigate To DemoQA Site
	Given User Able to Navigate DemoQA 

	Scenario: Veriyf User Able to Navigate To WebTables in the DemoQA
	Given User Able to Navigate DemoQA 
	When User Clicks on Element Option
	Then User Clicks on WebTable from Left Side Options
	And Read the Web tables data from UI

	Scenario:Verify User Able to Add Details In Registration Form
	Given User Able to Navigate DemoQA 
    When User Clicks on Element Option
	Then User Clicks on WebTable from Left Side Options
	And Add Details in Registration form
	Then User Submits the Registration form

	Scenario:Verify User able to Select Date From calendar
	Given User Able to Navigate DemoQA 
	When User Clicks on Widgets Option
	Then User Clicks on DatePicker from Left side options
	And User Select the Repective date "30-06-2025"
	Then Verify Repective date "30-06-2025"
	

	##scenario