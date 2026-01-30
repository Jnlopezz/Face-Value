using System.Collections.Generic;
using UnityEngine;

public class MaskRecipes : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    List<Sprite> maskSprites = new List<Sprite>(new Sprite[30]); // M1..M30
    Sprite mask;

    private void Start()
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            maskSprites[i] = sprites[i];
        }
    }

    public Sprite Calcular(bool[] ingredients, Sprite[] maskSprites)
    {
        Sprite mask = null;

        // M1 = A + D
        if (ingredients[0] && ingredients[3]) 
        {
            mask = maskSprites[0];
        }

        // M2 = B + E
        if (ingredients[1] && ingredients[4]) 
        {
            mask = maskSprites[1];
        }

        // M3 = A + B
        if (ingredients[0] && ingredients[1])
        {
            mask = maskSprites[2];
        }

        // M4 = A + C
        if (ingredients[0] && ingredients[2])
        {
            mask = maskSprites[3];
        }

        // M5 = B + C
        if (ingredients[1] && ingredients[2])
        {
            mask = maskSprites[4];
        }

        // M6 = A + B + C
        if (ingredients[0] && ingredients[1] && ingredients[2])
        {
            mask = maskSprites[5];
        }

        // M7 = C + F
        if (ingredients[2] && ingredients[5])
        {
            mask = maskSprites[6];
        }

        // M8 = C + D
        if (ingredients[2] && ingredients[3])
        {
            mask = maskSprites[7];
        }

        // M9 = A + D + E
        if (ingredients[0] && ingredients[3] && ingredients[4])
        {
            mask = maskSprites[8];
        }

        // M10 = B + D + F
        if (ingredients[1] && ingredients[3] && ingredients[5])
        {
            mask = maskSprites[9];
        }

        // M11 = A + B + C + D
        if (ingredients[0] && ingredients[1] && ingredients[2] && ingredients[3])
        {
            mask = maskSprites[10];
        }

        // M12 = E + F
        if (ingredients[4] && ingredients[5])
        {
            mask = maskSprites[11];
        }

        // M13 = D + E + F
        if (ingredients[3] && ingredients[4] && ingredients[5])
        {
            mask = maskSprites[12];
        }

        // M14 = C + E + G
        if (ingredients[2] && ingredients[4] && ingredients[6])
        {
            mask = maskSprites[13];
        }

        // M15 = A + C + E + F
        if (ingredients[0] && ingredients[2] && ingredients[4] && ingredients[5])
        {
            mask = maskSprites[14];
        }

        // M16 = E + H
        if (ingredients[4] && ingredients[7])
        {
            mask = maskSprites[15];
        }

        // M17 = F + G
        if (ingredients[5] && ingredients[6])
        {
            mask = maskSprites[16];
        }

        // M18 = E + F + G
        if (ingredients[4] && ingredients[5] && ingredients[6])
        {
            mask = maskSprites[17];
        }

        // M19 = D + F + H
        if (ingredients[3] && ingredients[5] && ingredients[7])
        {
            mask = maskSprites[18];
        }

        // M20 = B + E + F + G
        if (ingredients[1] && ingredients[4] && ingredients[5] && ingredients[6])
        {
            mask = maskSprites[19];
        }

        // M21 = F + I
        if (ingredients[5] && ingredients[8])
        {
            mask = maskSprites[20];
        }

        // M22 = G + H
        if (ingredients[6] && ingredients[7])
        {
            mask = maskSprites[21];
        }

        // M23 = F + G + H
        if (ingredients[5] && ingredients[6] && ingredients[7])
        {
            mask = maskSprites[22];
        }

        // M24 = E + G + I
        if (ingredients[4] && ingredients[6] && ingredients[8])
        {
            mask = maskSprites[23];
        }

        // M25 = D + F + G + H
        if (ingredients[3] && ingredients[5] && ingredients[6] && ingredients[7])
        {
            mask = maskSprites[24];
        }

        // M26 = G + I
        if (ingredients[6] && ingredients[8])
        {
            mask = maskSprites[25];
        }

        // M27 = H + I
        if (ingredients[7] && ingredients[8])
        {
            mask = maskSprites[26];
        }

        // M28 = G + H + I
        if (ingredients[6] && ingredients[7] && ingredients[8])
        {
            mask = maskSprites[27];
        }

        // M29 = F + H + I
        if (ingredients[5] && ingredients[7] && ingredients[8])
        {
            mask = maskSprites[28];
        }

        // M30 = E + G + H + I
        if (ingredients[4] && ingredients[6] && ingredients[7] && ingredients[8])
        {
            mask = maskSprites[29];
        }

        return mask;
    }
}

