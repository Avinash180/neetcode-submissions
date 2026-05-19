/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        ListNode current2 = head;
        ListNode prev = null;
        int length = 0;

        //Find length of the linked list
        while(current!=null){
            length++;
            current = current.next;
        }
        if(length == 1){
            return prev;
        }
        int currentLength = 0;
        int positionToBeRemoved = length - n + 1;

        while(current2!=null){ 
            currentLength++;
            if(currentLength == positionToBeRemoved){
                if(prev!=null){
                    prev.next = current2.next;
                    break;
                }
                else{
                    prev = current2.next;
                    head = prev;
                }
            }
            prev = current2;
            current2 = current2.next;
        }

        return head;
    }
}
