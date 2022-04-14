using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
            return 0;
        else if(speed < 5)
            return 1.00;
        else if(speed < 9)
            return .9;
        else if(speed == 9)
            return .80;
        else
            return .77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
         int productionAmount = speed * 221;
        return productionAmount * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return  (int)ProductionRatePerHour(speed) / 60;
    }
}
