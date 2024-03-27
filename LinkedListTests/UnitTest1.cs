using CPRG211Lab8;
using System.Security.Principal;

namespace LinkedListTests

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LinkedListAddFirstTest()
        {
            LinkedList list = new LinkedList();

            list.AddFirst("Joe Blow");
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.GetValue(1), Is.EqualTo("Joe Blow"));

            list.AddFirst("Joe Schmoe");
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list.GetValue(1), Is.EqualTo("Joe Schmoe"));

            list.AddFirst("John Smith");
            Assert.That(list.Count, Is.EqualTo(3));
            Assert.That(list.GetValue(1), Is.EqualTo("John Smith"));

            list.AddFirst("Jane Doe");
            Assert.That(list.Count, Is.EqualTo(4));
            Assert.That(list.GetValue(1), Is.EqualTo("Jane Doe"));

            list.AddFirst("Bob Bobberson");
            Assert.That(list.Count, Is.EqualTo(5));
            Assert.That(list.GetValue(1), Is.EqualTo("Bob Bobberson"));

            list.AddFirst("Sam Sammerson");
            Assert.That(list.Count, Is.EqualTo(6));
            Assert.That(list.GetValue(1), Is.EqualTo("Sam Sammerson"));

            list.AddFirst("Dave Daverson");
            Assert.That(list.Count, Is.EqualTo(7));
            Assert.That(list.GetValue(1), Is.EqualTo("Dave Daverson"));
        }

        [Test]
        public void LinkedListAddLastTest()
        {
            LinkedList list = new LinkedList();

            list.AddLast("Joe Blow");
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.GetValue(1), Is.EqualTo("Joe Blow"));

            list.AddLast("Joe Schmoe");
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list.GetValue(2), Is.EqualTo("Joe Schmoe"));

            list.AddLast("John Smith");
            Assert.That(list.Count, Is.EqualTo(3));
            Assert.That(list.GetValue(3), Is.EqualTo("John Smith"));

            list.AddLast("Jane Doe");
            Assert.That(list.Count, Is.EqualTo(4));
            Assert.That(list.GetValue(4), Is.EqualTo("Jane Doe"));

            list.AddLast("Bob Bobberson");
            Assert.That(list.Count, Is.EqualTo(5));
            Assert.That(list.GetValue(5), Is.EqualTo("Bob Bobberson"));

            list.AddLast("Sam Sammerson");
            Assert.That(list.Count, Is.EqualTo(6));
            Assert.That(list.GetValue(6), Is.EqualTo("Sam Sammerson"));

            list.AddLast("Dave Daverson");
            Assert.That(list.Count, Is.EqualTo(7));
            Assert.That(list.GetValue(7), Is.EqualTo("Dave Daverson"));
        }

        [Test]
        public void LinkedListRemoveFirstTest()
        {
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            list.AddLast("Jane Doe");
            list.AddLast("Bob Bobberson");
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(6));
            Assert.That(list.GetValue(1), Is.EqualTo("Joe Schmoe"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(5));
            Assert.That(list.GetValue(1), Is.EqualTo("John Smith"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(4));
            Assert.That(list.GetValue(1), Is.EqualTo("Jane Doe"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(3));
            Assert.That(list.GetValue(1), Is.EqualTo("Bob Bobberson"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list.GetValue(1), Is.EqualTo("Sam Sammerson"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.GetValue(1), Is.EqualTo("Dave Daverson"));

            list.RemoveFirst();
            Assert.That(list.Count, Is.EqualTo(0));
            Assert.That(list.GetValue(1), Is.EqualTo(null));

            Assert.Throws<System.InvalidOperationException>(() => list.RemoveFirst());
        }

        [Test]
        public void LinkedListRemoveLastTest()
        {
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            list.AddLast("Jane Doe");
            list.AddLast("Bob Bobberson");
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(6));
            Assert.That(list.GetValue(6), Is.EqualTo("Sam Sammerson"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(5));
            Assert.That(list.GetValue(5), Is.EqualTo("Bob Bobberson"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(4));
            Assert.That(list.GetValue(4), Is.EqualTo("Jane Doe"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(3));
            Assert.That(list.GetValue(3), Is.EqualTo("John Smith"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list.GetValue(2), Is.EqualTo("Joe Schmoe"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.GetValue(1), Is.EqualTo("Joe Blow"));

            list.RemoveLast();
            Assert.That(list.Count, Is.EqualTo(0));
            Assert.That(list.GetValue(1), Is.EqualTo(null));

            Assert.Throws<System.InvalidOperationException>(() => list.RemoveLast());
        }

        //list.Count and list.GetValue() were part of above tests and do not need to be separately tested.

    }
}