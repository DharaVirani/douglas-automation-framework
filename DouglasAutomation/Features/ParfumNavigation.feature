Feature: Filter parfum products

  Scenario Outline: Apply filters to parfum page
    Given I am on the Douglas homepage
        And I accept the cookie policy
    When I click on the "Parfum" tab
         And I apply the filter "<FilterType>" with value "<FilterValue>"
    Then I should see filtered results

    Examples:
      | FilterType   | FilterValue    |
      | Fur Wen      | Männlich       |
      | Fur Wen      | Weiblich       |
      | Marke        | Dior           |

