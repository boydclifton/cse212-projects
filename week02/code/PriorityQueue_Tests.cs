using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add a regular fan to the queue with a priority of 1, then add a VIP fan to the 
    // queue with a priority of 5, then add a Super VIP fan to the queue with a priority of 10.
    // Expected Result: Dequeue should return the Super VIP fan first, then the VIP fan, then the regular fan.
    // Defect(s) Found: The original code failed to actually remove the item with the highest priority from the queue.  
    // The code was fixed by adding a line to remove the item at the highPriorityIndex after it is found.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Regular Fan", 1);
        priorityQueue.Enqueue("VIP Fan", 5);
        priorityQueue.Enqueue("Super VIP Fan", 10);

        Assert.AreEqual("Super VIP Fan", priorityQueue.Dequeue());
        Assert.AreEqual("VIP Fan", priorityQueue.Dequeue());
        Assert.AreEqual("Regular Fan", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add Bob, Sue, and George to the queue, all with the same priority of 1.  
    // Expected Result: Dequeue should return the items in the order they were added.
    // Defect(s) Found: The original code used a >= comparison when finding the high priority index, which caused 
    // the last item with the highest priority to be returned first instead of the first item. 
    // The code was fixed by changing the comparison to > so that the first item with the highest priority
    //  is returned first. Additionally, the loop also stopped one iteration too early, so the loop was changed 
    // to go to index < _queue.Count instead of index < _queue.Count - 1.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 1);
        priorityQueue.Enqueue("George", 1);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("George", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}