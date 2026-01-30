using UnityEngine;

public class Ingredient
{
    public int ingredientId;
    public string ingredientName;
    public float ingredientPrice;
    public Sprite ingredientSprite;

    public Ingredient(int ingredientId, string ingredientName,
        float ingredientPrice, Sprite ingredientSprite)
    {
        this.ingredientId = ingredientId;
        this.ingredientName = ingredientName;
        this.ingredientPrice = ingredientPrice;
        this.ingredientSprite = ingredientSprite;
    }

    public Ingredient()
    {
        this.ingredientId = 0;
        this.ingredientName = "";
        this.ingredientPrice = 1;
        this.ingredientSprite = null;
    }
}
