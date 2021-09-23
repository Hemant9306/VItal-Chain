Feature: GameTest

Scenario: Game Home Page Validations
	Given Launch game url
	When Get Game Home Page
	Then Check HomePage UI Validation

	Scenario: Verify All game loaded according to Menu items
	Given Launch game url
	When Get Game Home Page
	Then Check Games loaded as per menu items

	Scenario: Validate UI for Registration Page
	Given Launch game url
	When Get Game Home Page
	Then Check Registration Page Validation

	Scenario: Validate Details For Registration age
	Given Launch game url
	When Get Game Home Page
	Then Validate details for registration page

	Scenario: InValid Email On Regitration Form
	Given Launch game url
	When Get Game Home Page
	Then Check Invalid data for email

	Scenario: Enter registration
	Given Launch game url
	When Get Game Home Page
	Then Enter registration details

	Scenario: Login Button UI Test
	Given Launch game url
	When Get Game Home Page
	Then Check Login button UI Validation

	Scenario: Login Data Validations
	Given Launch game url
	When Get Game Home Page
	Then Enter Login data 
