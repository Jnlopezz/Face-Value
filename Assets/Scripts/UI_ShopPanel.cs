using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopPanel : MonoBehaviour
{

    [Header("Prefab to add into this panel")]
    [SerializeField] private GameObject[] itemPrefabs;
    [SerializeField] private Transform content;
    private GameObject WidgetPrefab;
    private UI_ShopWidgetPanel ShopWidget;

    public void Awake()
    {
        var vlg = GetComponent<VerticalLayoutGroup>();
        if (vlg == null) vlg = gameObject.AddComponent<VerticalLayoutGroup>();

        vlg.childAlignment = TextAnchor.MiddleCenter; // or MiddleCenter
        vlg.spacing = 10f;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;
        vlg.childForceExpandWidth = false;
        vlg.childForceExpandHeight = false;
    }

    // Call this to add one prefab instance
    public void AddItem()
    {
        if (itemPrefabs == null || itemPrefabs.Length == 0)
        {
            Debug.LogError("No prefabs assigned!");
            return;
        }

        int i = 0;
        foreach (GameObject prefab in itemPrefabs)
        {
            GameObject go = Instantiate(prefab, transform, false);
            var widget = go.GetComponent<UI_ShopWidgetPanel>();
            widget.Init(i);
            i++;
        }

        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)transform);
    }
    // Start is called before the first frame update
    void Start()
    {
        AddItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
