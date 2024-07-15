using LinkedList;



try {

    Node nodeHead = new Node(1, null);
    linkedList linked = new linkedList(nodeHead);
    Node node2 = new Node(2, null);
    nodeHead.next = node2;
    Node node3 = new Node(2, null);
    node2.next = node3;
    Node node4 = new Node(2, null);
    node3.next = node4;
    Node node5 = new Node(5, null);
    node4.next = node5;
    //linked.Includes(2);
    //linked.Includes(5);
    //linked.Includes(6);
    //Console.WriteLine(linked.PrintList());
    //linked.PrintList();
    //linked.RemoveNode(1);
    //linked.RemoveNode(6);
    linked.PrintList();
    Console.WriteLine("************Remove Dublicate************************");
    linked.RemoveDuplicate();
    


}
catch (Exception e) {
    Console.WriteLine(e);

}   
