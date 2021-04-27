Feature: SmokeNavigation
	Simple calculator for adding two numbers
Background: 
   Given I navigate to the environment FPS application
	And And I enter username and password
		| Username  | Password |
		| mpantoja | Kiara### |
	When I click Login
	Then I am logged in to FPS
	

Scenario: I can navigate to main menu pages 
	Given I am on the Dashboard
	And I click Profitability
	Then I am navigated to the Profitability page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	And I click Pricing
	When I click submenu Pricing
	Then I am navigated to the Pricing Loans Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	And I click Forecasting
	When I click submenu Forecasting Detail
	Then I am navigated to the Forecasting Detail Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	And I click ALM
	When I click submenu EVE
	Then I am navigated to the EVE Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	And I click CECL
	Then I am navigated to the CECL Summary Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	And I click Scorecard
	Then I am navigated to the Scorecard Page
	And I click the FPS Image 
	Then I click Reporting
	When I click submenu Create Reports
	Then I am navigated to the Create Reports Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	Then I click Update
	When I click submenu Monthly Update Process
	Then I am navigated to the Monthly Update Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	Then I click Setup
	When I click submenu Manage Users
	Then I am navigated to the Manage Users Page
	And I click the FPS Image 
	Then am navigated to the Dashboard
	