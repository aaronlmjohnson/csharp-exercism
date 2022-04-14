class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        int expectedMinutes = 40;
        return expectedMinutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainingMinutes){
        return ExpectedMinutesInOven() - remainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int layerCount){
        int timePerLayer = 2;
        return timePerLayer * layerCount;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int numOfLayers, int timeInOven){
        return PreparationTimeInMinutes(numOfLayers) + timeInOven;
    }
}
