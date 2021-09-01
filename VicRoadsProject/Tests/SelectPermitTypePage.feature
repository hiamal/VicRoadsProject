Feature: Verify navigation to Select Permit Type page on VicRoads Website
    In Order to verify the unregistered vehicle permit navigation
    As a user
    I want to navigate to the Select Permit Type page

    Scenario: Verify navigation to Select Permit Type page
        Given I am on the VicRoads Homepage
        When I enter the following data into the Calculate Fee Page
        | vehicleType        |passengerVehicleType |address                                         | permitDuration|
        |Passenger vehicle   |Sedan                |Unit 7 11 Sample Street, Broadmeadows VIC 3047  |1 day          |
        And I click on the next button
        Then I am on the “Step 2 of 7 : Select permit type” page