﻿using Aircompany;
using Aircompany.Models;
using Aircompany.Planes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AircompanyTests.Tests
{
    [TestFixture]
    public class TestsForTheAirport
    {
      private List<Plane> _planes = new List<Plane>(ModelPlane.Planes);
      private PassengerPlane _planeWithMaxPassengerCapacity = new PassengerPlane("Boeing-747", 980, 16100, 70500, 242);
      private List<Plane> _planesOrderedByMaxLoadCapacity = ModelPlane.Planes.OrderBy(x => x.GetMaxLoadCapacity()).ToList();
     [Test]
        public void ProbabilityOfDetectionTransportMilitaryPlanes()
        {
            Airport airport = new Airport(_planes);
            List<MilitaryPlane> transportMilitaryPlanes = airport.GetTransportMilitaryPlanes().ToList();
           
            Assert.IsTrue(transportMilitaryPlanes.Count!=0);
        }
     [Test]
        public void TheProbabilityOfDetectingApassengerAircraftMaximumCapacity()
        {
            Airport airport = new Airport(_planes);
            PassengerPlane expectedPlaneWithMaxPassengersCapacity = airport.GetPassengerPlaneWithMaxPassengersCapacity();
            Assert.IsTrue(expectedPlaneWithMaxPassengersCapacity.Equals(_planeWithMaxPassengerCapacity));
        }
     [Test]
        public void SortingByMaximumAircraftLoadCapacity()
        {
            Airport airport = new Airport(_planes);
            List<Plane> expectedPlanesSortedByMaxLoadCapacity = airport.SortPlanesByMaxLoadCapacity().GetPlanes().ToList();
            Assert.IsTrue(expectedPlanesSortedByMaxLoadCapacity.SequenceEqual(_planesOrderedByMaxLoadCapacity));
        }
    }
}
