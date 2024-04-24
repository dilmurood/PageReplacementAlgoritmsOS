// C# Program to demonstrate optimal page replacement algorithm.
static class OPR
{
    static int predict(int[] pg, List<int> fr, int pn, int index)
    {
        int res = -1;
        int farthest = index;
        for (int i = 0; i < fr.Count; i++)
        {
            int j;
            for (j = index; j < pn; j++)
            {
                if (fr[i] == pg[j])
                {
                    if (j > farthest)
                    {
                        farthest = j;
                        res = i;
                    }
                    break;
                }
            }

            if (j == pn)
                return i;
        }

        return (res == -1) ? 0 : res;
    }

    static bool search(int key, List<int> fr)
    {
        for (int i = 0; i < fr.Count; i++)
        {
            if (fr[i] == key)
                return true;
        }
        return false;
    }

    public static void optimalPage(int[] pg, int pn, int fn)
    {
        List<int> fr = new List<int>();

        int hit = 0;
        for (int i = 0; i < pn; i++)
        {
            if (search(pg[i], fr))
            {
                hit++;
                continue;
            }

            if (fr.Count < fn)
                fr.Add(pg[i]);
            else
            {
                int j = predict(pg, fr, pn, i + 1);
                fr[j] = pg[i];
            }
        }
        Console.WriteLine("Number of faults = " + (pn - hit));
    }
}
