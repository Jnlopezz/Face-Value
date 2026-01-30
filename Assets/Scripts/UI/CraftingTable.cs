using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CraftingTable : MonoBehaviour
{
    public List<Ingredient> ingredients;
    [SerializeField] Sprite[] sprites;

    List<Ingredient> selectedIngredients;
    int selectedIngredientsId;

    [SerializeField] TMP_Text[] UIIngredientNames;

    float orderPrice;
    [SerializeField] TMP_Text UICraftPrice;
    [SerializeField] TMP_Text UICraftProfit;

    //Todos los ingredientes se ponen en la UI correspondiente
    void Start()
    {
        ingredients = new List<Ingredient>();
        selectedIngredients = new List<Ingredient>();

        for (int i = 0; i < 9; i++)
        {
            ingredients.Add(new Ingredient());
        }

        for (int i = 0; i < 4; i++)
        {
            selectedIngredients.Add(new Ingredient());
        }

        //Inicializar ingredientes
        ingredients[0].ingredientName = "a";
        ingredients[1].ingredientName = "a";
        ingredients[2].ingredientName = "a";
        ingredients[3].ingredientName = "a";
        ingredients[4].ingredientName = "a";
        ingredients[5].ingredientName = "a";
        ingredients[6].ingredientName = "a";
        ingredients[7].ingredientName = "a";
        ingredients[8].ingredientName = "a";

        ingredients[0].ingredientPrice = 16;
        ingredients[1].ingredientPrice = 8;
        ingredients[2].ingredientPrice = 24;
        ingredients[3].ingredientPrice = 20;
        ingredients[4].ingredientPrice = 21;
        ingredients[5].ingredientPrice = 11;
        ingredients[6].ingredientPrice = 39;
        ingredients[7].ingredientPrice = 54;
        ingredients[8].ingredientPrice = 59;

        for (int i = 0; i < sprites.Length; i++)
        {
            ingredients[i].ingredientSprite = sprites[i];
        }
    }

    public void AddToSelectedIngredients(int ingredientId)
    {
        int i = 0;
        for (i = 0; i < selectedIngredients.Count; i++)
        {
            if (selectedIngredients[i].ingredientSprite == null)
            {
                selectedIngredients[i] = ingredients[ingredientId];
                UIIngredientNames[i].text = selectedIngredients[i].ingredientName;
                UIIngredientNames[i].gameObject.SetActive(true);

                break;
            }
        }

        CalculatePrice(selectedIngredients);
    }

    void CalculatePrice(List<Ingredient> ingredients)
    {
        float totalPrice = 0;

        for (int i = 0; i < ingredients.Count; i++)
        {
            totalPrice += ingredients[i].ingredientPrice;
        }

        UICraftPrice.text = totalPrice.ToString();
    }
}
