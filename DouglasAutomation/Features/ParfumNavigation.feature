Feature: Filter Parfum Products on Douglas

  Scenario Outline: Filter parfum products based on criteria
    Given I navigate to the Douglas homepage
    And I accept the cookie consent
    When I click on the "PARFUM" category
    And I apply filters: "<Highlights>", "<Marke>", "<Produktart>", "<Geschenk fur>", "<Fur Wen>"
    Then I should see the filtered list of products

    Examples:
      | Highlights | Marke  | Produktart     | Geschenk fur | Fur Wen |
      | Sale       | Dior   | Eau de Parfum  | Geburtstag   | Damen   |

