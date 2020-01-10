using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Configuration Parameters
    [SerializeField] float speedOfSpin = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,speedOfSpin * Time.deltaTime);
    }
}
