Feature: SetupCECLCreditRatingCodes
	In order to use CECL, I need to set up processing parameters

Background: 
   Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username  | Password |
		| mpantoja | Kiara$$$ |
	When I click Login
	Then I am logged in to FPS

@CECLCreditRatingCodes
Scenario: Verify CECL Credit Rating Codes page
	Given I have have at least one completed ETL and have navigated to Setup CECL
	And I select the Setup CECL breadcrumb
	And I choose Credit Rating Codes
	And I am on the Credit Rating Page
	When 2 is entered for Risk Rating Low
	And 25 is entered for Risk Rating High
	And I click Save
	Then the the ratings are Saved

@CECLCreditRatingCodes
Scenario: Verify Cancel Does Not Save Rating Codes
	Given I am on the Credit Rating Page
	When 5 is entered for Risk Rating Low
	And 15 is entered for Risk Rating High
	And I click Cancel
	Then the the ratings are not Saved

@CECLCreditRatingCodes
Scenario: Verify Inline Validations on CECL Credit Rating Codes page
	Given I am on the Credit Rating Page
	When 0 is entered for Risk Rating Low
	And 101 is entered for Risk Rating High
	Then a Validation appears below Risk Rating Low input box that says "The value should be between 1 and 100."
	And a Validation appears below Risk Rating High input box that says "The value should be between 1 and 100."
	
@CECLCreditRatingCodes
Scenario: Verify Save and Cancel Appear when Navigate Away from CECL Credit Rating Codes page with Changes
	Given I am on the Credit Rating Page
	When 3 is entered for Risk Rating Low
	And 16 is entered for Risk Rating High
	Then I click away
	And I click the FPS Image
	Then a Save Change Dialog appears
	When I click Save in the dialog 
	Then the the ratings are Saved
	And I am on the Credit Rating Page
	When 1 is entered for Risk Rating Low
	And 20 is entered for Risk Rating High
	Then I click away
	And I click the FPS Image 
	Then a Save Change Dialog appears
	When I click Cancel in the dialog 
	Then the the ratings are Not Saved
	Then am navigated to the Dashboard

	

	