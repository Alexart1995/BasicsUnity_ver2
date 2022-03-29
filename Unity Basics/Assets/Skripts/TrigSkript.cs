using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigSkript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("govno");
        Destroy(gameObject);
    }
}
