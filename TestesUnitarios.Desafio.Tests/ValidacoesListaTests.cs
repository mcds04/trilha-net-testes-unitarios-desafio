using System.Collections.Generic;
using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public bool ListaContemDeterminadoNumero(List<int> lista, int numeroParaProcurar)
        {
            // Implementação do método ListaContemDeterminadoNumero
            return lista.Contains(numeroParaProcurar);
        }

        public List<int> MultiplicarElementosDaListaPor2(List<int> lista)
        {
            var resultado = new List<int>();
            foreach (var numero in lista)
            {
                resultado.Add(numero * 2);
            }
            return resultado;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            // Implementação do método RetornarMaiorNumeroLista
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            // Implementação do método RetornarMenorNumeroLista
            return lista.Min();
        }
    }
}

namespace TestesUnitarios.DesafioTests
{
    public class ValidacoesListaTests
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        private readonly ValidacoesLista _validacoes = new ValidacoesLista();
#pragma warning restore CS0436 // Type conflicts with imported type

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            var resultado = _validacoes.MultiplicarElementosDaListaPor2(lista);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);
            Assert.Equal(-8, resultado);
        }
    }
}

