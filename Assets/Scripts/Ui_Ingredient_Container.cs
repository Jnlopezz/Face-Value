using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Ui_Ingredient_Container : MonoBehaviour
{
    [Header("Object Spawned Position")]
    private Transform spawnPoint;

    [Header("Position")]
    /*[SerializeField]*/
    private Vector2 spawnOffset = new Vector2(0.5f, 0f);

    [Header("Stored Ingredient")]
    [SerializeField] private int StoredIngredient;

    private SpriteRenderer sr;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    //private void OnMouseDown()
    //{

    //    //Debug.Log("Ingredients box clicked!");
    //    //if (ingredientPrefab == null)
    //    //{
    //    //    Debug.LogError("[IngredientsSource] No ingredientPrefab assigned.");
    //    //    return;
    //    //}

    //    //Vector3 basePos = spawnPoint != null ? spawnPoint.position : transform.position;
    //    ////Vector3 pos = basePos + (Vector3)spawnOffset;

    //    //GameObject go = Instantiate(ingredientPrefab, basePos, Quaternion.identity);
    //    //Ui_Ingredient spawned = go.GetComponent<Ui_Ingredient>();
    //    //spawned.BeginDragImmediately(StoredIngredient); // feels like you "pick it up" on click
    //}

    private void FitSpriteToBox()
    {

        BoxCollider2D box = GetComponent<BoxCollider2D>();

        if (sr.sprite == null)
        {
            Debug.LogError("sr not instantiated");
            return;
        }

        // Current sprite size in world units
        Vector2 spriteSize = sr.bounds.size;

        // Target size from collider (local) converted to world scale
        Vector2 boxSize = box.size;

        // Scale factors needed
        float scaleX = boxSize.x / spriteSize.x;
        float scaleY = boxSize.y / spriteSize.y;

        // Apply scale (Fit = keep proportions)
        float scale = Mathf.Min(scaleX, scaleY);

        sr.transform.localScale = Vector3.one * scale;
    }


    private void Start()
    {
        FitSpriteToBox();
    }

}

