using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestExample.Test
{

    public class TypeSafeData : TheoryData<int, int, int>
    {
        public TypeSafeData()
        {
            Add(3, 5, 8);
            Add(11, 5, 16);
            Add(23, 2, 25);
            Add(33, 44, 87);
        }
    }

    public class MathematicsTest2
    {
        Mathematics _mathematics;
        public MathematicsTest2()
        {
            _mathematics = new();
        }
        [Theory]
        [ClassData(typeof(TypeSafeData))]
        public void SumTest(int number1, int number2, int expected)
        {
            #region Act
            int result = _mathematics.Sum(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }
        [Fact]
        public void SubtractTest()
        {
            #region Arrange
            int number1 = 10;
            int number2 = 20;
            int expected = -10;
            #endregion
            #region Act
            int result = _mathematics.Subtract(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }
        [Theory, InlineData(3, 5)]
        public void MultiplyTest(int number1, int number2)
        {
            #region Act
            int result = _mathematics.Multiply(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(15, result);
            #endregion
        }
        [Theory, InlineData(30, 5, 6)]
        public void DivideTest(int number1, int number2, int expected)
        {
            #region Act
            int result = _mathematics.Divide(number1, number2);
            #endregion
            #region Assert
            Assert.Equal(expected, result);
            #endregion
        }
    }
}
