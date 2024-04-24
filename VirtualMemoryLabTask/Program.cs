using VirtualMemoryLabTask.Optimal;
Console.WriteLine();
Console.WriteLine("Optimal Page Replacement Algorithm");
int[] pages = { 7, 0, 1, 2, 0, 3, 0, 4, 2, 3, 0, 3, 2 };
int[] testPages1 = {1 ,2, 3, 4, 1, 2, 5, 1, 2, 3, 4, 5};
int[] testPages2 = { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1 };
int[] testPages3 = {7, 0, 1, 2, 0, 3, 0, 4, 2, 3, 0, 3, 2};
int capacity = 4;
OPR.optimalPage(pages, pages.Length, capacity);
OPR.optimalPage(testPages1, testPages1.Length, capacity);
OPR.optimalPage(testPages2, testPages2.Length, 3);
OPR.optimalPage(testPages3, testPages3.Length, capacity);

Console.WriteLine("==========================================================");
Console.WriteLine("Number of page faults using LRU: ");
Console.WriteLine(LRU.pageFaults(pages, pages.Length, capacity));
Console.WriteLine(LRU.pageFaults(testPages1, testPages1.Length, capacity));
Console.WriteLine(LRU.pageFaults(testPages2, testPages2.Length, 3));
Console.WriteLine(LRU.pageFaults(testPages3, testPages3.Length, capacity));

Console.WriteLine("==========================================================");
Console.WriteLine("Number of page faults using FIFO: ");
Console.WriteLine(FIFO.pageFaults(pages, pages.Length, capacity));
Console.WriteLine(FIFO.pageFaults(testPages1, testPages1.Length, capacity));
Console.WriteLine(FIFO.pageFaults(testPages2, testPages2.Length, 3));
Console.WriteLine(FIFO.pageFaults(testPages3, testPages3.Length, capacity));
Console.WriteLine();