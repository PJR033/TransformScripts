using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _sizeLimit;
    [SerializeField] private float _speed;

    private float _startScale = 1f;
    private float _currentScale = 1f;
    private int _negativeConverter = -1;

    private void Update()
    {
        _currentScale += _speed * Time.deltaTime;
        gameObject.transform.localScale = new Vector3(1,1,1) * _currentScale;

        if (_currentScale >= _sizeLimit || _currentScale <= _startScale)
        {
            _speed *= _negativeConverter;
        }
    }
}
