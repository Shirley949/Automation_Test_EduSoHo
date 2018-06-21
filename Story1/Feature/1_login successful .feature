Feature: Login 
	In order to verify the login system is working well
	As a tester
	I want to check the login model by inputing different conditions

@Tag
Scenario: login successfully
	Given I Open the Login page
	When I have entered Username
	Then I have entered the Password
	Then login is successful, avatar is seen
	#Then log off and close the browser
