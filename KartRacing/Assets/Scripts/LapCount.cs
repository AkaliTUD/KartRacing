using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCount : MonoBehaviour
{
    public int lastCheckpoint;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CarLaps>())
        {
            CarLaps car = other.GetComponent<CarLaps>();

            if (car.checkpoint == lastCheckpoint)
            {
                car.checkpoint = 0;
                car.lap++;
                Debug.Log(car.lap);
            }
        }
    }
}
