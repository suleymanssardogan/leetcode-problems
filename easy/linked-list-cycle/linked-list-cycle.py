# Definition for singly-linked list.
class ListNode:
     def __init__(self, x):
         self.val = x
         self.next = None

from typing import Optional

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        # 1. Boş liste kontrolü (Pythonic yöntem)
        if not head:
            return False
        
        # 2. İşaretçileri başlat
        slow = head
        fast = head
        
        # 3. Hızlı olan (fast) ve bir sonraki adımı (fast.next) var olduğu sürece
        while fast and fast.next:
            slow = slow.next        # Yavaş 1 adım
            fast = fast.next.next   # Hızlı 2 adım
            
            # 4. Eğer aynı düğümde buluşurlarsa döngü vardır
            # Python'da nesne kimliği (identity) karşılaştırması için 'is' de kullanılabilir
            if slow == fast:
                return True
        
        # 5. Döngüden çıkıldıysa liste bitmiştir
        return False