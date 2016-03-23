@WebBankSP
Feature: Login
	In order to avoid annoymous users to use the system
	As an administrator
	I want to verify the account No. and Password of the users

@mytag
Scenario: Login Successful with Account No "1234" and Password "Irene"
	Given the LoginSP.aspx page
	And Input Account No. "1234"
	And Input Password "Irene"
	When I press ConfirmLogin button
	Then the page url will redirect to "IndexSP.aspx"


@mytag
Scenario: Login Unsuccessful with Account No "1234" and Password "Yiqun"
	Given the LoginSP.aspx page
	And Input Account No. "1234"
	And Input Password "Yiqun"
	When I press ConfirmLogin button
	Then the Login page will give a message "Account No. and Password not matched."