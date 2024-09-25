using LinkedList;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a new linked list and add nodes
            linkedList list = new linkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.AddNode(6);

            Console.WriteLine("Original Linked List:");
            Console.WriteLine(list.PrintList());  // Output: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null

            // Rotate the linked list left by k = 2
            int k = 2;
            list.RotateLeft(k);

            Console.WriteLine($"\nLinked List after rotating left by {k} places:");
            Console.WriteLine(list.PrintList());  // Expected Output: 3 -> 4 -> 5 -> 6 -> 1 -> 2 -> null

            // Test rotating by k = 0 (no rotation)
            list = new linkedList();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);

            Console.WriteLine("\nOriginal Linked List:");
            Console.WriteLine(list.PrintList());  // Output: 10 -> 20 -> 30 -> 40 -> 50 -> null

            k = 0;
            list.RotateLeft(k);

            Console.WriteLine($"\nLinked List after rotating left by {k} places:");
            Console.WriteLine(list.PrintList());  // Expected Output: 10 -> 20 -> 30 -> 40 -> 50 -> null

            // Test rotating by k greater than the list length (k = 7)
            k = 7;
            list.RotateLeft(k);

            Console.WriteLine($"\nLinked List after rotating left by {k} places (k > list length):");
            Console.WriteLine(list.PrintList());  // Expected Output: 40 -> 50 -> 10 -> 20 -> 30 -> null
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
