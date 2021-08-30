Feature: NavigateSimplified
	Navigate to Main pages in app

Background: 
   Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username  | Password |
		| mpantoja | Kiara$$$ |
	When I click Login
	Then I am logged in to FPS

Scenario: I can navigate to main menu pages 
	Given I am on the Dashboard
	And I can navigate to AppPage and am on_Page
	| AppPage            | on_Page            |
	| Profitablity       | PROFITABILITY      |
	| Dashboard          | Dashboard          |
	| Pricing            | Pricing            |
	| Dashboard          | Dashboard          |
	| Forecasting Detail | Forecasting Detail |
	| Dashboard          | Dashboard          |
	| ALMEVE             | EVE                |
	| Dashboard          | Dashboard          |
	| CECL               | CECL Summary       |
	| Dashboard          | Dashboard          |
	| Scorecard          | Scorecard          |
	| Dashboard          | Dashboard          |
	| Reporting          | Create Reports     |
	| Dashboard          | Dashboard          |
	| Update             | Monthly Update Process    |
	| Dashboard          | Dashboard          |
	| Manage Users       | Manage Users       |
	| Dashboard          | Dashboard          |
	| Setup CECL         | Setup CECL         |
	| Dashboard          | Dashboard          |
	When I log out
	Then I will be logged out


