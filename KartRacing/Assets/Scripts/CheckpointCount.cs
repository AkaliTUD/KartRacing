using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int cP;

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

            if (car.checkpoint == cP + 1 || car.checkpoint == cP - 1)
            {
                car.checkpoint = cP;

                Debug.Log(cP);
            }
        }
    }
}
