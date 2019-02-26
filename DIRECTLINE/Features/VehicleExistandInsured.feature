Feature: VehicleExistandInsured
	As a user of the site
	I should be able to check if a vehicle exists and insured

@mytag
Scenario: Vehicle exists and insured
	Given I navigate to the site
	When I enter the vehicle registration number
	And I click on find vehicle
	Then i should be able to see if vehicle exists and insured
