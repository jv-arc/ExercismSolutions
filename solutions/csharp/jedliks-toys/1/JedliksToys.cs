class RemoteControlCar
{
    public int distance = 0;
    public int battery = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        car.distance = 0;
        car.battery = 100;
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(battery == 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {battery}%";
        }
        
    }

    public void Drive()
    {
        if(battery > 0)
        {
            distance = distance + 20;
            battery = battery - 1;
        }
    }
}
