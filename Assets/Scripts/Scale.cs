using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _sizeLimit;
    [SerializeField] private float _speed;

    private float _startScale = 1f;
    private float _currentScale = 1f;
    private int _negativeConverter = -1;

    void Update()
    {
        gameObject.transform.localScale = new Vector3(_currentScale, _currentScale, _currentScale);
        _currentScale += _speed * Time.deltaTime;

        if( _currentScale >= _sizeLimit || _currentScale <= _startScale)
        {
            _speed *= _negativeConverter;
        }
    }
}
