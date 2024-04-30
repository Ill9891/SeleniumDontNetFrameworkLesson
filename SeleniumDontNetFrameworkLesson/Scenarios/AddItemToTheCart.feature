Feature: AddItemToTheCart

Simple test for adding an item to the cart

@id(23331)
Scenario: Add Item To The Cart
	Given logged in to the site with 'standard_user' and 'secret_sauce'
	And we have a table
		| FirstValue  | SecondValue | ThirdValue | FourthValue |
		| "Test1"     | "Test2"     | "Test3"    | 1           |
		| "Test112"   | "Test23"    | "Test1"    | 1           |
		| "Test1323"  | "Test2345"  | "Test1"    | 1           |
		| "Test11231" | "Test235"   | "Test1"    | 1           |
		| "Test1123"  | "Test2345"  | "Test1"    | 1           |
		| "Test15567" | "Test2567"  | "Test1"    | 1           |

	When '1' item added to the cart
	Then the '1' item in the cart


