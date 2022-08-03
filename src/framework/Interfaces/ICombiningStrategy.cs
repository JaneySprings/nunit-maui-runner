// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

#nullable enable

using System.Collections;
using System.Collections.Generic;

namespace NUnit.Framework.Interfaces
{
    /// <summary>
    /// CombiningStrategy is the abstract base for classes that
    /// know how to combine values provided for individual test
    /// parameters to create a set of test cases.
    /// </summary>
    public interface ICombiningStrategy
    {
        /// <summary>
        /// Gets the test cases generated by the CombiningStrategy.
        /// </summary>
        /// <returns>The test cases.</returns>
        IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources);
    }
}
