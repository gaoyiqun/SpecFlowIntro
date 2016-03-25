@MyHash
Feature: MyHash
	In order to avoid password been exposure to others
	As an Authentication Object
	I want to hash the input password

@mytag
Scenario: input password "Irene", the hash result should be "S2EQGhNLvF9Qh2QZMmB9wo2Ezuif8rmYCTaGUEKqdMz+w5SHZXSreKazP0QuUG67cBMFbnDmtwOoKVvk7IWzVQ=="
	Given "Irene" as a input password
	When call the GetHash method
	Then the hashed result should be "S2EQGhNLvF9Qh2QZMmB9wo2Ezuif8rmYCTaGUEKqdMz+w5SHZXSreKazP0QuUG67cBMFbnDmtwOoKVvk7IWzVQ=="

@mytag
Scenario: input password "Yiqun", the hash result should be "ZQwWPgZCp528nogmOxnsSsVZPtmPl6WCmOk6WG2WD3cfapxHSAml1MFdrD6CRVgs7gNDmHkAjUQmWgT0Dmr0ng=="
	Given "Yiqun" as a input password
	When call the GetHash method
	Then the hashed result should be "ZQwWPgZCp528nogmOxnsSsVZPtmPl6WCmOk6WG2WD3cfapxHSAml1MFdrD6CRVgs7gNDmHkAjUQmWgT0Dmr0ng=="