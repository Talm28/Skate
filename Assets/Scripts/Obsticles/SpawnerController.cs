using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private Transform _lowSpawnerLocation;
    [SerializeField] private Transform _highSpawnerLocation;
    [SerializeField] private GameObject[] _Obsticles;
    [SerializeField] private GameObject[] _pickUps;

    private float _timer;
    private System.Random _random;
    private float _timeToSpawn;
    private bool _isSpawning;

    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
        _random = new System.Random();
        _timeToSpawn = 1f;
        _isSpawning = true;

        EventsController.Instance.gameOver.AddListener(DisableSpawner);
    }

    // Update is called once per frame
    void Update()
    {
        if(_isSpawning)
            UpdateTimer();
    }
    
    private void UpdateTimer()
    {
        _timer += Time.deltaTime;
        if (_timer > _timeToSpawn)
        {
            _timeToSpawn = Random.Range(0.8f, 1.25f);
            _timer = 0;
            SpawnObsticles();
        }
    }

    private void SpawnObsticles()
    {
        if(_random.Next(0,5) == 0) // Choose to spawn pickup
        {
            if(_random.Next(0,2) == 0) // Chhose to spawn pickup in high spawner
            {
                Instantiate(_pickUps[_random.Next(0,_pickUps.Length)], _highSpawnerLocation.position, Quaternion.identity);
                if(_random.Next(0,3) == 0) // Spawn snowball in addition
                   Instantiate(_Obsticles[_random.Next(0,_Obsticles.Length)], _lowSpawnerLocation.position, Quaternion.identity); 
            }
            else
            {
                Instantiate(_pickUps[_random.Next(0,_pickUps.Length)], _lowSpawnerLocation.position, Quaternion.identity);
            }
        }
        else // Choose to spawn snow ball
        {
            Instantiate(_Obsticles[_random.Next(0,_Obsticles.Length)], _lowSpawnerLocation.position, Quaternion.identity);
        }
    }

    public void DisableSpawner()
    {
        _isSpawning = false;
    }
}
