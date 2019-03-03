Feature: Login
	As a registered user of the Herokuapp
	I would like to Login
	So that i can use the site


@mytag
Scenario: Valid Login
	Given I navigate to the site
	When I enter Username
	And I enter password
	And I click login button
	Then i am logged in to the site
	And I click log out

Scenario: InValid Login
	Given I navigate to the site
	When I enter username"Ola"
	And I enter password
	And I click login button
	Then Your username is invalid is Displayed
	And I click log out





