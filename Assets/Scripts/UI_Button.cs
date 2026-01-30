using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    private SpriteRenderer sr;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

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

        transform.localScale = Vector3.one * scale;
    }
    // Start is called before the first frame update
    void Start()
    {
        FitSpriteToBox();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
