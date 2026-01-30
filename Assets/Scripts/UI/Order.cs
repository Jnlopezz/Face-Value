using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class Order : MonoBehaviour
{
    public int clientSpriteId;
    List<float> orderPayments;

    [SerializeField] Image UIOrder;
    [SerializeField] TMP_Text UIPay;

    //La información de un cliente aparece en la UI correspondiente
    private void Start()
    {
        orderPayments = new List<float>();

        for (int i = 0; i < 6; i++)
        {
            orderPayments.Add(0);
        }

        //Inicialización de los precios umbral de cada nivel
        orderPayments[0] = 40;
        orderPayments[1] = 44;
        orderPayments[2] = 71;
        orderPayments[3] = 105;
        orderPayments[4] = 252;
        orderPayments[5] = 102;

        UIPay.text = orderPayments[clientSpriteId].ToString();
    }
}
