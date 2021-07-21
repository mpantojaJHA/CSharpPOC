Feature: SetupCECL
	In order to use CECL, I need to set up processing parameters

Background: 
   Given I navigate to the environment FPS application
	And And I enter Username and Password
		| Username  | Password |
		| mpantoja | Kiara### |
	When I click Login
	Then I am logged in to FPS

@CECLCreditRatingCodes
Scenario: Verify CECL Credit Rating Codes page
	Given I have have at least one completed ETL and have navigated to Setup CECL
	And I select the Setup CECL breadcrumb
	And I choose Credit Rating Codes
	And I am on the Credit Rating Page
	When 1 is entered for Risk Rating Low
	And 20 is entered for Risk Rating High
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

	
@CECLModelSelection
 Scenario: Verify the Setup CECL Model Selection Page Calendar Control
	 Given I have have at least one completed ETL and have navigated to Setup CECL
	 And I select the Setup CECL breadcrumb
	 And I choose Model Selection
	 And I am on the Model Selection Page
	 When I click the Calendar Control icon
	 Then the Calendar drops down
	 And the Current year of recent ETLs shows for Year
	 And Only Months with Completed ETLs can be selected
	 And I cannot select a month beyond or prior to the ETLd months
	 When I click outside of the dropped down calendar
	 Then the Calendar collapses up

@CECLModelSelection
 Scenario: Verify the Setup CECL Model Selection Page Grid Behavior
	 Given I have have at least one completed ETL and have navigated to Setup CECL
	 And I select the Setup CECL breadcrumb
	 And I choose Model Selection
	 And I am on the Model Selection Page
	 When I select the first drop down on the Category-Primary Model Grid
	 And the combo box drops down and I can select Roll Rate
	 Then in the second grid  Include in Report and Include in Grid become checked and disabled
	 When I change the Primary Model for the first item in the first grid back to Advanced PD
	 Then Roll Rate Include in Report check box stays checked and enabled
	 When a Primary Model is not selected in the first grid
	 Then the Include in Report check box is enabled and checked 
	 When  Roll Rate Include in Report check box is unchecked
	 Then Roll Rate Include in Grid check box becomes enabled
	 When Roll Rate Include i Grid check box is checked
	 And Roll Rate Include in Grid is unchecked
	 And Roll Rate Include in Report gets checked
	 Then Roll Rate Include in Grid becomes checked and disabled

@CECLModelSelection
 Scenario: Verify the Setup CECL Model Selection Page Save/Cancel Behavior
	 Given I have have at least one completed ETL and have navigated to Setup CECL
	 And I select the Setup CECL breadcrumb
	 And I choose Model Selection
	 And I am on the Model Selection Page
	 And the Save and Cancel buttons are present and disabled
	 When I uncheck Roll Rate
	 Then Save and cancel become enabled
	 When I click Cancel
	 Then Roll Rate state returns to checked in the second grid
	 When I change first Categroy in First grid to Primary Model of Roll Rate
	 Then Save and cancel become enabled
	 When I click Save
	 Then the Primary Model change perists
	 When I Change the Primary Model for the first Category back to Advanced PD
	 Then the Save and Cancel buttons become enabled
	 And I click the FPS Image 
	 Then a Save Change Dialog appears
	 When I click the Save button
	  Then all changes are saved no navigation occurs
	 When I Change the Primary Model for the first Category back to Advanced PD
	 Then the Save and Cancel buttons become enabled
	 And I click the FPS Image 
	 Then a Save Change Dialog appears
	 When I click Cancel in the dialog 
	 Then the the ratings are Not Saved
	 Then am navigated to the Dashboard

	 @CECLRecoveryRates
	Scenario: Verify CECL Recover Rates page
	