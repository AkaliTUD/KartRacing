using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarLaps : MonoBehaviour
{
    public int lap;
    public int checkpoint;
    public GameObject thistext;
    

    // Start is called before the first frame update
    void Start()
    {
        lap = 1;
        checkpoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        thistext.GetComponent<Text>().text = "lap :" + lap + "/4";
    }
}
