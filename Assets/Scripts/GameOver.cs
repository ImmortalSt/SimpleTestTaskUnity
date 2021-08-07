using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOver : MonoBehaviour
{
    [SerializeField] private UnityEvent _onDied;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Died>(out var died))
            _onDied?.Invoke();
    }
}
