Feature: PowerBIREfreshTet
	

Background: 
   Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username | Password |
		| mpantoja  | Kiara### |
		
	When I click Login
	Then I am logged in to FPS

@mytag
Scenario: Refresh the Ad Hoc Reporting Page
	Given I click Reporting
	And I Click the Ad Hoc Reporting menu item
	When I click on the Refresh Button
	Then The page will begin a Refresh
	