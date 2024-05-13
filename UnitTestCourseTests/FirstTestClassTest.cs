using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestCourse;
using FluentAssertions;

namespace UnitTestCourseTests
{
    public class FirstTestClassTest
    {
        //className_functionName_ExpectedResult
        [Fact]
        public static void FirstTestClass_HelloWorld_returnnString()
        {
            //Arrange - get your variables, classes
            FirstTestClass firstTestClass = new FirstTestClass();

            //Act
            string result = firstTestClass.HelloWorld();

            //Assert
            result.Should().Be("Hello World");
            
        }
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2,4,6)]
        public static void FirstTestClass_AddTwoNumbers_returnDecimal(decimal a,decimal b,decimal expectedValue)
        {
            //Arrange
            FirstTestClass firstTestClass = new FirstTestClass();

            //Act
            var result= firstTestClass.AddTwoNumbers(a,b);

            //Assert
            result.Should().Be(expectedValue);
            result.Should().BeGreaterThan(2);
        }
    }
}
