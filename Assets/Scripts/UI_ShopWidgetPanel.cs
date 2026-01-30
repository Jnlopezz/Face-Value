using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopWidgetPanel : MonoBehaviour
{

    [Header("UI Refs (assign in Inspector)")]
    private TextMeshProUGUI label;
    [SerializeField] private string labelText;
    [SerializeField] private TMP_InputField inputField; // numeric input
    [SerializeField] private TextMeshProUGUI outputText; // numeric output (display)

    [SerializeField] private Image img;
    [SerializeField] private Sprite[] sprites;
    private int SpriteId;

    public void Init(int id)
    {
        SpriteId = id;
    }

    private void Awake()
    {
        if (img == null) img = GetComponentInChildren<Image>();
    }

    public void SetSprite(int spriteID)
    {
        if (spriteID < 0 || spriteID >= sprites.Length) return;


        img.sprite = sprites[SpriteId];
    }

    public void Setup(int inputDefault = 0, int outputValue = 0)
    { 
        if (label) label.text = labelText;

        if (inputField)
        {
            inputField.contentType = TMP_InputField.ContentType.IntegerNumber;
            inputField.text = inputDefault.ToString();
        }
        
    }

    public int GetInput()
    {
        if (!inputField) return 0;
        return int.TryParse(inputField.text, out int v) ? v : 0;
    }

    public void SetOutput(int value)
    {
        if (outputText) outputText.text = value.ToString();
    }

    public void OnMouseDown()
    {
        Debug.Log("Button clicked =" + gameObject.name);
        if (gameObject.name  == "DecreaseButton")
        {
            Debug.Log("d box clicked!");
            return;
        }
        if (gameObject.name == "IncreaseButton")
        {
            Debug.Log("I box clicked!");
            return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
