// ****************************************************************
// Copyright 2002-2018, Charlie Poole
// This is free software licensed under the NUnit license, a copy
// of which should be included with this software. If not, you may
// obtain a copy at https://github.com/nunit-legacy/nunitv2.
// ****************************************************************

namespace NUnit.Framework.Constraints
{
    [TestFixture]
    public class OrConstraintTests : ConstraintTestBase
    {
        [SetUp]
        public void SetUp()
        {
            theConstraint = new OrConstraint(new EqualConstraint(42), new EqualConstraint(99));
            expectedDescription = "42 or 99";
            stringRepresentation = "<or <equal 42> <equal 99>>";
        }

        internal object[] SuccessData = new object[] { 99, 42 };

        internal object[] FailureData = new object[] { 37 };

        internal string[] ActualValues = new string[] { "37" };

        [Test]
        public void CanCombineTestsWithOrOperator()
        {
            Assert.That(99, new EqualConstraint(42) | new EqualConstraint(99) );
        }
    }
}