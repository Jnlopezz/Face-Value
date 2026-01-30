using UnityEngine;
using TMPro;

public class SellerLore : MonoBehaviour
{
    string[] loreTexts;
    [SerializeField] int loreId;
    [SerializeField] TMP_Text loreUI;

    void Start()
    {
        loreTexts = new string[5];

        loreTexts[0] = "La demanda de metaformosis es cada vez mayor. Compre un rostro y transforme su vida. ¡Es indoloro y de quita y pon! Puede encontrarnos en redes sociales.";
        loreTexts[1] = "Conviértase en pensionista, bebé o pez de colores. Consiga las habilidades de un campeon de lucha libre o un cirujano con nuestros módicos precios (impuestos no incluidos).";
        loreTexts[2] = "Coloque la máscara delante de su cara y detrás del rostro que quiere adoptar.";
        loreTexts[3] = "¡Ya es la cuarta vez que confía en nosotros este mes!";
        loreTexts[4] = "¿La quiere para ocultarse? ¿Para cambiar? ¿Qué pasa? ¿Acaso no quiere ser otro? ¿No es muy tarde para empezar a pensar en su verdadero yo?";

        loreUI.text = loreTexts[loreId];
    }
}
