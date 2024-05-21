using SistemaDeVotacion.dao;

namespace SpecFlowSistemaVotacion.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CandidatoDao _candidatoDao = new CandidatoDao();
        private int _result;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef


        [When("the method was used")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _candidatoDao.ObtenerMaximoID();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When("the method2 was used")]
        public void WhenTheTwoNumbersAreAddedUser()
        {
            _result = _candidatoDao.ObtenerMinimoID();
        }

        
    }
}
