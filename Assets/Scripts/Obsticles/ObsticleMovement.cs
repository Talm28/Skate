using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{
    public float WindSpeed{get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        WindSpeed = GameObject.FindGameObjectWithTag("Wind").GetComponent<WindController>().windSpeed;
    }

    void OnEnable()
    {
        EventsController.Instance.gameOver.AddListener(DeleteObsticle);
    }
    void OnDisable() 
    {
        EventsController.Instance.gameOver.RemoveListener(DeleteObsticle);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * WindSpeed, 0, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    public void DeleteObsticle()
    {
        Destroy(this.gameObject);
    }
}
