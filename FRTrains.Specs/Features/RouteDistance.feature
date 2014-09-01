@RouteDistance
Feature: Route Distance
    As a            customer
	I want to       enter the route in the format "A-B-C"
	In order to     see the route distance

Scenario Outline: Show distance
    Given   I have a valid set of routes
    When    I enter <route>
    Then    The distance should be <distance>
    Examples: 
        |    route    |    distance   |
        |   "A-B-C"   |       9       |
        |    "A-D"    |       5       |
        |   "A-D-C"   |      13       |
        | "A-E-B-C-D" |      22       |
        |   "A-E-D"   | NO SUCH ROUTE |