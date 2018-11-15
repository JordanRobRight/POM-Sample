Feature: EnterPointsScenarios
	these are the enter point scenarios to the website

@Debug
Scenario: Validate the title of the website
	Given I navigate to the homepage
	Then I see the page title contains "Wiki"

@Debug
Scenario: Validate the URL of the website
	Given I navigate to the homepage
	Then I see the page url contains "Wiki"

	@Debug
Scenario: Validate the pageSource string on the website
	Given I navigate to the homepage
	Then I see "The Free Encyclopdia" in the PageSource

