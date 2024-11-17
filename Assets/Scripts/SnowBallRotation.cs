using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallRotation : MonoBehaviour
{
    private ObsticleMovement _obsticleMovement;
    private float _windSpeed;
    [SerializeField] private float _RotationSpeedFactor;

    // Start is called before the first frame update
    void Start()
    {
        _obsticleMovement = GetComponent<ObsticleMovement>();
        _windSpeed = _obsticleMovement.WindSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, 0, _windSpeed * Time.deltaTime * _RotationSpeedFactor);
    }
}
