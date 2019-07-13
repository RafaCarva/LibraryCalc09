using LibraryCalc09;
using System;
using Xunit;
 

namespace XUnitTestLibCalc19Tests
{
    public class CalculatorTest
    {

        [Fact]
        public void SomaSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 4;

            var result = calculator.OperationAdd(x, y);

            Assert.True((x + y) == result);
        }

        [Fact]
        public void SomaTresParametrosSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 4;
            var z = 10;

            var result = calculator.OperationAdd(x, y, z);

            Assert.True((x + y + z) == result);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 29)]
        [InlineData(0, 10)]
        public void SomaError(double x, double y)
        {
            var calculadora = new Calculator();
            var resulatdo = calculadora.OperationAdd(x, y);
            Assert.False((x + y) != resulatdo);
        }

        [Fact]
        public void SubtracaoSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 4;

            var result = calculator.OperationSubtract(x, y);

            Assert.True((x - y) == result);
        }

        [Fact]
        public void SubtracaoTresParametrosSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 2;
            var z = 1;

            var result = calculator.OperationSubtract(x, y,z);

            Assert.True((x - y - z) == result);
        }

        [Fact]
        public void MultiplicacaoSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 4;

            var result = calculator.OperationMultiply(x, y);

            Assert.True((x * y) == result);
        }
        [Fact]
        public void MultiplicacaoTresParametrosSucesso()
        {
            var calculator = new Calculator();
            var x = 5;
            var y = 4;
            var z = 2;

            var result = calculator.OperationMultiply(x, y, z);

            Assert.True((x * y * z) == result);
        }

        [Fact]
        public void DivisaoSucesso()
        {
            var calculator = new Calculator();
            var x = 10;
            var y = 5;

            var result = calculator.OperationDivide(x, y);

            Assert.True((x / y) == result);
        }

        [Theory]
        [InlineData(1, 2,1)]
        [InlineData(10, 29,6)]
        [InlineData(0, 10,6)]
        public void SubtracaoTresParametrosErro(double x, double y, double z)
        {
            var calculadora = new Calculator();
            var resulatdo = calculadora.OperationSubtract(x, y, z);
            Assert.False((x - y -z) != resulatdo);
        }

    }
}
