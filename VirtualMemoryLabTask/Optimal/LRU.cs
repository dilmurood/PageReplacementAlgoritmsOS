namespace VirtualMemoryLabTask.Optimal
{
    public static class LRU
    {
        public static int pageFaults(int[] pages, int n, int capacity)
        {
            HashSet<int> s = new HashSet<int>(capacity);
            Dictionary<int, int> indexes = new Dictionary<int, int>();
            int page_faults = 0;
            for (int i = 0; i < n; i++)
            {
                if (s.Count < capacity)
                {
                    if (!s.Contains(pages[i]))
                    {
                        s.Add(pages[i]);
                        page_faults++;
                    }

                    if (indexes.ContainsKey(pages[i]))
                        indexes[pages[i]] = i;
                    else
                        indexes.Add(pages[i], i);
                }
                else
                {
                    if (!s.Contains(pages[i]))
                    {
                        int lru = int.MaxValue, val = int.MinValue;
                        foreach (int itr in s)
                        {
                            int temp = itr;
                            if (indexes[temp] < lru)
                            {
                                lru = indexes[temp];
                                val = temp;
                            }
                        }

                        s.Remove(val);
                        indexes.Remove(val);
                        s.Add(pages[i]);
                        page_faults++;
                    }

                    if (indexes.ContainsKey(pages[i]))
                        indexes[pages[i]] = i;
                    else
                        indexes.Add(pages[i], i);
                }
            }
            return page_faults;
        }
    }
}