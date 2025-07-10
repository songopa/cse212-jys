using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue and Dequeue a single item
    // Expected Result: The item is returned by Dequeue
    // Defect(s) Found: 
    public void TestPriorityQueue_EnqueueDequeueSingle()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Eat", 1);
        Assert.AreEqual("Eat", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities
    // Expected Result: Dequeue returns the item with the highest priority
    // Defect(s) Found: 
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Soda", 1);
        pq.Enqueue("Water", 3);
        pq.Enqueue("Juice", 2);
        Assert.AreEqual("Water", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority
    // Expected Result: Dequeue returns the first inserted item with the highest priority (FIFO)
    // Defect(s) Found: The dequeue method was not removing the item from the queue
    public void TestPriorityQueue_FIFOWithSamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Rice", 2);
        pq.Enqueue("Meat", 3);
        pq.Enqueue("Vegs", 3);
        Assert.AreEqual("Meat", pq.Dequeue());
        Assert.AreEqual("Vegs", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: 
    [ExpectedException(typeof(System.InvalidOperationException))]
    public void TestPriorityQueue_DequeueEmpty()
    {
        var pq = new PriorityQueue();
        pq.Dequeue();
    }


}