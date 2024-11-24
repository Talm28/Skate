using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BgController : MonoBehaviour
{
    [SerializeField] private Transform _centerTransform;
    [SerializeField] private Transform _nextTransform;
    [SerializeField] private GameObject _bgFront;
    [SerializeField] private GameObject _bgBack;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_bgFront, _centerTransform.position, quaternion.identity); 
        Instantiate(_bgBack, _centerTransform.position, quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
