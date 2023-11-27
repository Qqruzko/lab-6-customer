
    class Triangle
    {
    public void populate(int AB,int BC,int CA)
    {
        
        tAB = AB;
        tBC = BC;
        tCA = CA;
    }
    private static int tAB = 0;
    private static int tBC = 0;
    private static int tCA = 0;
    public int pAB()
    {
        return (tAB);
    }
    public int pBC()
    {
        return (tBC);
    }
    public int pCA()
    {
        return (tCA);
    }
}

