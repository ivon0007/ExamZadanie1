using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace MathAndStringTests
{
    // Класс для реализации тестов со строковыми функциями
    public class StringOperations
    {
        public string ConvertToLowerCase(string input) => input.ToLower();
    }

    // Задание 10: Преобразование строки в нижний региcтр
    public class StringOperationsTests
    {
        private readonly StringOperations _stringOps = new StringOperations();

        [Fact]
        public void Test10_ConvertToLowerCase()
        {
            string input = "HELLO WORLD";
            string expected = "hello world";

            string result = _stringOps.ConvertToLowerCase(input);

            Assert.Equal(expected, result);
            Assert.True(result.All(c => !char.IsUpper(c))); // Дополнительная проверка
        }
    }
}