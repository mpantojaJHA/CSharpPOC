Feature: LogInToFPS
	Check to see if can log in to FPS via specflow	

@mytag
Scenario: Log in as Admin to FPS
	Given I navigate to the environment FPS application
	And And I enter username and password
		| Username  | Password |
		| mpantoja | Kiara### |
	When I click Login
	Then I am logged in to FPS
	Then I will Log Out
	
