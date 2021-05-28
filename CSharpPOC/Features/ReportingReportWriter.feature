Feature: ReportingReportWriter
	Launch Report Writer and any cases that would involve generating RW in a report packet etc

Background: 
	Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username  | Password |
		| mpantoja | Kiara### |
	When I click Login
	Then I am logged in to FPS

@mytag
Scenario: Open Report Writer from the FPS Application
	Given I am on the Dashboard
	Then I click Reporting
	When I click submenu Create Reports
	Then I am navigated to the Create Reports Page
	And I enter Install & Open Report writer in the Report Search Box
	Then Report Writer is successfully launched