using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz.FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [Test]
        public void FizzBuzz_Length()
        {
            int start = 0;
            int end = 100;

            //arrange / act
            var result = _fizzBuzz.DoFizzBuzz(start, end, 3, 5);

            //assert
            Assert.AreEqual(result.Count(), end - start + 1, $"Counts did not match.  Result count: {result.Count()}, actual count: {end - start + 1}");
        }

        [Test]
        public void FizzBuzz_Fizz()
        {
            int start = 0;
            int end = 100;
            int fizz = 3;
            int buzz = 5;

            //arrange / act
            var result = _fizzBuzz.DoFizzBuzz(start, end, fizz, buzz).ToArray();

            //assert
            for (int i = start; i <= end; i++)
            {
                if (result[i] == "Fizz")
                    Assert.True(i % fizz == 0 && i % buzz != 0, $"Fizz was found at array index {i}. However, {i} % {fizz} operation did not produce 0 as a result for some reason.");
            }
        }

        [Test]
        public void FizzBuzz_Buzz()
        {
            int start = 0;
            int end = 100;
            int fizz = 3;
            int buzz = 5;

            //arrange / act
            var result = _fizzBuzz.DoFizzBuzz(start, end, fizz, buzz).ToArray();

            //assert
            for (int i = start; i <= end; i++)
            {
                if (result[i] == "Buzz")
                    Assert.True(i % buzz == 0 && i % fizz != 0, $"Buzz was found at array index {i}. However, {i} % {buzz} operation did not produce 0 as a result for some reason.");
            }
        }

        [Test]
        public void FizzBuzz_FizzBuzz()
        {
            int start = 0;
            int end = 100;
            int fizz = 3;
            int buzz = 5;

            //arrange / act
            var result = _fizzBuzz.DoFizzBuzz(start, end, fizz, buzz).ToArray();

            //assert
            for (int i = start; i <= end; i++)
            {
                if (result[i] == "FizzBuzz")
                    Assert.True(i % buzz == 0 && i % fizz == 0, $"FizzBuzz was found at array index {i}. However {i} % {fizz} or {i} % {buzz} operation did not produce 0 as a result for some reason.");
            }
        }

        [Test]
        public void FizzBuzz_NeitherFizzNorBuzz()
        {
            int start = 0;
            int end = 100;
            int fizz = 3;
            int buzz = 5;

            //arrange / act
            var result = _fizzBuzz.DoFizzBuzz(start, end, fizz, buzz).ToArray();

            for (int i = start; i <= end; i++)
            {
                var res = result[i];
                if (res != "Fizz" && res != "Buzz" && res != "FizzBuzz")
                {
                    var parsed = int.TryParse(res, out int val);
                    if (!parsed)
                        throw new InvalidOperationException($"Error when parsing item {i} to int.  Value: {res}");

                    Assert.AreEqual(val, i);
                }
            }

        }
    }
}