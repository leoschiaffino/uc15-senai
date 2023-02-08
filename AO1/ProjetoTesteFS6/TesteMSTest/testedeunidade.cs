using ProjetoTesteFS6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMSTest
{
    [TestClass]
    public class testedeunidade
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange - Preparacao
            double pNum = 5;
            double sNum = 4;
            double rNum = 9;

            // Act - Ação
            var resultado = operacoes.Somar(pNum, sNum);

            // Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }


        [TestMethod]
        public void DividirDoisNumeros()
        {
            // Arrange - Preparacao
            double pNum = 6;
            double sNum = 2;
            double rNum = 3;

            // Act - Ação
            var resultado = operacoes.Dividir(pNum, sNum);

            // Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        // preparacao
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 2, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(5, 5, 10)]
        [DataRow(7, 7, 14)]
        public void SomarDoisNumerosLists(double pNum, double sNum, double rNum)
        {
            //acao
            var resultado = operacoes.Somar(pNum, sNum);

            //verificacao
            Assert.AreEqual(rNum, resultado);
        }
    }
}
