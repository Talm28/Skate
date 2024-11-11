using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    public float windSpeed;

    private ParticleSystem _particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        var main = _particleSystem.main;
        main.startSpeed = windSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        var main = _particleSystem.main;
        main.startSpeed = windSpeed;
    }
}
