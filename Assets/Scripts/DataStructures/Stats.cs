using UnityEngine;

public static class Stats
{
    public static float totalMoney { get; set; }

    static Stats()
    {
        totalMoney = 0;
    }
}
