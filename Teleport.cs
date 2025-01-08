using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform teleportPoint;
    private Vector3 offset = new Vector3(2, 0, 2);
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position + offset;
    }
}
