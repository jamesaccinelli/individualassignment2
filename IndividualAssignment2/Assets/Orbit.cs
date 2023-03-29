using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] float degreesPerSecond;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f, Space.Self);
    }
}
