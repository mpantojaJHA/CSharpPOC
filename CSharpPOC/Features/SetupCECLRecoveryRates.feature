Feature: SetupCECLRecoveryRates
	In order to use CECL, I need to set up Recovery Rates processing parameters

Background: 
   Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username  | Password |
		| mpantoja | Kiara$$$ |
	When I click Login
	Then I am logged in to FPS

 @CECLRecoveryRates
	Scenario: Verify CECL Recovery Rates page