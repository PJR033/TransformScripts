using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        gameObject.transform.Rotate(0, _speed, 0);
    }
}
