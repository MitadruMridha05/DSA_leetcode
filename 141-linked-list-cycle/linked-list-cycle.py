# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        dump=ListNode()
        dump=head
        while(dump!=None):
            if(type(dump.val)==float):
                return True
            dump.val=float(dump.val)
            if(dump.next==None):
                return False
            dump=dump.next