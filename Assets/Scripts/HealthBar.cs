using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    
    private float _maxDeltaChangeHeath = 0.5f;

    private void OnEnable()
    {
        _player.ChangedHealth += ChangeSliderVaalue;
    }

    private void OnDisable()
    {
        _player.ChangedHealth -= ChangeSliderVaalue;
    }

    public void ChangeSliderVaalue(float target)
    {
        while (_slider.value != target)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, target, _maxDeltaChangeHeath * Time.deltaTime);
        }
    }
}
