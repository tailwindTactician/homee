class BusRoute
{
    public string RouteNumber;
    public List<string> Stops;
    public int TimeBetweenStops;
    public int ExpectedStops;

    public BusRoute()
    {
        Stops = new List<string>();
        TimeBetweenStops = 2;
    }
    public void SetRouteName(string routename, int stops)
    {
        RouteNumber = routename;
        ExpectedStops = stops;
    }
    public void AddStop(string stop)
    {
        Stops.Add(stop);
    }
    public int GetTotalTime()
    {
        if (Stops.Count < 2) return 0;
        return (Stops.Count - 1) * TimeBetweenStops;
    }
    public string GetNextStop(string currentStop)
    {
        int idx = Stops.IndexOf(currentStop);
        if (idx == -1)
        {
            return "Not Fount";
        }
        if (idx == Stops.Count - 1)
        {
            return "I Found but it's last";
        }

        return Stops[idx + 1];
    }
    public bool RemoveStop(string stop)
    {
        return Stops.Remove(stop);
    }
}