using UnityEngine;
using TMPro;

public class TotalMoneyDayAndRent : MonoBehaviour
{
    float totalMoney;
    float rent;
    float day;

    [SerializeField] TMP_Text UITotalMoney;
    [SerializeField] TMP_Text UIRent;
    [SerializeField] TMP_Text UIDay;

    private void Start()
    {
        day = 1;
        UIDay.text = day.ToString();
    }

    public void ChangeTotalMoney(int quantityToAdd)
    {
        Stats.totalMoney = Stats.totalMoney + quantityToAdd;
        UITotalMoney.text = totalMoney.ToString();
    }

    public void ChangeUIRent(int quantityToAdd)
    {
        rent = rent + quantityToAdd;
        UIRent.text = rent.ToString();
    }

    public void ToTomorrow()
    {
        day++;
        UIDay.text = day.ToString();
    }
}
