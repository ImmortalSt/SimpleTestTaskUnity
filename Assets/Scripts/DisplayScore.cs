using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class DisplayScore : MonoBehaviour
{
    [SerializeField] private float _delay;

    private TMP_Text _text;
    private uint _score = 0;

    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        StartCoroutine(AddScore());
    }

    private IEnumerator AddScore()
    {
        var delay = new WaitForSeconds(_delay);
        while (true) {
            _score++;
            SetScore(_score);
            yield return delay;
        }
    }

    private void SetScore(uint score)
    {
        _text.text = score.ToString();
    }
}
