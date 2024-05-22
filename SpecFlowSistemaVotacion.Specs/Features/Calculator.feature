Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowSistemaVotacion.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: run method
	When the method was used
	Then the result should be 200


Scenario: run method2
	When the method2 was used
	Then the result should be 200

Scenario: Buscar candidatos por departamento
    Given un departamento con id "1"
    When busco candidatos por departamento
    Then deberia encontrar candidatos

Scenario: Agregar un nuevo candidato
    Given un nuevo candidato con nombre "John" y apellido "Doe"
    When agrego el candidato
    Then el candidato debería ser agregado exitosamente