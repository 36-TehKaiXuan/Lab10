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
    }
}
