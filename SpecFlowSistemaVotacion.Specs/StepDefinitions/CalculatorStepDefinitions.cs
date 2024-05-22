using SistemaDeVotacion.dao;
using SistemaDeVotacion.model;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace SpecFlowSistemaVotacion.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CandidatoDao _candidatoDao = new CandidatoDao();
        private int _result;
        private List<Candidato> _candidatos;
        private Candidato _candidato;
        private bool _resultadoAgregar;
        private List<Candidato> _candidatosConVotos;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("the method was used")]
        public void WhenTheMethodWasUsed()
        {
            _result = _candidatoDao.ObtenerMaximoID();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When("the method2 was used")]
        public void WhenTheMethod2WasUsed()
        {
            _result = _candidatoDao.ObtenerMinimoID();
        }

        [Given(@"un departamento con id ""(.*)""")]
        public void GivenUnDepartamentoConId(string departamento)
        {
            _scenarioContext["Departamento"] = departamento;
        }

        [When(@"busco candidatos por departamento")]
        public void WhenBuscoCandidatosPorDepartamento()
        {
            string departamento = _scenarioContext["Departamento"].ToString();
            _candidatos = _candidatoDao.buscarCandidatosPorDepartamento(departamento);
        }

        [Then(@"deberia encontrar candidatos")]
        public void ThenDeberiaEncontrarCandidatos()
        {
            _candidatos.Should().NotBeEmpty();
        }

        [Given(@"un nuevo candidato con nombre ""(.*)"" y apellido ""(.*)""")]
        public void GivenUnNuevoCandidatoConNombreYApellido(string nombre, string apellido)
        {
            _candidato = new Candidato
            {
                Nombre = nombre,
                Apellido = apellido,
                Edad = 40, // Ajusta según tu modelo
                IdDepartamento = 1251, // Ajusta según tu modelo
                Partido = new Partido { Id = 9 } // Ajusta según tu modelo
            };
        }

        [When(@"agrego el candidato")]
        public void WhenAgregoElCandidato()
        {
            _resultadoAgregar = _candidatoDao.agregarCandidato(_candidato);
        }

        [Then(@"el candidato debería ser agregado exitosamente")]
        public void ThenElCandidatoDeberiaSerAgregadoExitosamente()
        {
            _resultadoAgregar.Should().BeTrue();
        }

     
    }
}
