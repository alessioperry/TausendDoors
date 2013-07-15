using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TausendDoors
{
    [TestFixture]
    public class TausendDoorsTest
    {
        [Test]
        public void DoorsAreClosed()
        {
            var door = new Door();

            Assert.AreEqual(Status.Closed, door.Status());
        }

        [Test]
        [Ignore("this test is replicated OpenedDoorStatusIsOpen due to ctor refactoring")]
        public void DoorsAreOpened()
        {
            var door = new Door();
            door.Open();

            Assert.AreEqual(Status.Open, door.Status());
        }

        [Test]
        public void ClosedDoorStatusIsClose()
        {
            var door = new Door();
            door.Close();

            Assert.AreEqual(Status.Closed, door.Status());
        }

        [Test]
        public void OpenedDoorStatusIsOpen()
        {
            var door = new Door();
            door.Open();

            Assert.AreEqual(Status.Open, door.Status());
        }

        [Test]
        public void DoorsThatAreClosedAreNotOpen()
        {
            var door = new Door();

            Assert.AreEqual(Status.Closed, door.Status());
            Assert.AreNotEqual(Status.Open, door.Status());
        }

        [Test]
        [Ignore("this test is replicated OpenedDoorStatusIsOpen due to ctor refactoring")]
        public void SomeoneCloseDoorIfItWasOpened()
        {
            var door = new Door();

            if (door.Status() == Status.Open)
            {
                door.Close();
            }
            Assert.AreEqual(Status.Closed, door.Status());
        }

        [Test]
        public void APersonPassADoor()
        {
            var door = new Door();
            var person = new Person();

            Assert.AreEqual(Status.Closed, door.Status());

            person.StepOver( door);

            Assert.AreEqual(Status.Open, door.Status());
        }




        [Test]
        public void OneHundredStepsForATunnel()
        {
            var person = new Person();
            var tunnel = new Tunnel(100);

            tunnel.ForEach(door=> person.StepOver(door));
            
            Assert.AreEqual(100, person.Steps());
        }

        [Test]
        public void OneHundredStepsByTwoForATunnel()
        {
            var person = new Person();
            var tunnel = new Tunnel(100);

            for (int i = 0; i < 100; i += 2)
            {
                person.StepOver(tunnel[i]);
            }

            Assert.AreEqual(50, person.Steps());
        }

        




    }
}
