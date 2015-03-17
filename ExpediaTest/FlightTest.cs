using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        private readonly DateTime dateThatFlightLeaves = new DateTime(2009,11,10);
        private readonly DateTime dateThatFlightReturn = new DateTime(2009,11,30);
        public int Miles = 500;

        [Test()]
        public void testThatFlightInitialize()
        {
            var target = new Flight (dateThatFlightLeaves,dateThatFlightLeaves,Miles);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceFor10Days()
        {
            var target = new Flight(new DateTime(2015, 3, 20), new DateTime(2015, 3, 30), 1000);
            Assert.AreEqual(400, target.getBasePrice());
        }


        [Test()]
        public void TestThatFlightHasCorrectBasePriceFor30Days()
        {
            var target = new Flight(new DateTime(2015, 5, 1), new DateTime(2015, 5, 31), 1000);
            Assert.AreEqual(800, target.getBasePrice());
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadMiles()
        {
            new Flight(new DateTime(2015, 3, 10), new DateTime(2015, 3, 30), -1000);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDate()
        {
            new Flight(new DateTime(2015, 3, 10), new DateTime(2015, 3, 1), 1000);
        }
	}
}
