@Doc
Feature: Doc
	In order to verify the input password
	As a Authentication object
	I want to get the relevant password information of account id from doc

@mytag
Scenario: get the password of id "1234" from doc
	Given account id "1234"
	When call GetPassword method
	Then the result back from doc should be "S2EQGhNLvF9Qh2QZMmB9wo2Ezuif8rmYCTaGUEKqdMz+w5SHZXSreKazP0QuUG67cBMFbnDmtwOoKVvk7IWzVQ=="
