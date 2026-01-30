using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Ui_Crafting_Table : MonoBehaviour
{

    private void FitSpriteToBox()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        BoxCollider2D box = GetComponent<BoxCollider2D>();

        if (sr.sprite == null)
        {
            Debug.LogError("sr not instantiated");
            return;

        }

        Vector2 spriteSize = sr.sprite.bounds.size;
        Vector2 boxSize = box.size;

        float scaleX = boxSize.x / spriteSize.x;
        float scaleY = boxSize.y / spriteSize.y;

        float scale = Mathf.Min(scaleX, scaleY);
        sr.transform.localScale = Vector3.one * scale;
    }

    // Start is called before the first frame update
    private void Start()
    {
        FitSpriteToBox();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
