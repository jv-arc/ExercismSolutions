class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;

    private int _battery = 100;
    private int _distanceDriven = 0;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return (_battery < _batteryDrain);
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if(!(this.BatteryDrained()))
        {
            _battery -= _batteryDrain;
        
            _distanceDriven += _speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar newNitroCar = new RemoteControlCar(50, 4);
        return newNitroCar;
    }
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool batteryAlive;
        bool trackFinished;

        do
        {
            car.Drive();
            batteryAlive = !car.BatteryDrained();
            trackFinished = car.DistanceDriven() >= _distance;
        } while(batteryAlive && !trackFinished);

        return trackFinished;
    }
}
