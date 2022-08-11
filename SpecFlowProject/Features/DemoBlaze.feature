Feature: DemoBlaze
This feature tests the demoblaze website

Scenario: Header name should match the selected item for laptops
	Given I Navigate to "Laptops" Section
	When I click on the "Sony vaio i5" item
	Then header name of the item should be equal to the item selected

	Examples: 
	| laptopname       | itemname             |
	| Sony vaio i5     |  Sony vaio i5        |

