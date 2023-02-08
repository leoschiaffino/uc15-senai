using ProjetoTesteFS6;

namespace TestXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange - Preparacao
            double pNum = 5;
            double sNum = 4;
            double rNum = 9;

            // Act - Ação
            var resultado = operacoes.Somar(pNum, sNum);

            // Assert - Verificação
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 4, 8)]
        public void SomarDoisNumerosLists(double pNum, double sNum, double rNum)
        {
            //acao
            var resultado = operacoes.Somar(pNum, sNum);

            //verificacao
            Assert.Equal(rNum, resultado);
        }
    }
}