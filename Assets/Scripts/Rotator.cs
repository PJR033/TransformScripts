using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        gameObject.transform.Rotate(0, _speed, 0);
    }
}
