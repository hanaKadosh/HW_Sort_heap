class SortHeap{
//heap Sort
//hana kadosh
	//Running complexity time -log(n), 
	//heap sort is the most efficient sort, more efficient than quick sort double 2 
	//The sorting principle is to search for the minimum element and insert it into the array in each interaction
	//Advantages of heapSort:
	//Memory Usage – Memory usage is minimal because apart from what is necessary to hold the initial list of items to be sorted,
	//it needs no additional memory space to work
	public void heapSort(int arr[])
    {
        int temp;
        for (int i = arr.length / 2 - 1; i >= 0; i--)//build the heap
        	{
            	heapify(arr, arr.length, i);
        	}
        for (int i = arr.length - 1; i > 0; i--) //extract elements from the heap
        	{
	            temp = arr[0];//move current root to end (since it is the largest)
	            arr[0] = arr[i];
	            arr[i] = temp;
	            heapify(arr, i, 0); //recall heapify to rebuild heap for the remaining elements
        	}
    	}
	
    public  void heapify(int arr[], int n, int i)
    {
        int MAX = i; // Initialize largest as root
        int left = 2 * i + 1; //index of the left child of ith node = 2*i + 1
        int right = 2 * i + 2; //index of the right child of ith node  = 2*i + 2
        int temp;

        if (left < n && arr[left] > arr[MAX])//check if the left child of the root is larger than the root
        {
            MAX = left;
        }
        if (right < n && arr[right] > arr[MAX])//check if the right child of the root is larger than the root
        {
            MAX = right;
        }
        if (MAX != i) 
        {   //repeat the procedure for finding the largest element in the heap
            temp = arr[i];
            arr[i] = arr[MAX];
            arr[MAX] = temp;
            heapify(arr, n, MAX);
        }
    }
    
  //display the array
    void display(int arr[]) 
    {  
        for (int i=0; i<arr.length; ++i) 
        {
            System.out.print(arr[i]+" ");
        } 
    } 
    public static void main(String[] args) {
		SortHeap h = new SortHeap();
        int arr[] = { 1, 12, 9 , 3, 10, 15 };
		    h.heapSort(arr);
		    h.display(arr);
            
	}
}