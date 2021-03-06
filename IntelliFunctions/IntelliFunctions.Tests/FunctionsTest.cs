using Microsoft.Pex.Framework.Exceptions;
// <copyright file="FunctionsTest.cs">Copyright ©  2016</copyright>
using System;
using IntelliFunctions;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace IntelliFunctions.Tests
{
    /// <summary>This class contains parameterized unit tests for Functions</summary>
    [PexClass(typeof(Functions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FunctionsTest
    {
        [PexMethod]
        public void SortTest(int[] elems)
        {
+
        }

        [PexMethod]
        public void UnionTest(int[] array1, int[] array2)
        {
            
        }

        [PexMethod]
        public void XandYIsOddTest(int[] array)
        {

        }
    }
}
