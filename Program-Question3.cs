public class Solution
{
    public ListNode Question3(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode current = result;

        if (l1 == null && l2 == null) return null;
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }
        current.next = l1 ?? l2;
        return result.next;
    }
}