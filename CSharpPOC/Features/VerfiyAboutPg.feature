Feature: VerfiyAboutPg
	Simple calculator for adding two numbers

Background: 
   Given I navigate to the environment FPS application
	And And I enter username and password
		| Username  | Password |
		| mpantoja | Kiara### |
	When I click Login
	Then I am logged in to FPS
@mytag
Scenario: Add two numbers
	Given I am on the Dashboard
	And I click the Institution Name Drop Dow
	When I click the About link
	Then I am navigated to the About page
	And I veify the Application Name
	And I verify a copyright Date exists
	And I verify a build number exists
	And I verify a Tradmark Notice link exists
	And I verify a Terms and Conditions link exists
	And I verify a Privacy Policy link exists