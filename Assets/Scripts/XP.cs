using UnityEngine;

public class XP : MonoBehaviour , IMagnetzable, ITouchable
{
    private bool _canMove;
    private Transform _origin;
    [SerializeField] private float _moveRate = 2f;
    public void Magnetize(Transform target)
    {
        _canMove = true;
        _origin = target;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!_canMove)
            return;

        transform.position = Vector2.Lerp(transform.position, _origin.position, _moveRate/200);
    }
    public void Active()
    {
        Destroy(gameObject);
    }
}
