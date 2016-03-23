@Authentication
Feature: Authentication
	In order to verify whether the input is valid
	As a caller
	I want to get the database and verify if the inputs are mathced with the sources.

@mytag
Scenario: Authentication successful
	Given user account number is "1234"
	And password is "Irene"
	When I call Verify method
	Then the result should be "true"

Scenario: Authentication unsuccessful
	Given user account number is "1234"
	And password is "Yiqun"
	When I call Verify method
	Then the result should be "false"