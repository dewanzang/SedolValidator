Feature: SedolValidationCheck
In order to ensure the functionality of Sedol check validator 
As a user of the website
I want to input different data to esure is working as expected

Scenario Outline: Input Null, empty string or string other than 7 characters long
	Given User is at the Sedol Web App Home Page
    When User enter InputString Test Value in Sedol input field <InputStringTestValue>
	And Select Is Valid Sedol <IsValidSedol>
	And Select Is User Define <IsUserDefined>
	Then the correct Validation Details is displayed <ValidationDetails>

	Examples: 
	| InputStringTestValue	 | IsValidSedol | IsUserDefined | ValidationDetails						    |
	| null				     | false		| false         | 'Input string was not 7-characters long.' | 
	| ""		  		     | false		| false         | 'Input string was not 7-characters long.' |
	| '12'				     | false		| false         | 'Input string was not 7-characters long.' |
	| '123456789'			 | false		| false         | 'Input string was not 7-characters long.' |

# NOTE: This test failed as the actual validation message is 
#'Checksum digit does not agree with the first 6 characters.'
Scenario Outline: Input Invalid non user define SEDOL
	Given User is at the Sedol Web App Home Page
    When User enter InputString Test Value in Sedol input field <InputStringTestValue>
	And Select Is Valid Sedol <IsValidSedol>
	And Select Is User Define <IsUserDefined>
	Then the correct Validation Details is displayed <ValidationDetails>

	Examples: 
	| InputStringTestValue	 | IsValidSedol | IsUserDefined | ValidationDetails						                     |
	| '1234567'			     | false		| false         | 'Checksum digit does not agree with the rest of the input' | 
	| 'ABCDEFG'			     | false		| false         | 'Checksum digit does not agree with the rest of the input' |
	
Scenario Outline: Input Valid non user define SEDOL
	Given User is at the Sedol Web App Home Page
    When User enter InputString Test Value in Sedol input field <InputStringTestValue>
	And Select Is Valid Sedol <IsValidSedol>
	And Select Is User Define <IsUserDefined>
	Then the correct Validation Details is displayed <ValidationDetails>

	Examples: 
	| InputStringTestValue	 | IsValidSedol | IsUserDefined | ValidationDetails	 |
	| '0709954'			     | true			| false         | 					 | 
	| 'B0YBKJ7'			     | true			| false         | null				 |

# NOTE: This test failed as the actual validation message is 
#'Checksum digit does not agree with the first 6 characters.'
Scenario Outline: Input Invalid user defined SEDOL
	Given User is at the Sedol Web App Home Page
    When User enter InputString Test Value in Sedol input field <InputStringTestValue>
	And Select Is Valid Sedol <IsValidSedol>
	And Select Is User Define <IsUserDefined>
	Then the correct Validation Details is displayed <ValidationDetails>

	Examples: 
	| InputStringTestValue   | IsValidSedol | IsUserDefined | ValidationDetails											 |
	| '9123451'			     | false		| true          | 'Checksum digit does not agree with the rest of the input' | 
	| '9ABCDE8'			     | false		| true          | 'Checksum digit does not agree with the rest of the input' |

Scenario Outline: Input Valid user defined SEDOL
	Given User is at the Sedol Web App Home Page 
    When User enter InputString Test Value in Sedol input field <InputStringTestValue>
	And Select Is Valid Sedol <IsValidSedol>
	And Select Is User Define <IsUserDefined>
	Then the correct Validation Details is displayed <ValidationDetails>

	Examples: 
	| InputStringTestValue	 | IsValidSedol | IsUserDefined | ValidationDetails	|
	| '9123458'			     | true			| true          | ''				| 
	| '9ABCDE1'			     | true			| true          | ''				|