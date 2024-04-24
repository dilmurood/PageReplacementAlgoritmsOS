using System.Collections; 
public static class FIFO 
{ 
	public static int pageFaults(int []pages, int n, int capacity) 
	{ 
		HashSet<int> s = new HashSet<int>(capacity); 
		Queue indexes = new Queue() ; 	
		int page_faults = 0; 
		for (int i = 0; i < n; i++) 
		{ 
			if (s.Count < capacity) 
			{ 
				if (!s.Contains(pages[i])) 
				{ 
					s.Add(pages[i]); 
	    			page_faults++; 
    				indexes.Enqueue(pages[i]); 
				} 
			} 
			else
			{ 
				if (!s.Contains(pages[i])) 
				{ 
					int val = (int)indexes.Peek(); 	
					indexes.Dequeue();  
					s.Remove(val);  
					s.Add(pages[i]); 
					indexes.Enqueue(pages[i]);  
					page_faults++; 
				} 
			} 
		} 
		return page_faults; 
	}  
} 