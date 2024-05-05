public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue a 3 items with different priority values and
        // dequeue the item with the highest priority
        // Expected Result: Work
        Console.WriteLine("Test 1");
        var priorities = new PriorityQueue();
        priorities.Enqueue("School", 2);
        priorities.Enqueue("Work", 5);
        priorities.Enqueue("Church", 3);

        Console.WriteLine(priorities.Dequeue());
        // Defect(s) Found: There were no defects found in this test

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue 5 items, 2 of which have the same priority values. 
        // The item that appeared first of the two with the same priority will be
        // dequeued first
        // Expected Result: Family, Work, Church, School, Friends

        Console.WriteLine("Test 2");
        priorities = new PriorityQueue();
        priorities.Enqueue("School", 4);
        priorities.Enqueue("Work", 5);
        priorities.Enqueue("Church", 5);
        priorities.Enqueue("Family", 6);
        priorities.Enqueue("Friends", 3);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(priorities.Dequeue());
        }
        ;
        // Defect(s) Found: This found that the Dequeue() function doesn't actually remove items from the queue. It also found that the function did not remove the item closest to the front of the queue

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Try to get the next item from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        priorities = new PriorityQueue();
        Console.WriteLine(priorities.Dequeue());
        // Defect(s) Found: There were no defects found in this test.
    }
}