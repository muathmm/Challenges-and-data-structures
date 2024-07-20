using LinkedList;



try {

    //Node nodeHead = new Node(1, null);
    //linkedList linked = new linkedList(nodeHead);
    //Node node2 = new Node(2, null);
    //nodeHead.next = node2;
    //Node node3 = new Node(2, null);
    //node2.next = node3;
    //Node node4 = new Node(2, null);
    //node3.next = node4;
    //Node node5 = new Node(5, null);
    //node4.next = node5;
    //linked.Includes(2);
    //linked.Includes(5);
    //linked.Includes(6);
    //Console.WriteLine(linked.PrintList());
    //linked.PrintList();
    //linked.RemoveNode(1);
    //linked.RemoveNode(6);
    //linked.PrintList();
    //Console.WriteLine("************Remove Dublicate************************");
    //linked.RemoveDuplicate();


    linkedList list1 = new linkedList();
    //list1.AddNode(1);
    //list1.AddNode(3);
    //list1.AddNode(5);
    //list1.PrintList();
    linkedList list2 = new linkedList();
    list2.AddNode(2);
    list2.AddNode(4);
    list2.AddNode(6);


    linkedList merge= linkedList.MergeSortedLists(list1, list2);
    merge.PrintList();
    Console.WriteLine(merge.PrintList());
    
}
catch (Exception e) {
    Console.WriteLine(e);

}   
