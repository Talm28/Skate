using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{
    private float _windSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _windSpeed = GameObject.FindGameObjectWithTag("Wind").GetComponent<WindController>().windSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * _windSpeed, 0, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
