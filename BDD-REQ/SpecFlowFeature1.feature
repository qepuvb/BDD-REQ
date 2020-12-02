Feature: Arithmetic Functions
	For a calculator software

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract a number from another number
	Given the first number is 25
	And the second number is 20
	When the second number is substracted from the first
	Then the result should be 5

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the numbers are multiplied
	Then the result should be 3500

Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 25
	When the two numbers are divided
	Then the result should be 2