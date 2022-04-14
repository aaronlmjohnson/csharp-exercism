using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0) return 3.213f;  
        else if(balance < 1000) return .5f;  
        else if(balance < 5000) return 1.621f;
        else return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return  balance * (decimal)(InterestRate(balance) / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
       return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal compound = balance;
        int years = 0;

        while(compound < targetBalance){
            compound = AnnualBalanceUpdate(compound);
            years++;
        }

        return years;
    }
}

