﻿using SortAlgorithm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortTests
{
    public class MockNegativePositiveRandomData : IEnumerable<object[]>
    {
        private List<object[]> testData = new List<object[]>();

        public MockNegativePositiveRandomData()
        {
            testData.Add(new object[] { new InputSample<int>() { InputType = InputType.MixRandom, Samples = Enumerable.Range(-50, 100).Sample(100).ToArray() } });
            testData.Add(new object[] { new InputSample<int>() { InputType = InputType.MixRandom, Samples = Enumerable.Range(-500, 1000).Sample(1000).ToArray() } });
            testData.Add(new object[] { new InputSample<int>() { InputType = InputType.MixRandom, Samples = Enumerable.Range(-5000, 10000).Sample(10000).ToArray() } });
        }

        public IEnumerator<object[]> GetEnumerator() => testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
