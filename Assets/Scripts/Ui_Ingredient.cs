using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Ui_Ingredient : MonoBehaviour
{

    [Header("Drag tuning")]
    [SerializeField] private float followSpeed = 30f; // bigger = snappier
    [SerializeField] private bool keepOnTopWhileDragging = true;

    [Header("Ingredient Sprites")]
    [SerializeField] private Sprite[] sprites;
    private SpriteRenderer sr;

    private Camera _cam;
    private Rigidbody2D _rb;
    private Collider2D _col;

    private bool _dragging;
    private Vector3 _grabOffsetWorld;
    private int _originalSortingOrder;

    public GameObject DropZone;
    private Vector3 _startPosition;

    private void Awake()
    {
        _cam = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
        _col = GetComponent<Collider2D>();

        // Recommended settings for “drag object” behavior
        _rb.bodyType = RigidbodyType2D.Kinematic;
        _rb.gravityScale = 0f;
        _rb.freezeRotation = true;

        _startPosition = transform.position;

        // Optional: if using SpriteRenderer, we can bring it above other sprites while dragging
        sr = GetComponent<SpriteRenderer>();
        if (sr != null) _originalSortingOrder = sr.sortingOrder;
    }

    public void SetSprite(int spriteID)
    {
        if (spriteID < 0 || spriteID >= sprites.Length) return;

        if(sr == null)
        {
            Debug.Log("sr is not ready");
        }

        sr.sprite = sprites[spriteID];
    }

    //public void BeginDragImmediately(int SelectedIngredient)
    //{
    //    //// Called right after spawning so player is already holding it.
    //    //StartDrag();
    //    //SetSprite(SelectedIngredient);
    //}

    //private void StartDrag()
    //{
    //    _dragging = true;
    //    _grabOffsetWorld = transform.position - GetMouseWorld();

    //    if (keepOnTopWhileDragging)
    //    {
    //        var sr = GetComponent<SpriteRenderer>();
    //        if (sr != null) sr.sortingOrder = 1000;
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    StopDragAndDrop();
    //}

    private void StopDragAndDrop()
    {
        //_dragging = false;
        //Debug.Log("Hola");
        //// Restore sorting
        //var sr = GetComponent<SpriteRenderer>();
        //if (sr != null) sr.sortingOrder = _originalSortingOrder;

        //// If over a table dropzone, snap into it; otherwise return or destroy (your choice)
        //if (DropZone != null)
        //{
        //    return;            
        //}

        //Destroy(this.gameObject);

    }

    //private Vector3 GetMouseWorld()
    //{
    //    //if (_cam == null) _cam = Camera.main;

    //    //Vector3 mouse = Input.mousePosition;
    //    //mouse.z = -_cam.transform.position.z; // distance from camera for 2D
    //    //return _cam.ScreenToWorldPoint(mouse);
    //}

    // Drop zone detection
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    var zone = other.GetComponent<GameObject>();
    //    if (zone != null) DropZone = zone;
    //}

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    var zone = other.GetComponent<Ui_Crafting_Table>();
    //    if (zone != null && zone == DropZone) DropZone = null;
    //}

    private void FitSpriteToCircle()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        CircleCollider2D circle = GetComponent<CircleCollider2D>();

        if (sr.sprite == null)
        {
            Debug.LogError("sr not instantiated");
            return;

        }

        Vector2 spriteWorldSize = sr.bounds.size;
        float diameter = circle.radius * 2f;
        float circleWorldDiameter = diameter * transform.lossyScale.x;

        float scaleX = circleWorldDiameter / spriteWorldSize.x;
        float scaleY = circleWorldDiameter / spriteWorldSize.y;

        float scale = Mathf.Min(scaleX, scaleY);

        // Apply absolute scale
        transform.localScale = Vector3.one * scale;
    }

    // Start is called before the first frame update
    void Start()
    {
        FitSpriteToCircle();
    }
    private void Update()
    {
        //if (!_dragging) return;

        //Vector3 mouseWorld = GetMouseWorld();
        //Vector3 target = mouseWorld + _grabOffsetWorld;

        //// Smooth follow (feels nicer than teleport)
        //Vector3 newPos = Vector3.Lerp(transform.position, target, Time.deltaTime * followSpeed);
        //_rb.MovePosition(newPos);
    }

}
