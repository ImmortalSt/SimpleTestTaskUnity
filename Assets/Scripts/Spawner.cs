using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _offset;
    [SerializeField] private float _delay;
    [SerializeField] private GameObject _prefab;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var delay = new WaitForSeconds(_delay);

        while (true)
        { 

            if(Random.Range(0, 2) == 0) 
                Instantiate(_prefab, transform.position + new Vector3(0, _offset), Quaternion.identity, transform);
            else
                Instantiate(_prefab, transform.position - new Vector3(0, _offset), Quaternion.identity, transform);
            yield return delay;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + new Vector3(0, _offset), 0.1f);
        Gizmos.DrawSphere(transform.position - new Vector3(0, _offset), 0.1f);
    }
}
