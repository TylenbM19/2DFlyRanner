using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;
    [SerializeField] private Image _image;

    private void Start()
    {
    _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged +=
    }

    private void OnDisable()
    {
        _player.HealthChanged +=
    }

    private void ConverthealthPercetage(float health,float maxHealth)
    {

    }

    private IEnumerator SetValue()
    {
        while (_slider.value )
        {
            _slider.value = Mathf.MoveTowards(_slider.value,);
            yield return null;
        }
    }
}
