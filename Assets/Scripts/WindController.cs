using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    public float windSpeed;

    private ParticleSystem _particleSystem;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        var main = _particleSystem.main;
        main.startSpeed = windSpeed;

        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateClock();
    }

    public void UpdateClock()
    {
        _timer += Time.deltaTime;
        if(_timer > 1)
        {
            _timer = 0;
            SpeedUpWind();
        }
    }

    private void SpeedUpWind()
    {
        if(windSpeed < 30)
        {
            windSpeed += 0.1f;
            var main = _particleSystem.main;
            main.startSpeed = windSpeed;
        }
        
    }
}
