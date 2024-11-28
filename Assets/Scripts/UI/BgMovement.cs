using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    [SerializeField] private float _speedFactor;

    private float _windSpeed;
    private Renderer _bgREnderer;

    private void Start() 
    {
        _bgREnderer = GetComponent<Renderer>();
        _windSpeed = GameObject.FindGameObjectWithTag("Wind").GetComponent<WindController>().windSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        _bgREnderer.material.mainTextureOffset += new Vector2(_windSpeed * _speedFactor * Time.deltaTime, 0);
    }
}
