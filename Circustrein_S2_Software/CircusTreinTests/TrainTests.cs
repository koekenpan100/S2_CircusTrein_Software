using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein_S2_Software;

namespace CircusTreinTests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void TrainAddsWagonToTrainWhenWagonIsNotNullAndReturnsTrue()
        {
            Train train = new Train();
            Wagon wagon = new Wagon(1);
            Assert.AreEqual(true, train.AddWagon(wagon));
        }

        [TestMethod]
        public void TrainDoesntAddWagonWhenWagonIsNullAndReturnsFalse()
        {
            Train train = new Train();
            Wagon wagon = null;
            Assert.AreEqual(false, train.AddWagon(wagon));
        }

        [TestMethod]
        public void TrainReturnsCorrectToString()
        {
            Train train = new Train();
            Wagon wagon = new Wagon(1);
            train.AddWagon(wagon);
            string toString = "Train has the following amount of wagons:" + train.Wagons.Count;
            Assert.AreEqual(toString, train.ToString());
        }
    }
}
