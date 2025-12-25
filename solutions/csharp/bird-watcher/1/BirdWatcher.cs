class BirdCount
{
    private int[] birdsPerDay;
    private static int[] _lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
    
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return _lastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        int index = birdsPerDay.Length - 1;
        birdsPerDay[index] = birdsPerDay[index] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach( int birdCount in birdsPerDay)
        {
            if(birdCount == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int i;
        int sum = 0;
        int limit;

        if(numberOfDays > birdsPerDay.Length)
        {
            limit = birdsPerDay.Length;
        }
        else
        {
            limit = numberOfDays;
        }

        
        for(i=0; i < limit; i++)
        {
            sum += birdsPerDay[i];
        }
        
        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int day in birdsPerDay)
        {
            if(day >=5 )
            {
                busyDays++;
            }
        }

        return busyDays;
    }
}
