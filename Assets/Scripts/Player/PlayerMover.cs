using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _direction;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    //private void Update()
    //{
    //    if (_direction != Vector2.zero)
    //        Move();
    //}

    private void FixedUpdate()
    {
        _rigidbody.velocity = Vector2.zero;

        if (_direction != Vector2.zero)
            MoveRigidbody();
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    //private void Move()
    //{
    //    var delta = _direction * _speed * Time.deltaTime;
    //    transform.position = transform.position + new Vector3(delta.x, delta.y, 0);
    //}

    private void MoveRigidbody()
    {
        _rigidbody.velocity = new Vector2(_direction.x * _speed, _direction.y * _speed);
    }
}
