using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        public float result = 0.0f;
        //Addition
        [Test]
        public void TestAddition()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        //Subtraction
        [Test]
        public void TestSubtraction()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        //Multiplication
        [Test]
        public void TestMultiplication()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        //Division
        [Test]
        public void TestDivision()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }

        //Power
        [Test]
        public void TestPower()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }
        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }

        //Sqrt
        [Test]
        public void TestSqrt()
        {
            //Use assert class to test conditions
            result = Calculator.CalculatePair(16, 0, "√");
            Assert.AreEqual(result, 4);
        }
        [UnityTest]
        public IEnumerator TestUnitySqrt()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(16, 0, "√");
            Assert.AreEqual(result, 4);
        }
    }
}
