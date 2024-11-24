using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    [SerializeField] private float _speedFactor;
    private Vector3 _nextPosition = new Vector3(33, 0, 0);

    public float WindSpeed{get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        WindSpeed = GameObject.FindGameObjectWithTag("Wind").GetComponent<WindController>().windSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * WindSpeed * _speedFactor, 0, 0);
    }

    void OnBecameInvisible()
    {
        transform.position = _nextPosition;
    }
}
