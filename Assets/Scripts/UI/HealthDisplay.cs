using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthDisplay;
    [SerializeField] private Player _player;
    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
        
    }

    private  void OnHealthChanged(int health)
    {
        _healthDisplay.text = health.ToString();
    }
}
