using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    public void DeleteParent()
    {
        Destroy(transform.parent.gameObject);
    }
}
