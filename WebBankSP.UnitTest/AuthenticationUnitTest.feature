@Authentication
Feature: Authentication
	In order to verify whether the input is valid
	As a caller
	I want to get the database and verify if the inputs are mathced with the sources.

@mytag
Scenario: Authentication successful with account number "1234" and password "Irene"
	Given user account number is "1234"
	And password is "Irene"
	And IDoc will return "abc"
	And IHash will return "abc"
	When I call Verify method
	Then the result should be "true"

Scenario: Authentication unsuccessfulwith account number "1234" and password "Yiqun"
	Given user account number is "1234"
	And password is "Yiqun"
	And IDoc will return "abc"
	And IHash will return "bcd"
	When I call Verify method
	Then the result should be "false"