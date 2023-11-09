using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class LayerIntersectionCheck : MonoBehaviour
{
    [SerializeField] private LayerMask _layerCheck;

    private Collider2D _collider;
    private bool _isTouchingLayer;

    public bool IsTouchinglayer => _isTouchingLayer;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _isTouchingLayer = _collider.IsTouchingLayers(_layerCheck);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isTouchingLayer = _collider.IsTouchingLayers(_layerCheck);
    }
}
