using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIclickandhold : MonoBehaviour
{
    // Objeto que quieres mover (ingrediente)
    public GameObject objeto;

    // Zona donde quieres soltarlo (table)
    public Collider2D TableZone;
    public Collider2D[] BagZones;
    public Collider2D[] ButtonZones;

    public Camera cam;

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    Debug.Log("Click en: " + gameObject.name);
    //}

    private void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hit = Physics2D.OverlapPoint(mouseWorld);

            if (hit.name == "CraftingTable")
            {
            }
            if (hit.name == "IC_A")
            {
            }
            if (hit.name == "IC_B")
            {
            }
            if (hit.name == "IC_C")
            {
            }
            if (hit.name == "IC_D")
            {
            }
            if (hit.name == "IC_E")
            {
            }
            if (hit.name == "IC_F")
            {
            }
            if (hit.name == "IC_G")
            {
            }
            if (hit.name == "IC_H")
            {
            }
            if (hit.name == "IC_I")
            {
            }
            
            if (hit != null)
            {
                Debug.Log("Has clicado en el vacio");
            }
        }
    }
}
