import java.util.*;

//Find the kth largest element in an unsorted array. 
//Note that it is the kth largest element in the sorted order, 
//not the kth distinct element.

class KthLargestElement{
    public Integer FindKthLargestElement(Integer[] array, int k){
        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>();
        for(Integer number : array){
            minHeap.add(number);
            
            if(minHeap.size() > k){
                minHeap.remove();
            }
        }
        return minHeap.remove();
    }
}

class Main{
    public static void main (String[] args) {
    KthLargestElement k = new KthLargestElement();
    Integer[] array = {1,5,8,2,6,4,2,5,6};
    Integer result = k.FindKthLargestElement(array, 3);
    System.out.println(result);
    }
}