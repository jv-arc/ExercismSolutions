class Lasagna
{
    private int _totalPrepTime = 40;
    
    private int _perLayerTime = 2;
    
    public int ExpectedMinutesInOven()
    {
        return _totalPrepTime;
    }

    public int RemainingMinutesInOven( int elapsedTime )
    {
        return _totalPrepTime - elapsedTime;
    }

    public int PreparationTimeInMinutes( int numberOfLayers )
    {
        return numberOfLayers * _perLayerTime;
    }

    public int ElapsedTimeInMinutes( int numberOfLayers, int inOvenTime )
    {
        return (numberOfLayers * _perLayerTime) + inOvenTime;
    }
}
